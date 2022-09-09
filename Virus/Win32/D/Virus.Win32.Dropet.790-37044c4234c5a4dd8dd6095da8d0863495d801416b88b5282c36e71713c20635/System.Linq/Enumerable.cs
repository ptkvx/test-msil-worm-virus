using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

public static class Enumerable
{
	public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return WhereIterator(source, predicate);
	}

	private static IEnumerable<TSource> WhereIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		foreach (TSource element in source)
		{
			if (predicate(element))
			{
				yield return element;
			}
		}
	}

	public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return WhereIterator(source, predicate);
	}

	private static IEnumerable<TSource> WhereIterator<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		int index = -1;
		foreach (TSource element in source)
		{
			index = checked(index + 1);
			if (predicate(element, index))
			{
				yield return element;
			}
		}
	}

	public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return SelectIterator(source, selector);
	}

	private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
	{
		foreach (TSource element in source)
		{
			yield return selector(element);
		}
	}

	public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return SelectIterator(source, selector);
	}

	private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
	{
		int index = -1;
		foreach (TSource element in source)
		{
			index = checked(index + 1);
			yield return selector(element, index);
		}
	}

	public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return SelectManyIterator(source, selector);
	}

	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
	{
		foreach (TSource element in source)
		{
			foreach (TResult item in selector(element))
			{
				yield return item;
			}
		}
	}

	public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (selector == null)
		{
			throw Error.ArgumentNull("selector");
		}
		return SelectManyIterator(source, selector);
	}

	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
	{
		int index = -1;
		foreach (TSource element in source)
		{
			index = checked(index + 1);
			foreach (TResult item in selector(element, index))
			{
				yield return item;
			}
		}
	}

	public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (collectionSelector == null)
		{
			throw Error.ArgumentNull("collectionSelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return SelectManyIterator(source, collectionSelector, resultSelector);
	}

	private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
	{
		int index = -1;
		foreach (TSource element in source)
		{
			index = checked(index + 1);
			foreach (TCollection subElement in collectionSelector(element, index))
			{
				yield return resultSelector(element, subElement);
			}
		}
	}

	public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (collectionSelector == null)
		{
			throw Error.ArgumentNull("collectionSelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return SelectManyIterator(source, collectionSelector, resultSelector);
	}

	private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
	{
		foreach (TSource element in source)
		{
			foreach (TCollection subElement in collectionSelector(element))
			{
				yield return resultSelector(element, subElement);
			}
		}
	}

	public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return TakeIterator(source, count);
	}

	private static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count)
	{
		if (count <= 0)
		{
			yield break;
		}
		foreach (TSource item in source)
		{
			yield return item;
			int num;
			count = (num = count - 1);
			if (num == 0)
			{
				break;
			}
		}
	}

	public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return TakeWhileIterator(source, predicate);
	}

	private static IEnumerable<TSource> TakeWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		foreach (TSource element in source)
		{
			if (predicate(element))
			{
				yield return element;
				continue;
			}
			break;
		}
	}

	public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return TakeWhileIterator(source, predicate);
	}

	private static IEnumerable<TSource> TakeWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		int index = -1;
		foreach (TSource element in source)
		{
			index = checked(index + 1);
			if (predicate(element, index))
			{
				yield return element;
				continue;
			}
			break;
		}
	}

	public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return SkipIterator(source, count);
	}

	private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count)
	{
		using IEnumerator<TSource> e = source.GetEnumerator();
		while (count > 0 && e.MoveNext())
		{
			count--;
		}
		if (count <= 0)
		{
			while (e.MoveNext())
			{
				yield return e.Current;
			}
		}
	}

	public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return SkipWhileIterator(source, predicate);
	}

	private static IEnumerable<TSource> SkipWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		bool yielding = false;
		foreach (TSource element in source)
		{
			if (!yielding && !predicate(element))
			{
				yielding = true;
			}
			if (yielding)
			{
				yield return element;
			}
		}
	}

	public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		return SkipWhileIterator(source, predicate);
	}

	private static IEnumerable<TSource> SkipWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		int index = -1;
		bool yielding = false;
		foreach (TSource element in source)
		{
			index = checked(index + 1);
			if (!yielding && !predicate(element, index))
			{
				yielding = true;
			}
			if (yielding)
			{
				yield return element;
			}
		}
	}

	public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
	{
		if (outer == null)
		{
			throw Error.ArgumentNull("outer");
		}
		if (inner == null)
		{
			throw Error.ArgumentNull("inner");
		}
		if (outerKeySelector == null)
		{
			throw Error.ArgumentNull("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw Error.ArgumentNull("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return JoinIterator(outer, inner, outerKeySelector, innerKeySelector, resultSelector, null);
	}

	public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (outer == null)
		{
			throw Error.ArgumentNull("outer");
		}
		if (inner == null)
		{
			throw Error.ArgumentNull("inner");
		}
		if (outerKeySelector == null)
		{
			throw Error.ArgumentNull("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw Error.ArgumentNull("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return JoinIterator(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
	}

	private static IEnumerable<TResult> JoinIterator<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		Lookup<TKey, TInner> lookup = Lookup<TKey, TInner>.CreateForJoin(inner, innerKeySelector, comparer);
		foreach (TOuter item in outer)
		{
			Lookup<TKey, TInner>.Grouping g = lookup.GetGrouping(outerKeySelector(item), create: false);
			if (g != null)
			{
				for (int i = 0; i < g.count; i++)
				{
					yield return resultSelector(item, g.elements[i]);
				}
			}
		}
	}

	public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
	{
		if (outer == null)
		{
			throw Error.ArgumentNull("outer");
		}
		if (inner == null)
		{
			throw Error.ArgumentNull("inner");
		}
		if (outerKeySelector == null)
		{
			throw Error.ArgumentNull("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw Error.ArgumentNull("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return GroupJoinIterator(outer, inner, outerKeySelector, innerKeySelector, resultSelector, null);
	}

	public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (outer == null)
		{
			throw Error.ArgumentNull("outer");
		}
		if (inner == null)
		{
			throw Error.ArgumentNull("inner");
		}
		if (outerKeySelector == null)
		{
			throw Error.ArgumentNull("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw Error.ArgumentNull("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		return GroupJoinIterator(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
	}

	private static IEnumerable<TResult> GroupJoinIterator<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		Lookup<TKey, TInner> lookup = Lookup<TKey, TInner>.CreateForJoin(inner, innerKeySelector, comparer);
		foreach (TOuter item in outer)
		{
			yield return resultSelector(item, lookup[outerKeySelector(item)]);
		}
	}

	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return new OrderedEnumerable<TSource, TKey>(source, keySelector, null, descending: false);
	}

	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
	{
		return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, descending: false);
	}

	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return new OrderedEnumerable<TSource, TKey>(source, keySelector, null, descending: true);
	}

	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
	{
		return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, descending: true);
	}

	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.CreateOrderedEnumerable(keySelector, null, descending: false);
	}

	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.CreateOrderedEnumerable(keySelector, comparer, descending: false);
	}

	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.CreateOrderedEnumerable(keySelector, null, descending: true);
	}

	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return source.CreateOrderedEnumerable(keySelector, comparer, descending: true);
	}

	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return new GroupedEnumerable<TSource, TKey, TSource>(source, keySelector, IdentityFunction<TSource>.Instance, null);
	}

	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
	{
		return new GroupedEnumerable<TSource, TKey, TSource>(source, keySelector, IdentityFunction<TSource>.Instance, comparer);
	}

	public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		return new GroupedEnumerable<TSource, TKey, TElement>(source, keySelector, elementSelector, null);
	}

	public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		return new GroupedEnumerable<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer);
	}

	public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
	{
		return new GroupedEnumerable<TSource, TKey, TSource, TResult>(source, keySelector, IdentityFunction<TSource>.Instance, resultSelector, null);
	}

	public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
	{
		return new GroupedEnumerable<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, null);
	}

	public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		return new GroupedEnumerable<TSource, TKey, TSource, TResult>(source, keySelector, IdentityFunction<TSource>.Instance, resultSelector, comparer);
	}

	public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		return new GroupedEnumerable<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, comparer);
	}

	public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		return ConcatIterator(first, second);
	}

	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		foreach (TSource item in first)
		{
			yield return item;
		}
		foreach (TSource item2 in second)
		{
			yield return item2;
		}
	}

	public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return DistinctIterator(source, null);
	}

	public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return DistinctIterator(source, comparer);
	}

	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
	{
		Set<TSource> set = new Set<TSource>(comparer);
		foreach (TSource element in source)
		{
			if (set.Add(element))
			{
				yield return element;
			}
		}
	}

	public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		return UnionIterator(first, second, null);
	}

	public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		return UnionIterator(first, second, comparer);
	}

	private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		Set<TSource> set = new Set<TSource>(comparer);
		foreach (TSource element2 in first)
		{
			if (set.Add(element2))
			{
				yield return element2;
			}
		}
		foreach (TSource element in second)
		{
			if (set.Add(element))
			{
				yield return element;
			}
		}
	}

	public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		return IntersectIterator(first, second, null);
	}

	public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		return IntersectIterator(first, second, comparer);
	}

	private static IEnumerable<TSource> IntersectIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		Set<TSource> set = new Set<TSource>(comparer);
		foreach (TSource item in second)
		{
			set.Add(item);
		}
		foreach (TSource element in first)
		{
			if (set.Remove(element))
			{
				yield return element;
			}
		}
	}

	public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		return ExceptIterator(first, second, null);
	}

	public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		return ExceptIterator(first, second, comparer);
	}

	private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		Set<TSource> set = new Set<TSource>(comparer);
		foreach (TSource item in second)
		{
			set.Add(item);
		}
		foreach (TSource element in first)
		{
			if (set.Add(element))
			{
				yield return element;
			}
		}
	}

	public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return ReverseIterator(source);
	}

	private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source)
	{
		Buffer<TSource> buffer = new Buffer<TSource>(source);
		for (int i = buffer.count - 1; i >= 0; i--)
		{
			yield return buffer.items[i];
		}
	}

	public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return first.SequenceEqual(second, null);
	}

	public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		if (comparer == null)
		{
			comparer = EqualityComparer<TSource>.Default;
		}
		if (first == null)
		{
			throw Error.ArgumentNull("first");
		}
		if (second == null)
		{
			throw Error.ArgumentNull("second");
		}
		using (IEnumerator<TSource> enumerator = first.GetEnumerator())
		{
			using IEnumerator<TSource> enumerator2 = second.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (!enumerator2.MoveNext() || !comparer.Equals(enumerator.Current, enumerator2.Current))
				{
					return false;
				}
			}
			if (enumerator2.MoveNext())
			{
				return false;
			}
		}
		return true;
	}

	public static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source)
	{
		return source;
	}

	public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return new Buffer<TSource>(source).ToArray();
	}

	public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return new List<TSource>(source);
	}

	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return source.ToDictionary(keySelector, IdentityFunction<TSource>.Instance, null);
	}

	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
	{
		return source.ToDictionary(keySelector, IdentityFunction<TSource>.Instance, comparer);
	}

	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		return source.ToDictionary(keySelector, elementSelector, null);
	}

	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (keySelector == null)
		{
			throw Error.ArgumentNull("keySelector");
		}
		if (elementSelector == null)
		{
			throw Error.ArgumentNull("elementSelector");
		}
		Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(comparer);
		foreach (TSource item in source)
		{
			dictionary.Add(keySelector(item), elementSelector(item));
		}
		return dictionary;
	}

	public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return Lookup<TKey, TSource>.Create(source, keySelector, IdentityFunction<TSource>.Instance, null);
	}

	public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
	{
		return Lookup<TKey, TSource>.Create(source, keySelector, IdentityFunction<TSource>.Instance, comparer);
	}

	public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		return Lookup<TKey, TElement>.Create(source, keySelector, elementSelector, null);
	}

	public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		return Lookup<TKey, TElement>.Create(source, keySelector, elementSelector, comparer);
	}

	public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source)
	{
		return source.DefaultIfEmpty(default(TSource));
	}

	public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source, TSource defaultValue)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return DefaultIfEmptyIterator(source, defaultValue);
	}

	private static IEnumerable<TSource> DefaultIfEmptyIterator<TSource>(IEnumerable<TSource> source, TSource defaultValue)
	{
		using IEnumerator<TSource> e = source.GetEnumerator();
		if (!e.MoveNext())
		{
			yield return defaultValue;
			yield break;
		}
		do
		{
			yield return e.Current;
		}
		while (e.MoveNext());
	}

	public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return OfTypeIterator<TResult>(source);
	}

	private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
	{
		foreach (object obj in source)
		{
			if (obj is TResult)
			{
				yield return (TResult)obj;
			}
		}
	}

	public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		return CastIterator<TResult>(source);
	}

	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
	{
		foreach (object obj in source)
		{
			Type resultType = typeof(TResult);
			if (obj == null && resultType.IsPrimitive)
			{
				throw new InvalidCastException();
			}
			if (obj != null && !(obj is string) && obj is IConvertible)
			{
				if (TypeHelper.IsNullableType(resultType))
				{
					Type[] underlyingType = resultType.GetGenericArguments();
					yield return (TResult)Convert.ChangeType(obj, underlyingType[0]);
				}
				else
				{
					yield return (TResult)Convert.ChangeType(obj, resultType);
				}
			}
			else
			{
				yield return (TResult)obj;
			}
		}
	}

	public static TSource First<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is IList<TSource> list)
		{
			if (list.Count > 0)
			{
				return list[0];
			}
		}
		else
		{
			using IEnumerator<TSource> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		throw Error.NoElements();
	}

	public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				return item;
			}
		}
		throw Error.NoMatch();
	}

	public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is IList<TSource> list)
		{
			if (list.Count > 0)
			{
				return list[0];
			}
		}
		else
		{
			using IEnumerator<TSource> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		return default(TSource);
	}

	public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				return item;
			}
		}
		return default(TSource);
	}

	public static TSource Last<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is IList<TSource> list)
		{
			int count = list.Count;
			if (count > 0)
			{
				return list[count - 1];
			}
		}
		else
		{
			using IEnumerator<TSource> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				TSource current;
				do
				{
					current = enumerator.Current;
				}
				while (enumerator.MoveNext());
				return current;
			}
		}
		throw Error.NoElements();
	}

	public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TSource result = default(TSource);
		bool flag = false;
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				result = item;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoMatch();
		}
		return result;
	}

	public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is IList<TSource> list)
		{
			int count = list.Count;
			if (count > 0)
			{
				return list[count - 1];
			}
		}
		else
		{
			using IEnumerator<TSource> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				TSource current;
				do
				{
					current = enumerator.Current;
				}
				while (enumerator.MoveNext());
				return current;
			}
		}
		return default(TSource);
	}

	public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TSource result = default(TSource);
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				result = item;
			}
		}
		return result;
	}

	public static TSource Single<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is IList<TSource> list)
		{
			switch (list.Count)
			{
			case 0:
				throw Error.NoElements();
			case 1:
				return list[0];
			}
		}
		else
		{
			using IEnumerator<TSource> enumerator = source.GetEnumerator();
			if (!enumerator.MoveNext())
			{
				throw Error.NoElements();
			}
			TSource current = enumerator.Current;
			if (!enumerator.MoveNext())
			{
				return current;
			}
		}
		throw Error.MoreThanOneElement();
	}

	public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TSource result = default(TSource);
		long num = 0L;
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				result = item;
				num = checked(num + 1L);
			}
		}
		long num2 = num;
		if (num2 <= 1L && num2 >= 0L)
		{
			switch (num2)
			{
			case 0L:
				throw Error.NoMatch();
			case 1L:
				return result;
			}
		}
		throw Error.MoreThanOneMatch();
	}

	public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is IList<TSource> list)
		{
			switch (list.Count)
			{
			case 0:
				return default(TSource);
			case 1:
				return list[0];
			}
		}
		else
		{
			using IEnumerator<TSource> enumerator = source.GetEnumerator();
			if (!enumerator.MoveNext())
			{
				return default(TSource);
			}
			TSource current = enumerator.Current;
			if (!enumerator.MoveNext())
			{
				return current;
			}
		}
		throw Error.MoreThanOneElement();
	}

	public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		TSource result = default(TSource);
		long num = 0L;
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				result = item;
				num = checked(num + 1L);
			}
		}
		long num2 = num;
		if (num2 <= 1L && num2 >= 0L)
		{
			switch (num2)
			{
			case 0L:
				return default(TSource);
			case 1L:
				return result;
			}
		}
		throw Error.MoreThanOneMatch();
	}

	public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is IList<TSource> list)
		{
			return list[index];
		}
		if (index < 0)
		{
			throw Error.ArgumentOutOfRange("index");
		}
		using IEnumerator<TSource> enumerator = source.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (index != 0)
			{
				index--;
				continue;
			}
			return enumerator.Current;
		}
		throw Error.ArgumentOutOfRange("index");
	}

	public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (index >= 0)
		{
			if (source is IList<TSource> list)
			{
				if (index < list.Count)
				{
					return list[index];
				}
			}
			else
			{
				using IEnumerator<TSource> enumerator = source.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (index != 0)
					{
						index--;
						continue;
					}
					return enumerator.Current;
				}
			}
		}
		return default(TSource);
	}

	public static IEnumerable<int> Range(int start, int count)
	{
		long num = (long)start + (long)count - 1L;
		if (count < 0 || num > 2147483647L)
		{
			throw Error.ArgumentOutOfRange("count");
		}
		return RangeIterator(start, count);
	}

	private static IEnumerable<int> RangeIterator(int start, int count)
	{
		for (int i = 0; i < count; i++)
		{
			yield return start + i;
		}
	}

	public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
	{
		if (count < 0)
		{
			throw Error.ArgumentOutOfRange("count");
		}
		return RepeatIterator(element, count);
	}

	private static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count)
	{
		for (int i = 0; i < count; i++)
		{
			yield return element;
		}
	}

	public static IEnumerable<TResult> Empty<TResult>()
	{
		return EmptyEnumerable<TResult>.Instance;
	}

	public static bool Any<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		using (IEnumerator<TSource> enumerator = source.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return true;
			}
		}
		return false;
	}

	public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				return true;
			}
		}
		return false;
	}

	public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		foreach (TSource item in source)
		{
			if (!predicate(item))
			{
				return false;
			}
		}
		return true;
	}

	public static int Count<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (source is ICollection<TSource> collection)
		{
			return collection.Count;
		}
		int num = 0;
		using IEnumerator<TSource> enumerator = source.GetEnumerator();
		while (enumerator.MoveNext())
		{
			num = checked(num + 1);
		}
		return num;
	}

	public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		int num = 0;
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	public static long LongCount<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		using IEnumerator<TSource> enumerator = source.GetEnumerator();
		while (enumerator.MoveNext())
		{
			num = checked(num + 1L);
		}
		return num;
	}

	public static long LongCount<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (predicate == null)
		{
			throw Error.ArgumentNull("predicate");
		}
		long num = 0L;
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				num = checked(num + 1L);
			}
		}
		return num;
	}

	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
	{
		if (source is ICollection<TSource> collection)
		{
			return collection.Contains(value);
		}
		return source.Contains(value, null);
	}

	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
	{
		if (comparer == null)
		{
			comparer = EqualityComparer<TSource>.Default;
		}
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		foreach (TSource item in source)
		{
			if (comparer.Equals(item, value))
			{
				return true;
			}
		}
		return false;
	}

	public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		using IEnumerator<TSource> enumerator = source.GetEnumerator();
		if (!enumerator.MoveNext())
		{
			throw Error.NoElements();
		}
		TSource val = enumerator.Current;
		while (enumerator.MoveNext())
		{
			val = func(val, enumerator.Current);
		}
		return val;
	}

	public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		TAccumulate val = seed;
		foreach (TSource item in source)
		{
			val = func(val, item);
		}
		return val;
	}

	public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		if (func == null)
		{
			throw Error.ArgumentNull("func");
		}
		if (resultSelector == null)
		{
			throw Error.ArgumentNull("resultSelector");
		}
		TAccumulate val = seed;
		foreach (TSource item in source)
		{
			val = func(val, item);
		}
		return resultSelector(val);
	}

	public static int Sum(this IEnumerable<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int num = 0;
		foreach (int item in source)
		{
			num = checked(num + item);
		}
		return num;
	}

	public static int? Sum(this IEnumerable<int?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int num = 0;
		foreach (int? item in source)
		{
			if (item.HasValue)
			{
				num = checked(num + item.GetValueOrDefault());
			}
		}
		return num;
	}

	public static long Sum(this IEnumerable<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		foreach (long item in source)
		{
			num = checked(num + item);
		}
		return num;
	}

	public static long? Sum(this IEnumerable<long?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		foreach (long? item in source)
		{
			if (item.HasValue)
			{
				num = checked(num + item.GetValueOrDefault());
			}
		}
		return num;
	}

	public static float Sum(this IEnumerable<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		foreach (float item in source)
		{
			float num2 = item;
			num += (double)num2;
		}
		return (float)num;
	}

	public static float? Sum(this IEnumerable<float?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		foreach (float? item in source)
		{
			if (item.HasValue)
			{
				num += (double)item.GetValueOrDefault();
			}
		}
		return (float)num;
	}

	public static double Sum(this IEnumerable<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		foreach (double item in source)
		{
			double num2 = item;
			num += num2;
		}
		return num;
	}

	public static double? Sum(this IEnumerable<double?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		foreach (double? item in source)
		{
			if (item.HasValue)
			{
				num += item.GetValueOrDefault();
			}
		}
		return num;
	}

	public static decimal Sum(this IEnumerable<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal result = 0m;
		foreach (decimal item in source)
		{
			result += item;
		}
		return result;
	}

	public static decimal? Sum(this IEnumerable<decimal?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal value = 0m;
		foreach (decimal? item in source)
		{
			if (item.HasValue)
			{
				value += item.GetValueOrDefault();
			}
		}
		return value;
	}

	public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
	{
		return source.Select(selector).Sum();
	}

	public static int? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
	{
		return source.Select(selector).Sum();
	}

	public static long? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static float Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
	{
		return source.Select(selector).Sum();
	}

	public static float? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static double Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
	{
		return source.Select(selector).Sum();
	}

	public static double? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static decimal Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
	{
		return source.Select(selector).Sum();
	}

	public static decimal? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static int Min(this IEnumerable<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int num = 0;
		bool flag = false;
		foreach (int item in source)
		{
			if (flag)
			{
				if (item < num)
				{
					num = item;
				}
			}
			else
			{
				num = item;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static int? Min(this IEnumerable<int?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int? num = null;
		foreach (int? item in source)
		{
			if (!num.HasValue || item < num)
			{
				num = item;
			}
		}
		return num;
	}

	public static long Min(this IEnumerable<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		bool flag = false;
		foreach (long item in source)
		{
			if (flag)
			{
				if (item < num)
				{
					num = item;
				}
			}
			else
			{
				num = item;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static long? Min(this IEnumerable<long?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long? num = null;
		foreach (long? item in source)
		{
			if (!num.HasValue || item < num)
			{
				num = item;
			}
		}
		return num;
	}

	public static float Min(this IEnumerable<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		float num = 0f;
		bool flag = false;
		foreach (float item in source)
		{
			float num2 = item;
			if (flag)
			{
				if (num2 < num || float.IsNaN(num2))
				{
					num = num2;
				}
			}
			else
			{
				num = num2;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static float? Min(this IEnumerable<float?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		float? num = null;
		foreach (float? item in source)
		{
			if (item.HasValue && (!num.HasValue || item < num || float.IsNaN(item.Value)))
			{
				num = item;
			}
		}
		return num;
	}

	public static double Min(this IEnumerable<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		bool flag = false;
		foreach (double item in source)
		{
			double num2 = item;
			if (flag)
			{
				if (num2 < num || double.IsNaN(num2))
				{
					num = num2;
				}
			}
			else
			{
				num = num2;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static double? Min(this IEnumerable<double?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double? num = null;
		foreach (double? item in source)
		{
			if (item.HasValue && (!num.HasValue || item < num || double.IsNaN(item.Value)))
			{
				num = item;
			}
		}
		return num;
	}

	public static decimal Min(this IEnumerable<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal num = 0m;
		bool flag = false;
		foreach (decimal item in source)
		{
			if (flag)
			{
				if (item < num)
				{
					num = item;
				}
			}
			else
			{
				num = item;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static decimal? Min(this IEnumerable<decimal?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal? num = null;
		foreach (decimal? item in source)
		{
			if (!num.HasValue || item < num)
			{
				num = item;
			}
		}
		return num;
	}

	public static TSource Min<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		Comparer<TSource> @default = Comparer<TSource>.Default;
		TSource val = default(TSource);
		if (val == null)
		{
			foreach (TSource item in source)
			{
				if (item != null && (val == null || @default.Compare(item, val) < 0))
				{
					val = item;
				}
			}
			return val;
		}
		bool flag = false;
		foreach (TSource item2 in source)
		{
			if (flag)
			{
				if (@default.Compare(item2, val) < 0)
				{
					val = item2;
				}
			}
			else
			{
				val = item2;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return val;
	}

	public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
	{
		return source.Select(selector).Min();
	}

	public static int? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
	{
		return source.Select(selector).Min();
	}

	public static long Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
	{
		return source.Select(selector).Min();
	}

	public static long? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
	{
		return source.Select(selector).Min();
	}

	public static float Min<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
	{
		return source.Select(selector).Min();
	}

	public static float? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
	{
		return source.Select(selector).Min();
	}

	public static double Min<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
	{
		return source.Select(selector).Min();
	}

	public static double? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
	{
		return source.Select(selector).Min();
	}

	public static decimal Min<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
	{
		return source.Select(selector).Min();
	}

	public static decimal? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
	{
		return source.Select(selector).Min();
	}

	public static TResult Min<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
	{
		return source.Select(selector).Min();
	}

	public static int Max(this IEnumerable<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int num = 0;
		bool flag = false;
		foreach (int item in source)
		{
			if (flag)
			{
				if (item > num)
				{
					num = item;
				}
			}
			else
			{
				num = item;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static int? Max(this IEnumerable<int?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		int? num = null;
		foreach (int? item in source)
		{
			if (!num.HasValue || item > num)
			{
				num = item;
			}
		}
		return num;
	}

	public static long Max(this IEnumerable<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		bool flag = false;
		foreach (long item in source)
		{
			if (flag)
			{
				if (item > num)
				{
					num = item;
				}
			}
			else
			{
				num = item;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static long? Max(this IEnumerable<long?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long? num = null;
		foreach (long? item in source)
		{
			if (!num.HasValue || item > num)
			{
				num = item;
			}
		}
		return num;
	}

	public static double Max(this IEnumerable<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		bool flag = false;
		foreach (double item in source)
		{
			double num2 = item;
			if (flag)
			{
				if (num2 > num || double.IsNaN(num))
				{
					num = num2;
				}
			}
			else
			{
				num = num2;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static double? Max(this IEnumerable<double?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double? num = null;
		foreach (double? item in source)
		{
			if (item.HasValue && (!num.HasValue || item > num || double.IsNaN(num.Value)))
			{
				num = item;
			}
		}
		return num;
	}

	public static float Max(this IEnumerable<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		float num = 0f;
		bool flag = false;
		foreach (float item in source)
		{
			float num2 = item;
			if (flag)
			{
				if (num2 > num || double.IsNaN(num))
				{
					num = num2;
				}
			}
			else
			{
				num = num2;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static float? Max(this IEnumerable<float?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		float? num = null;
		foreach (float? item in source)
		{
			if (item.HasValue && (!num.HasValue || item > num || float.IsNaN(num.Value)))
			{
				num = item;
			}
		}
		return num;
	}

	public static decimal Max(this IEnumerable<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal num = 0m;
		bool flag = false;
		foreach (decimal item in source)
		{
			if (flag)
			{
				if (item > num)
				{
					num = item;
				}
			}
			else
			{
				num = item;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return num;
	}

	public static decimal? Max(this IEnumerable<decimal?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal? num = null;
		foreach (decimal? item in source)
		{
			if (!num.HasValue || item > num)
			{
				num = item;
			}
		}
		return num;
	}

	public static TSource Max<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		Comparer<TSource> @default = Comparer<TSource>.Default;
		TSource val = default(TSource);
		if (val == null)
		{
			foreach (TSource item in source)
			{
				if (item != null && (val == null || @default.Compare(item, val) > 0))
				{
					val = item;
				}
			}
			return val;
		}
		bool flag = false;
		foreach (TSource item2 in source)
		{
			if (flag)
			{
				if (@default.Compare(item2, val) > 0)
				{
					val = item2;
				}
			}
			else
			{
				val = item2;
				flag = true;
			}
		}
		if (!flag)
		{
			throw Error.NoElements();
		}
		return val;
	}

	public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
	{
		return source.Select(selector).Max();
	}

	public static int? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
	{
		return source.Select(selector).Max();
	}

	public static long Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
	{
		return source.Select(selector).Max();
	}

	public static long? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
	{
		return source.Select(selector).Max();
	}

	public static float Max<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
	{
		return source.Select(selector).Max();
	}

	public static float? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
	{
		return source.Select(selector).Max();
	}

	public static double Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
	{
		return source.Select(selector).Max();
	}

	public static double? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
	{
		return source.Select(selector).Max();
	}

	public static decimal Max<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
	{
		return source.Select(selector).Max();
	}

	public static decimal? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
	{
		return source.Select(selector).Max();
	}

	public static TResult Max<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
	{
		return source.Select(selector).Max();
	}

	public static double Average(this IEnumerable<int> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		long num2 = 0L;
		checked
		{
			foreach (int item in source)
			{
				num += item;
				num2++;
			}
			if (num2 <= 0L)
			{
				throw Error.NoElements();
			}
			return (double)num / (double)num2;
		}
	}

	public static double? Average(this IEnumerable<int?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		long num2 = 0L;
		checked
		{
			foreach (int? item in source)
			{
				if (item.HasValue)
				{
					num += item.GetValueOrDefault();
					num2++;
				}
			}
			if (num2 > 0L)
			{
				return (double)num / (double)num2;
			}
			return null;
		}
	}

	public static double Average(this IEnumerable<long> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		long num2 = 0L;
		checked
		{
			foreach (long item in source)
			{
				num += item;
				num2++;
			}
			if (num2 <= 0L)
			{
				throw Error.NoElements();
			}
			return (double)num / (double)num2;
		}
	}

	public static double? Average(this IEnumerable<long?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		long num = 0L;
		long num2 = 0L;
		checked
		{
			foreach (long? item in source)
			{
				if (item.HasValue)
				{
					num += item.GetValueOrDefault();
					num2++;
				}
			}
			if (num2 > 0L)
			{
				return (double)num / (double)num2;
			}
			return null;
		}
	}

	public static float Average(this IEnumerable<float> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		long num2 = 0L;
		foreach (float item in source)
		{
			float num3 = item;
			num += (double)num3;
			num2 = checked(num2 + 1L);
		}
		if (num2 <= 0L)
		{
			throw Error.NoElements();
		}
		return (float)(num / (double)num2);
	}

	public static float? Average(this IEnumerable<float?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		long num2 = 0L;
		foreach (float? item in source)
		{
			if (item.HasValue)
			{
				num += (double)item.GetValueOrDefault();
				num2 = checked(num2 + 1L);
			}
		}
		if (num2 > 0L)
		{
			return (float)(num / (double)num2);
		}
		return null;
	}

	public static double Average(this IEnumerable<double> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		long num2 = 0L;
		foreach (double item in source)
		{
			double num3 = item;
			num += num3;
			num2 = checked(num2 + 1L);
		}
		if (num2 <= 0L)
		{
			throw Error.NoElements();
		}
		return num / (double)num2;
	}

	public static double? Average(this IEnumerable<double?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		double num = 0.0;
		long num2 = 0L;
		foreach (double? item in source)
		{
			if (item.HasValue)
			{
				num += item.GetValueOrDefault();
				num2 = checked(num2 + 1L);
			}
		}
		if (num2 > 0L)
		{
			return num / (double)num2;
		}
		return null;
	}

	public static decimal Average(this IEnumerable<decimal> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal num = 0m;
		long num2 = 0L;
		foreach (decimal item in source)
		{
			num += item;
			num2 = checked(num2 + 1L);
		}
		if (num2 <= 0L)
		{
			throw Error.NoElements();
		}
		return num / (decimal)num2;
	}

	public static decimal? Average(this IEnumerable<decimal?> source)
	{
		if (source == null)
		{
			throw Error.ArgumentNull("source");
		}
		decimal num = 0m;
		long num2 = 0L;
		foreach (decimal? item in source)
		{
			if (item.HasValue)
			{
				num += item.GetValueOrDefault();
				num2 = checked(num2 + 1L);
			}
		}
		if (num2 > 0L)
		{
			return num / (decimal)num2;
		}
		return null;
	}

	public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
	{
		return source.Select(selector).Average();
	}

	public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
	{
		return source.Select(selector).Average();
	}

	public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
	{
		return source.Select(selector).Average();
	}

	public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
	{
		return source.Select(selector).Average();
	}

	public static float Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
	{
		return source.Select(selector).Average();
	}

	public static float? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
	{
		return source.Select(selector).Average();
	}

	public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
	{
		return source.Select(selector).Average();
	}

	public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
	{
		return source.Select(selector).Average();
	}

	public static decimal Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
	{
		return source.Select(selector).Average();
	}

	public static decimal? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
	{
		return source.Select(selector).Average();
	}
}
