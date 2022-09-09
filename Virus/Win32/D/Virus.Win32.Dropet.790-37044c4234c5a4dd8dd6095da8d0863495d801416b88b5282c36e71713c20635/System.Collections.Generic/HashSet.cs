using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Collections.Generic;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(HashSetDebugView<>))]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class HashSet<T> : IEnumerable<T>, ISerializable, IEnumerable, ICollection<T>, IDeserializationCallback
{
	internal struct ElementCount
	{
		internal int uniqueCount;

		internal int unfoundCount;
	}

	internal struct Slot
	{
		internal int hashCode;

		internal T value;

		internal int next;
	}

	[Serializable]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public struct Enumerator : IDisposable, IEnumerator<T>, IEnumerator
	{
		private HashSet<T> set;

		private int index;

		private int version;

		private T current;

		public T Current => current;

		object IEnumerator.Current
		{
			get
			{
				if (index == 0 || index == set.m_lastIndex + 1)
				{
					throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumOpCantHappen"));
				}
				return Current;
			}
		}

		internal Enumerator(HashSet<T> set)
		{
			this.set = set;
			index = 0;
			version = set.m_version;
			current = default(T);
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			if (version != set.m_version)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
			}
			while (true)
			{
				if (index < set.m_lastIndex)
				{
					if (set.m_slots[index].hashCode >= 0)
					{
						break;
					}
					index++;
					continue;
				}
				index = set.m_lastIndex + 1;
				current = default(T);
				return false;
			}
			current = set.m_slots[index].value;
			index++;
			return true;
		}

		void IEnumerator.Reset()
		{
			if (version != set.m_version)
			{
				throw new InvalidOperationException(SR.GetString("InvalidOperation_EnumFailedVersion"));
			}
			index = 0;
			current = default(T);
		}
	}

	private const int Lower31BitMask = int.MaxValue;

	private const int GrowthFactor = 2;

	private const int StackAllocThreshold = 100;

	private const int ShrinkThreshold = 3;

	private const string CapacityName = "Capacity";

	private const string ElementsName = "Elements";

	private const string ComparerName = "Comparer";

	private const string VersionName = "Version";

	private int[] m_buckets;

	private Slot[] m_slots;

	private int m_count;

	private int m_lastIndex;

	private int m_freeList;

	private IEqualityComparer<T> m_comparer;

	private int m_version;

	private SerializationInfo m_siInfo;

	public int Count => m_count;

	bool ICollection<T>.IsReadOnly => false;

	public IEqualityComparer<T> Comparer => m_comparer;

	public HashSet()
		: this((IEqualityComparer<T>)EqualityComparer<T>.Default)
	{
	}

	public HashSet(IEqualityComparer<T> comparer)
	{
		if (comparer == null)
		{
			comparer = EqualityComparer<T>.Default;
		}
		m_comparer = comparer;
		m_lastIndex = 0;
		m_count = 0;
		m_freeList = -1;
		m_version = 0;
	}

	public HashSet(IEnumerable<T> collection)
		: this(collection, (IEqualityComparer<T>)EqualityComparer<T>.Default)
	{
	}

	public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		: this(comparer)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		int capacity = 0;
		if (collection is ICollection<T> collection2)
		{
			capacity = collection2.Count;
		}
		Initialize(capacity);
		UnionWith(collection);
		if ((m_count == 0 && m_slots.Length > HashHelpers.GetMinPrime()) || (m_count > 0 && m_slots.Length / m_count > 3))
		{
			TrimExcess();
		}
	}

	protected HashSet(SerializationInfo info, StreamingContext context)
	{
		m_siInfo = info;
	}

	void ICollection<T>.Add(T item)
	{
		AddIfNotPresent(item);
	}

	public void Clear()
	{
		if (m_lastIndex > 0)
		{
			Array.Clear(m_slots, 0, m_lastIndex);
			Array.Clear(m_buckets, 0, m_buckets.Length);
			m_lastIndex = 0;
			m_count = 0;
			m_freeList = -1;
		}
		m_version++;
	}

	public bool Contains(T item)
	{
		if (m_buckets != null)
		{
			int num = m_comparer.GetHashCode(item) & 0x7FFFFFFF;
			int num2 = m_buckets[num % m_buckets.Length] - 1;
			while (num2 >= 0)
			{
				if (m_slots[num2].hashCode != num || !m_comparer.Equals(m_slots[num2].value, item))
				{
					num2 = m_slots[num2].next;
					continue;
				}
				return true;
			}
		}
		return false;
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		CopyTo(array, arrayIndex, m_count);
	}

	public bool Remove(T item)
	{
		if (m_buckets != null)
		{
			int num = m_comparer.GetHashCode(item) & 0x7FFFFFFF;
			int num2 = num % m_buckets.Length;
			int num3 = -1;
			int num4 = m_buckets[num2] - 1;
			while (num4 >= 0)
			{
				if (m_slots[num4].hashCode != num || !m_comparer.Equals(m_slots[num4].value, item))
				{
					num3 = num4;
					num4 = m_slots[num4].next;
					continue;
				}
				if (num3 < 0)
				{
					m_buckets[num2] = m_slots[num4].next + 1;
				}
				else
				{
					m_slots[num3].next = m_slots[num4].next;
				}
				m_slots[num4].hashCode = -1;
				m_slots[num4].value = default(T);
				m_slots[num4].next = m_freeList;
				m_freeList = num4;
				m_count--;
				m_version++;
				return true;
			}
		}
		return false;
	}

	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("Version", m_version);
		info.AddValue("Comparer", m_comparer, typeof(IEqualityComparer<T>));
		info.AddValue("Capacity", (m_buckets != null) ? m_buckets.Length : 0);
		if (m_buckets != null)
		{
			T[] array = new T[m_count];
			CopyTo(array);
			info.AddValue("Elements", array, typeof(T[]));
		}
	}

	public virtual void OnDeserialization(object sender)
	{
		if (m_siInfo == null)
		{
			return;
		}
		int @int = m_siInfo.GetInt32("Capacity");
		m_comparer = (IEqualityComparer<T>)m_siInfo.GetValue("Comparer", typeof(IEqualityComparer<T>));
		if (@int != 0)
		{
			m_buckets = new int[@int];
			m_slots = new Slot[@int];
			m_freeList = -1;
			T[] array = (T[])m_siInfo.GetValue("Elements", typeof(T[]));
			if (array == null)
			{
				throw new SerializationException(SR.GetString("Serialization_MissingKeys"));
			}
			for (int i = 0; i < array.Length; i++)
			{
				AddIfNotPresent(array[i]);
			}
		}
		else
		{
			m_buckets = null;
		}
		m_version = m_siInfo.GetInt32("Version");
		m_siInfo = null;
	}

	public bool Add(T item)
	{
		return AddIfNotPresent(item);
	}

	public void UnionWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		foreach (T item in other)
		{
			AddIfNotPresent(item);
		}
	}

	[SecurityCritical]
	public void IntersectWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return;
		}
		if (other is ICollection<T> collection)
		{
			if (collection.Count == 0)
			{
				Clear();
				return;
			}
			if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
			{
				IntersectWithHashSetWithSameEC(hashSet);
				return;
			}
		}
		IntersectWithEnumerable(other);
	}

	public void ExceptWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return;
		}
		if (other == this)
		{
			Clear();
			return;
		}
		foreach (T item in other)
		{
			Remove(item);
		}
	}

	[SecurityCritical]
	public void SymmetricExceptWith(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			UnionWith(other);
		}
		else if (other == this)
		{
			Clear();
		}
		else if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
		{
			SymmetricExceptWithUniqueHashSet(hashSet);
		}
		else
		{
			SymmetricExceptWithEnumerable(other);
		}
	}

	[SecurityCritical]
	public bool IsSubsetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return true;
		}
		if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
		{
			if (m_count > hashSet.Count)
			{
				return false;
			}
			return IsSubsetOfHashSetWithSameEC(hashSet);
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: false);
		if (elementCount.uniqueCount == m_count)
		{
			return elementCount.unfoundCount >= 0;
		}
		return false;
	}

	[SecurityCritical]
	public bool IsProperSubsetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (other is ICollection<T> collection)
		{
			if (m_count == 0)
			{
				return collection.Count > 0;
			}
			if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
			{
				if (m_count >= hashSet.Count)
				{
					return false;
				}
				return IsSubsetOfHashSetWithSameEC(hashSet);
			}
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: false);
		if (elementCount.uniqueCount == m_count)
		{
			return elementCount.unfoundCount > 0;
		}
		return false;
	}

	public bool IsSupersetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (other is ICollection<T> collection)
		{
			if (collection.Count == 0)
			{
				return true;
			}
			if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet) && hashSet.Count > m_count)
			{
				return false;
			}
		}
		return ContainsAllElements(other);
	}

	[SecurityCritical]
	public bool IsProperSupersetOf(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return false;
		}
		if (other is ICollection<T> collection)
		{
			if (collection.Count == 0)
			{
				return true;
			}
			if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
			{
				if (hashSet.Count >= m_count)
				{
					return false;
				}
				return ContainsAllElements(hashSet);
			}
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: true);
		if (elementCount.uniqueCount < m_count)
		{
			return elementCount.unfoundCount == 0;
		}
		return false;
	}

	public bool Overlaps(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_count == 0)
		{
			return false;
		}
		foreach (T item in other)
		{
			if (Contains(item))
			{
				return true;
			}
		}
		return false;
	}

	[SecurityCritical]
	public bool SetEquals(IEnumerable<T> other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (other is HashSet<T> hashSet && AreEqualityComparersEqual(this, hashSet))
		{
			if (m_count != hashSet.Count)
			{
				return false;
			}
			return ContainsAllElements(hashSet);
		}
		if (other is ICollection<T> collection && m_count == 0 && collection.Count > 0)
		{
			return false;
		}
		ElementCount elementCount = CheckUniqueAndUnfoundElements(other, returnIfUnfound: true);
		if (elementCount.uniqueCount == m_count)
		{
			return elementCount.unfoundCount == 0;
		}
		return false;
	}

	public void CopyTo(T[] array)
	{
		CopyTo(array, 0, m_count);
	}

	public void CopyTo(T[] array, int arrayIndex, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0)
		{
			throw new ArgumentOutOfRangeException("arrayIndex", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (arrayIndex <= array.Length && count <= array.Length - arrayIndex)
		{
			int num = 0;
			for (int i = 0; i < m_lastIndex; i++)
			{
				if (num >= count)
				{
					break;
				}
				if (m_slots[i].hashCode >= 0)
				{
					array[arrayIndex + num] = m_slots[i].value;
					num++;
				}
			}
			return;
		}
		throw new ArgumentException(SR.GetString("Arg_ArrayPlusOffTooSmall"));
	}

	public int RemoveWhere(Predicate<T> match)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		int num = 0;
		for (int i = 0; i < m_lastIndex; i++)
		{
			if (m_slots[i].hashCode >= 0)
			{
				T value = m_slots[i].value;
				if (match(value) && Remove(value))
				{
					num++;
				}
			}
		}
		return num;
	}

	public void TrimExcess()
	{
		if (m_count == 0)
		{
			m_buckets = null;
			m_slots = null;
			m_version++;
			return;
		}
		int prime = HashHelpers.GetPrime(m_count);
		Slot[] array = new Slot[prime];
		int[] array2 = new int[prime];
		int num = 0;
		for (int i = 0; i < m_lastIndex; i++)
		{
			if (m_slots[i].hashCode >= 0)
			{
				ref Slot reference = ref array[num];
				reference = m_slots[i];
				int num2 = array[num].hashCode % prime;
				array[num].next = array2[num2] - 1;
				array2[num2] = num + 1;
				num++;
			}
		}
		m_lastIndex = num;
		m_slots = array;
		m_buckets = array2;
		m_freeList = -1;
	}

	public static IEqualityComparer<HashSet<T>> CreateSetComparer()
	{
		return new HashSetEqualityComparer<T>();
	}

	private void Initialize(int capacity)
	{
		int prime = HashHelpers.GetPrime(capacity);
		m_buckets = new int[prime];
		m_slots = new Slot[prime];
	}

	private void IncreaseCapacity()
	{
		int num = m_count * 2;
		if (num < 0)
		{
			num = m_count;
		}
		int prime = HashHelpers.GetPrime(num);
		if (prime <= m_count)
		{
			throw new ArgumentException(SR.GetString("Arg_HSCapacityOverflow"));
		}
		Slot[] array = new Slot[prime];
		if (m_slots != null)
		{
			Array.Copy(m_slots, 0, array, 0, m_lastIndex);
		}
		int[] array2 = new int[prime];
		for (int i = 0; i < m_lastIndex; i++)
		{
			int num2 = array[i].hashCode % prime;
			array[i].next = array2[num2] - 1;
			array2[num2] = i + 1;
		}
		m_slots = array;
		m_buckets = array2;
	}

	private bool AddIfNotPresent(T value)
	{
		if (m_buckets == null)
		{
			Initialize(0);
		}
		int num = m_comparer.GetHashCode(value) & 0x7FFFFFFF;
		int num2 = num % m_buckets.Length;
		int num3 = m_buckets[num % m_buckets.Length] - 1;
		while (true)
		{
			if (num3 >= 0)
			{
				if (m_slots[num3].hashCode == num && m_comparer.Equals(m_slots[num3].value, value))
				{
					break;
				}
				num3 = m_slots[num3].next;
				continue;
			}
			int num4;
			if (m_freeList >= 0)
			{
				num4 = m_freeList;
				m_freeList = m_slots[num4].next;
			}
			else
			{
				if (m_lastIndex == m_slots.Length)
				{
					IncreaseCapacity();
					num2 = num % m_buckets.Length;
				}
				num4 = m_lastIndex;
				m_lastIndex++;
			}
			m_slots[num4].hashCode = num;
			m_slots[num4].value = value;
			m_slots[num4].next = m_buckets[num2] - 1;
			m_buckets[num2] = num4 + 1;
			m_count++;
			m_version++;
			return true;
		}
		return false;
	}

	private bool ContainsAllElements(IEnumerable<T> other)
	{
		foreach (T item in other)
		{
			if (!Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	private bool IsSubsetOfHashSetWithSameEC(HashSet<T> other)
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				T current = enumerator.Current;
				if (!other.Contains(current))
				{
					return false;
				}
			}
		}
		return true;
	}

	private void IntersectWithHashSetWithSameEC(HashSet<T> other)
	{
		for (int i = 0; i < m_lastIndex; i++)
		{
			if (m_slots[i].hashCode >= 0)
			{
				T value = m_slots[i].value;
				if (!other.Contains(value))
				{
					Remove(value);
				}
			}
		}
	}

	[SecurityCritical]
	private unsafe void IntersectWithEnumerable(IEnumerable<T> other)
	{
		int lastIndex = m_lastIndex;
		int num = BitHelper.ToIntArrayLength(lastIndex);
		BitHelper bitHelper;
		if (num <= 100)
		{
			int* bitArrayPtr = (int*)stackalloc byte[4 * num];
			bitHelper = new BitHelper(bitArrayPtr, num);
		}
		else
		{
			int[] bitArray = new int[num];
			bitHelper = new BitHelper(bitArray, num);
		}
		foreach (T item in other)
		{
			int num2 = InternalIndexOf(item);
			if (num2 >= 0)
			{
				bitHelper.MarkBit(num2);
			}
		}
		for (int i = 0; i < lastIndex; i++)
		{
			if (m_slots[i].hashCode >= 0 && !bitHelper.IsMarked(i))
			{
				Remove(m_slots[i].value);
			}
		}
	}

	private int InternalIndexOf(T item)
	{
		int num = m_comparer.GetHashCode(item) & 0x7FFFFFFF;
		int num2 = m_buckets[num % m_buckets.Length] - 1;
		while (true)
		{
			if (num2 >= 0)
			{
				if (m_slots[num2].hashCode == num && m_comparer.Equals(m_slots[num2].value, item))
				{
					break;
				}
				num2 = m_slots[num2].next;
				continue;
			}
			return -1;
		}
		return num2;
	}

	private void SymmetricExceptWithUniqueHashSet(HashSet<T> other)
	{
		foreach (T item in other)
		{
			if (!Remove(item))
			{
				AddIfNotPresent(item);
			}
		}
	}

	[SecurityCritical]
	private unsafe void SymmetricExceptWithEnumerable(IEnumerable<T> other)
	{
		int lastIndex = m_lastIndex;
		int num = BitHelper.ToIntArrayLength(lastIndex);
		BitHelper bitHelper;
		BitHelper bitHelper2;
		if (num <= 50)
		{
			int* bitArrayPtr = (int*)stackalloc byte[4 * num];
			bitHelper = new BitHelper(bitArrayPtr, num);
			int* bitArrayPtr2 = (int*)stackalloc byte[4 * num];
			bitHelper2 = new BitHelper(bitArrayPtr2, num);
		}
		else
		{
			int[] bitArray = new int[num];
			bitHelper = new BitHelper(bitArray, num);
			int[] bitArray2 = new int[num];
			bitHelper2 = new BitHelper(bitArray2, num);
		}
		foreach (T item in other)
		{
			int location = 0;
			if (AddOrGetLocation(item, out location))
			{
				bitHelper2.MarkBit(location);
			}
			else if (location < lastIndex && !bitHelper2.IsMarked(location))
			{
				bitHelper.MarkBit(location);
			}
		}
		for (int i = 0; i < lastIndex; i++)
		{
			if (bitHelper.IsMarked(i))
			{
				Remove(m_slots[i].value);
			}
		}
	}

	private bool AddOrGetLocation(T value, out int location)
	{
		int num = m_comparer.GetHashCode(value) & 0x7FFFFFFF;
		int num2 = num % m_buckets.Length;
		int num3 = m_buckets[num % m_buckets.Length] - 1;
		while (true)
		{
			if (num3 >= 0)
			{
				if (m_slots[num3].hashCode == num && m_comparer.Equals(m_slots[num3].value, value))
				{
					break;
				}
				num3 = m_slots[num3].next;
				continue;
			}
			int num4;
			if (m_freeList >= 0)
			{
				num4 = m_freeList;
				m_freeList = m_slots[num4].next;
			}
			else
			{
				if (m_lastIndex == m_slots.Length)
				{
					IncreaseCapacity();
					num2 = num % m_buckets.Length;
				}
				num4 = m_lastIndex;
				m_lastIndex++;
			}
			m_slots[num4].hashCode = num;
			m_slots[num4].value = value;
			m_slots[num4].next = m_buckets[num2] - 1;
			m_buckets[num2] = num4 + 1;
			m_count++;
			m_version++;
			location = num4;
			return true;
		}
		location = num3;
		return false;
	}

	[SecurityCritical]
	private unsafe ElementCount CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound)
	{
		ElementCount result = default(ElementCount);
		if (m_count == 0)
		{
			int num = 0;
			using (IEnumerator<T> enumerator = other.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					_ = enumerator.Current;
					num++;
				}
			}
			result.uniqueCount = 0;
			result.unfoundCount = num;
			return result;
		}
		int lastIndex = m_lastIndex;
		int num2 = BitHelper.ToIntArrayLength(lastIndex);
		BitHelper bitHelper;
		if (num2 <= 100)
		{
			int* bitArrayPtr = (int*)stackalloc byte[4 * num2];
			bitHelper = new BitHelper(bitArrayPtr, num2);
		}
		else
		{
			int[] bitArray = new int[num2];
			bitHelper = new BitHelper(bitArray, num2);
		}
		int num3 = 0;
		int num4 = 0;
		foreach (T item in other)
		{
			int num5 = InternalIndexOf(item);
			if (num5 >= 0)
			{
				if (!bitHelper.IsMarked(num5))
				{
					bitHelper.MarkBit(num5);
					num4++;
				}
			}
			else
			{
				num3++;
				if (returnIfUnfound)
				{
					break;
				}
			}
		}
		result.uniqueCount = num4;
		result.unfoundCount = num3;
		return result;
	}

	internal T[] ToArray()
	{
		T[] array = new T[Count];
		CopyTo(array);
		return array;
	}

	internal static bool HashSetEquals(HashSet<T> set1, HashSet<T> set2, IEqualityComparer<T> comparer)
	{
		if (set1 == null)
		{
			return set2 == null;
		}
		if (set2 == null)
		{
			return false;
		}
		if (AreEqualityComparersEqual(set1, set2))
		{
			if (set1.Count != set2.Count)
			{
				return false;
			}
			foreach (T item in set2)
			{
				if (!set1.Contains(item))
				{
					return false;
				}
			}
			return true;
		}
		foreach (T item2 in set2)
		{
			bool flag = false;
			foreach (T item3 in set1)
			{
				if (comparer.Equals(item2, item3))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
	{
		return set1.Comparer.Equals(set2.Comparer);
	}
}
