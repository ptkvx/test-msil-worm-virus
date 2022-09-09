using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Contracts;

namespace System.Numeric;

[Serializable]
[ComVisible(false)]
[Immutable]
internal struct BigInteger : IEquatable<BigInteger>, IComparable<BigInteger>, IFormattable, IComparable
{
	private const int DecimalScaleFactorMask = 16711680;

	private const int DecimalSignMask = int.MinValue;

	private const int BitsPerDigit = 32;

	private const ulong Base = 4294967296uL;

	private const int UpperBoundForSchoolBookMultiplicationDigits = 64;

	private const int ForceSchoolBookMultiplicationThresholdDigits = 8;

	private static readonly uint[] maxCharsPerDigit = new uint[37]
	{
		0u, 0u, 31u, 20u, 15u, 13u, 12u, 11u, 10u, 10u,
		9u, 9u, 8u, 8u, 8u, 8u, 7u, 7u, 7u, 7u,
		7u, 7u, 7u, 7u, 6u, 6u, 6u, 6u, 6u, 6u,
		6u, 6u, 6u, 6u, 6u, 6u, 6u
	};

	private static readonly uint[] groupRadixValues = new uint[37]
	{
		0u, 0u, 2147483648u, 3486784401u, 1073741824u, 1220703125u, 2176782336u, 1977326743u, 1073741824u, 3486784401u,
		1000000000u, 2357947691u, 429981696u, 815730721u, 1475789056u, 2562890625u, 268435456u, 410338673u, 612220032u, 893871739u,
		1280000000u, 1801088541u, 2494357888u, 3404825447u, 191102976u, 244140625u, 308915776u, 387420489u, 481890304u, 594823321u,
		729000000u, 887503681u, 1073741824u, 1291467969u, 1544804416u, 1838265625u, 2176782336u
	};

	private static readonly uint[] zeroArray = new uint[0];

	private readonly short _sign;

	private readonly uint[] _data;

	private int _length;

	public static BigInteger Zero => new BigInteger(0, zeroArray);

	public static BigInteger One => new BigInteger(1);

	public static BigInteger MinusOne => new BigInteger(-1);

	public int Sign
	{
		[Pure]
		get
		{
			return _sign;
		}
	}

	private int Length
	{
		get
		{
			if (_length == -1)
			{
				_length = GetLength(_data);
			}
			return _length;
		}
	}

	public BigInteger(int value)
	{
		if (value == 0)
		{
			_sign = 0;
			_data = new uint[0];
		}
		else if (value < 0)
		{
			_sign = -1;
			_data = new uint[1] { (uint)(-value) };
		}
		else
		{
			_sign = 1;
			_data = new uint[1] { (uint)value };
		}
		_length = -1;
	}

	public BigInteger(long value)
	{
		ulong num = 0uL;
		if (value < 0L)
		{
			num = (ulong)(-value);
			_sign = -1;
		}
		else if (value > 0L)
		{
			num = (ulong)value;
			_sign = 1;
		}
		else
		{
			_sign = 0;
		}
		if (num >= 4294967296L)
		{
			_data = new uint[2];
			_data[0] = (uint)num;
			_data[1] = (uint)(num >> 32);
		}
		else
		{
			_data = new uint[1];
			_data[0] = (uint)num;
		}
		_length = -1;
	}

	[CLSCompliant(false)]
	public BigInteger(uint value)
	{
		if (value == 0)
		{
			_sign = 0;
		}
		else
		{
			_sign = 1;
		}
		_data = new uint[1];
		_data[0] = value;
		_length = -1;
	}

	[CLSCompliant(false)]
	public BigInteger(ulong value)
	{
		if (value == 0L)
		{
			_sign = 0;
		}
		else
		{
			_sign = 1;
		}
		if (value >= 4294967296L)
		{
			_data = new uint[2];
			_data[0] = (uint)value;
			_data[1] = (uint)(value >> 32);
		}
		else
		{
			_data = new uint[1];
			_data[0] = (uint)value;
		}
		_length = -1;
	}

	public BigInteger(float value)
		: this((double)value)
	{
	}

	public BigInteger(double value)
	{
		Contract.Requires((!double.IsInfinity(value)) ? null : new OverflowException(Res.BigIntInfinity));
		Contract.Requires((!double.IsNaN(value)) ? null : new OverflowException(Res.NotANumber));
		byte[] bytes = BitConverter.GetBytes(value);
		ulong num = Mantissa(bytes);
		if (num == 0L)
		{
			int num2 = Exponent(bytes);
			if (num2 == 0)
			{
				_sign = 0;
				_data = zeroArray;
				_length = 0;
				return;
			}
			BigInteger x = (IsNegative(bytes) ? Negate(One) : One);
			x = LeftShift(x, num2 - 1023);
			_sign = x._sign;
			_data = x._data;
		}
		else
		{
			int num3 = Exponent(bytes);
			num |= 0x10000000000000uL;
			BigInteger x2 = new BigInteger(num);
			x2 = ((num3 > 1075) ? LeftShift(x2, num3 - 1075) : RightShift(x2, 1075 - num3));
			_sign = (IsNegative(bytes) ? ((short)(x2._sign * -1)) : x2._sign);
			_data = x2._data;
		}
		_length = -1;
	}

	public BigInteger(decimal value)
	{
		int[] bits = decimal.GetBits(decimal.Truncate(value));
		int num = 3;
		while (num > 0 && bits[num - 1] == 0)
		{
			num--;
		}
		_length = num;
		if (num == 0)
		{
			_sign = 0;
			_data = new uint[0];
			return;
		}
		uint[] array = new uint[num];
		array[0] = (uint)bits[0];
		if (num > 1)
		{
			array[1] = (uint)bits[1];
		}
		if (num > 2)
		{
			array[2] = (uint)bits[2];
		}
		_sign = (short)(((bits[3] & int.MinValue) == 0) ? 1 : (-1));
		_data = array;
	}

	public BigInteger(byte[] value)
		: this(value, negative: false)
	{
	}

	public BigInteger(byte[] value, bool negative)
	{
		Contract.Requires((value != null) ? null : new ArgumentNullException("value"));
		int num = value.Length / 4;
		int num2 = value.Length % 4;
		if (num2 > 0)
		{
			_data = new uint[num + 1];
		}
		else
		{
			_data = new uint[num];
		}
		Buffer.BlockCopy(value, 0, _data, 0, num * 4);
		if (num2 > 0)
		{
			uint num3 = 0u;
			for (int i = 0; i < num2; i++)
			{
				num3 |= (uint)(value[num * 4 + i] << 8 * i);
			}
			_data[num] = num3;
		}
		_sign = (short)((!negative) ? 1 : (-1));
		_length = -1;
		if (Length == 0)
		{
			_sign = 0;
			_data = zeroArray;
		}
	}

	private BigInteger(int _sign, params uint[] _data)
	{
		Contract.Requires(_data != null);
		Contract.Requires(_sign >= -1 && _sign <= 1);
		Contract.Requires(_sign != 0 || GetLength(_data) == 0);
		if (GetLength(_data) == 0)
		{
			_sign = 0;
		}
		this._data = _data;
		this._sign = (short)_sign;
		_length = -1;
	}

	public static BigInteger Abs(BigInteger x)
	{
		if (x._sign == -1)
		{
			return -x;
		}
		return x;
	}

	public static BigInteger GreatestCommonDivisor(BigInteger x, BigInteger y)
	{
		Contract.Requires((x.Sign != 0) ? null : new ArgumentOutOfRangeException("x", Res.MustBePositive));
		Contract.Requires((y.Sign != 0) ? null : new ArgumentOutOfRangeException("y", Res.MustBePositive));
		x = Abs(x);
		y = Abs(y);
		int num = Compare(x, y);
		if (num == 0)
		{
			return x;
		}
		BigInteger bigInteger;
		BigInteger bigInteger2;
		if (num < 1)
		{
			bigInteger = x;
			bigInteger2 = y;
		}
		else
		{
			bigInteger = y;
			bigInteger2 = x;
		}
		do
		{
			BigInteger bigInteger3 = bigInteger2;
			DivRem(bigInteger, bigInteger2, out var remainder);
			bigInteger2 = remainder;
			bigInteger = bigInteger3;
		}
		while (bigInteger2 != 0);
		return bigInteger;
	}

	public static BigInteger Remainder(BigInteger dividend, BigInteger divisor)
	{
		DivRem(dividend, divisor, out var remainder);
		return remainder;
	}

	public static BigInteger Negate(BigInteger x)
	{
		BigInteger result = new BigInteger(-x._sign, (x._data == null) ? zeroArray : x._data);
		result._length = x._length;
		return result;
	}

	public static BigInteger Pow(BigInteger baseValue, BigInteger exponent)
	{
		Contract.Requires((exponent >= 0) ? null : new ArgumentOutOfRangeException("exponent", Res.NonNegative));
		if (exponent == 0)
		{
			return One;
		}
		BigInteger bigInteger = baseValue;
		BigInteger one = One;
		while (exponent > 0)
		{
			if ((exponent._data[0] & (true ? 1u : 0u)) != 0)
			{
				one *= bigInteger;
			}
			if (exponent == 1)
			{
				break;
			}
			bigInteger = bigInteger.Square();
			exponent = RightShift(exponent, 1);
		}
		return one;
	}

	public static BigInteger ModPow(BigInteger baseValue, BigInteger exponent, BigInteger modulus)
	{
		Contract.Requires((exponent >= 0) ? null : new ArgumentOutOfRangeException("exponent", Res.NonNegative));
		if (exponent == 0)
		{
			return One;
		}
		BigInteger bigInteger = baseValue;
		BigInteger one = One;
		while (exponent > 0)
		{
			if ((exponent._data[0] & (true ? 1u : 0u)) != 0)
			{
				one *= bigInteger;
				one %= modulus;
			}
			if (exponent == 1)
			{
				break;
			}
			bigInteger = bigInteger.Square();
			exponent = RightShift(exponent, 1);
		}
		return one;
	}

	private BigInteger Square()
	{
		return this * this;
	}

	public byte[] ToByteArray()
	{
		bool isNegative;
		return ToByteArray(out isNegative);
	}

	public byte[] ToByteArray(out bool isNegative)
	{
		int length = Length;
		byte[] array = new byte[length * 4];
		Buffer.BlockCopy(_data, 0, array, 0, length * 4);
		isNegative = _sign == -1;
		return array;
	}

	public static BigInteger operator +(BigInteger value)
	{
		return value;
	}

	public static BigInteger operator -(BigInteger value)
	{
		return Negate(value);
	}

	public static BigInteger operator ++(BigInteger value)
	{
		if (value._sign >= 0)
		{
			return new BigInteger(1, add0(value._data, value.Length, new uint[1] { 1u }, 1));
		}
		if (value.Length == 1 && value._data[0] == 1)
		{
			return Zero;
		}
		return new BigInteger(-1, sub(value._data, value.Length, new uint[1] { 1u }, 1));
	}

	public static BigInteger operator --(BigInteger value)
	{
		int length = value.Length;
		uint[] data;
		int sign;
		if (value._sign == 1)
		{
			if (length == 1 && value._data[0] == 1)
			{
				return Zero;
			}
			data = sub(value._data, length, new uint[1] { 1u }, 1);
			sign = 1;
		}
		else
		{
			data = add0(value._data, length, new uint[1] { 1u }, 1);
			sign = -1;
		}
		return new BigInteger(sign, data);
	}

	public static BigInteger operator %(BigInteger x, BigInteger y)
	{
		if (x._sign == y._sign && x.Length < y.Length)
		{
			return x;
		}
		DivRem(x, y, out var remainder);
		return remainder;
	}

	public static explicit operator byte(BigInteger value)
	{
		if (value._sign == 0)
		{
			return 0;
		}
		if (value.Length > 1)
		{
			throw new OverflowException(Res.Overflow_Byte);
		}
		if (value._data[0] > 255)
		{
			throw new OverflowException(Res.Overflow_Byte);
		}
		if (value._sign < 0)
		{
			throw new OverflowException(Res.Overflow_Byte);
		}
		return (byte)value._data[0];
	}

	[CLSCompliant(false)]
	public static explicit operator sbyte(BigInteger value)
	{
		if (value._sign == 0)
		{
			return 0;
		}
		if (value.Length > 1)
		{
			throw new OverflowException(Res.Overflow_SByte);
		}
		if (value._data[0] > 128)
		{
			throw new OverflowException(Res.Overflow_SByte);
		}
		if (value._data[0] == 128 && value._sign == 1)
		{
			throw new OverflowException(Res.Overflow_SByte);
		}
		sbyte b = (sbyte)value._data[0];
		return (sbyte)(b * (sbyte)value._sign);
	}

	public static explicit operator short(BigInteger value)
	{
		if (value._sign == 0)
		{
			return 0;
		}
		if (value.Length > 1)
		{
			throw new OverflowException(Res.Overflow_Int16);
		}
		if (value._data[0] > 32768)
		{
			throw new OverflowException(Res.Overflow_Int16);
		}
		if (value._data[0] == 32768 && value._sign == 1)
		{
			throw new OverflowException(Res.Overflow_Int16);
		}
		short num = (short)value._data[0];
		return (short)(num * value._sign);
	}

	[CLSCompliant(false)]
	public static explicit operator ushort(BigInteger value)
	{
		if (value._sign == 0)
		{
			return 0;
		}
		if (value.Length > 1)
		{
			throw new OverflowException(Res.Overflow_UInt16);
		}
		if (value._data[0] > 65535)
		{
			throw new OverflowException(Res.Overflow_UInt16);
		}
		if (value._sign < 0)
		{
			throw new OverflowException(Res.Overflow_UInt16);
		}
		return (ushort)value._data[0];
	}

	public static explicit operator int(BigInteger value)
	{
		if (value._sign == 0)
		{
			return 0;
		}
		if (value.Length > 1)
		{
			throw new OverflowException(Res.Overflow_Int32);
		}
		if (value._data[0] > 2147483648u)
		{
			throw new OverflowException(Res.Overflow_Int32);
		}
		if (value._data[0] == 2147483648u && value._sign == 1)
		{
			throw new OverflowException(Res.Overflow_Int32);
		}
		int num = (int)value._data[0];
		return num * value._sign;
	}

	[CLSCompliant(false)]
	public static explicit operator uint(BigInteger value)
	{
		if (value._sign == 0)
		{
			return 0u;
		}
		if (value.Length > 1)
		{
			throw new OverflowException(Res.Overflow_UInt32);
		}
		if (value._sign < 0)
		{
			throw new OverflowException(Res.Overflow_UInt32);
		}
		return value._data[0];
	}

	public static explicit operator long(BigInteger value)
	{
		long num = 0L;
		if (value._sign == 0)
		{
			return 0L;
		}
		if (value.Length > 2)
		{
			throw new OverflowException(Res.Overflow_Int64);
		}
		if (value.Length == 1)
		{
			return value._sign * value._data[0];
		}
		ulong num2 = ((ulong)value._data[1] << 32) | value._data[0];
		if (num2 > 9223372036854775808uL)
		{
			throw new OverflowException(Res.Overflow_Int64);
		}
		if (num2 == 9223372036854775808uL && value._sign == 1)
		{
			throw new OverflowException(Res.Overflow_Int64);
		}
		return (long)num2 * (long)value._sign;
	}

	[CLSCompliant(false)]
	public static explicit operator ulong(BigInteger value)
	{
		ulong num = 0uL;
		if (value._sign == 0)
		{
			return 0uL;
		}
		if (value._sign < 0)
		{
			throw new OverflowException(Res.Overflow_UInt64);
		}
		if (value.Length > 2)
		{
			throw new OverflowException(Res.Overflow_UInt64);
		}
		num = value._data[0];
		if (value.Length > 1)
		{
			num |= (ulong)value._data[1] << 32;
		}
		return num;
	}

	public static explicit operator float(BigInteger value)
	{
		NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
		if (!float.TryParse(value.ToString(10u, useCapitalHexDigits: false, numberFormat), NumberStyles.Number, numberFormat, out var result))
		{
			throw new OverflowException(Res.Overflow_Single);
		}
		return result;
	}

	public static explicit operator double(BigInteger value)
	{
		NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
		if (!double.TryParse(value.ToString(10u, useCapitalHexDigits: false, numberFormat), NumberStyles.Number, numberFormat, out var result))
		{
			throw new OverflowException(Res.Overflow_Double);
		}
		return result;
	}

	public static explicit operator decimal(BigInteger value)
	{
		if (value._sign == 0)
		{
			return 0m;
		}
		int length = value.Length;
		if (length > 3)
		{
			throw new OverflowException(Res.Overflow_Decimal);
		}
		int lo = 0;
		int mid = 0;
		int hi = 0;
		if (length > 2)
		{
			hi = (int)value._data[2];
		}
		if (length > 1)
		{
			mid = (int)value._data[1];
		}
		if (length > 0)
		{
			lo = (int)value._data[0];
		}
		return new decimal(lo, mid, hi, value._sign < 0, 0);
	}

	public static explicit operator BigInteger(float value)
	{
		return new BigInteger(value);
	}

	public static explicit operator BigInteger(double value)
	{
		return new BigInteger(value);
	}

	public static explicit operator BigInteger(decimal value)
	{
		return new BigInteger(value);
	}

	public static implicit operator BigInteger(byte value)
	{
		return new BigInteger(value);
	}

	[CLSCompliant(false)]
	public static implicit operator BigInteger(sbyte value)
	{
		return new BigInteger(value);
	}

	public static implicit operator BigInteger(short value)
	{
		return new BigInteger(value);
	}

	[CLSCompliant(false)]
	public static implicit operator BigInteger(ushort value)
	{
		return new BigInteger(value);
	}

	[Pure]
	public static implicit operator BigInteger(int value)
	{
		return new BigInteger(value);
	}

	[CLSCompliant(false)]
	public static implicit operator BigInteger(uint value)
	{
		return new BigInteger(value);
	}

	public static implicit operator BigInteger(long value)
	{
		return new BigInteger(value);
	}

	[CLSCompliant(false)]
	public static implicit operator BigInteger(ulong value)
	{
		return new BigInteger(value);
	}

	private static bool IsNegative(byte[] doubleBits)
	{
		Contract.Requires(doubleBits.Length == 8);
		return (doubleBits[7] & 0x80) != 0;
	}

	private static ushort Exponent(byte[] doubleBits)
	{
		Contract.Requires(doubleBits.Length == 8);
		return (ushort)(((ushort)(doubleBits[7] & 0x7F) << 4) | ((ushort)(doubleBits[6] & 0xF0) >> 4));
	}

	private static ulong Mantissa(byte[] doubleBits)
	{
		Contract.Requires(doubleBits.Length == 8);
		uint num = (uint)(doubleBits[0] | (doubleBits[1] << 8) | (doubleBits[2] << 16) | (doubleBits[3] << 24));
		uint num2 = (uint)(doubleBits[4] | (doubleBits[5] << 8) | ((doubleBits[6] & 0xF) << 16));
		return num | ((ulong)num2 << 32);
	}

	private static int GetLength(uint[] _data)
	{
		if (_data == null)
		{
			return 0;
		}
		int num = _data.Length - 1;
		while (num >= 0 && _data[num] == 0)
		{
			num--;
		}
		return num + 1;
	}

	private static uint[] copy(uint[] v)
	{
		uint[] array = new uint[v.Length];
		Array.Copy(v, array, v.Length);
		return array;
	}

	private static uint[] resize(uint[] v, int len)
	{
		if (v.Length == len)
		{
			return v;
		}
		uint[] array = new uint[len];
		int length = Math.Min(v.Length, len);
		Array.Copy(v, array, length);
		return array;
	}

	private static uint[] add0(uint[] x, int xl, uint[] y, int yl)
	{
		if (xl >= yl)
		{
			return InternalAdd(x, xl, y, yl);
		}
		return InternalAdd(y, yl, x, xl);
	}

	private static uint[] InternalAdd(uint[] x, int xl, uint[] y, int yl)
	{
		uint[] array = new uint[xl];
		ulong num = 0uL;
		int i;
		for (i = 0; i < yl; i++)
		{
			num = num + x[i] + y[i];
			array[i] = (uint)num;
			num >>= 32;
		}
		for (; i < xl; i++)
		{
			if (num == 0L)
			{
				break;
			}
			num += x[i];
			array[i] = (uint)num;
			num >>= 32;
		}
		if (num != 0L)
		{
			array = resize(array, xl + 1);
			array[i] = (uint)num;
		}
		else
		{
			for (; i < xl; i++)
			{
				array[i] = x[i];
			}
		}
		return array;
	}

	private static uint[] sub(uint[] x, int xl, uint[] y, int yl)
	{
		uint[] array = new uint[xl];
		bool flag = false;
		int i;
		for (i = 0; i < yl; i++)
		{
			uint num = x[i];
			uint num2 = y[i];
			if (flag)
			{
				if (num == 0)
				{
					num = uint.MaxValue;
					flag = true;
				}
				else
				{
					num--;
					flag = false;
				}
			}
			if (num2 > num)
			{
				flag = true;
			}
			array[i] = num - num2;
		}
		if (flag)
		{
			for (; i < xl; i++)
			{
				uint num3 = x[i];
				array[i] = num3 - 1;
				if (num3 != 0)
				{
					i++;
					break;
				}
			}
		}
		for (; i < xl; i++)
		{
			array[i] = x[i];
		}
		return array;
	}

	[Pure]
	public static int Compare(BigInteger x, BigInteger y)
	{
		if (x._sign == y._sign)
		{
			int length = x.Length;
			int length2 = y.Length;
			if (length == length2)
			{
				int num = length - 1;
				while (true)
				{
					if (num >= 0)
					{
						if (x._data[num] != y._data[num])
						{
							break;
						}
						num--;
						continue;
					}
					return 0;
				}
				if (x._data[num] <= y._data[num])
				{
					return -x._sign;
				}
				return x._sign;
			}
			if (length <= length2)
			{
				return -x._sign;
			}
			return x._sign;
		}
		if (x._sign <= y._sign)
		{
			return -1;
		}
		return 1;
	}

	[Pure]
	public static bool operator ==(BigInteger x, BigInteger y)
	{
		return Compare(x, y) == 0;
	}

	[Pure]
	public static bool operator !=(BigInteger x, BigInteger y)
	{
		return Compare(x, y) != 0;
	}

	[Pure]
	public static bool operator <(BigInteger x, BigInteger y)
	{
		return Compare(x, y) < 0;
	}

	[Pure]
	public static bool operator <=(BigInteger x, BigInteger y)
	{
		return Compare(x, y) <= 0;
	}

	[Pure]
	public static bool operator >(BigInteger x, BigInteger y)
	{
		return Compare(x, y) > 0;
	}

	[Pure]
	public static bool operator >=(BigInteger x, BigInteger y)
	{
		return Compare(x, y) >= 0;
	}

	public static BigInteger Add(BigInteger x, BigInteger y)
	{
		return x + y;
	}

	public static BigInteger operator +(BigInteger x, BigInteger y)
	{
		if (x._sign == y._sign)
		{
			return new BigInteger(x._sign, add0(x._data, x.Length, y._data, y.Length));
		}
		return x - -y;
	}

	public static BigInteger Subtract(BigInteger x, BigInteger y)
	{
		return x - y;
	}

	public static BigInteger operator -(BigInteger x, BigInteger y)
	{
		int num = Compare(x, y);
		if (num == 0)
		{
			return Zero;
		}
		if (x._sign == y._sign)
		{
			uint[] data;
			switch (num * x._sign)
			{
			case -1:
				data = sub(y._data, y.Length, x._data, x.Length);
				break;
			default:
				return Zero;
			case 1:
				data = sub(x._data, x.Length, y._data, y.Length);
				break;
			}
			return new BigInteger(num, data);
		}
		uint[] data2 = add0(x._data, x.Length, y._data, y.Length);
		return new BigInteger(num, data2);
	}

	public static BigInteger Multiply(BigInteger x, BigInteger y)
	{
		int length = x.Length;
		int length2 = y.Length;
		if (length + length2 >= 64 && length >= 8 && length2 >= 8)
		{
			return MultiplyKaratsuba(x, y);
		}
		return MultiplySchoolBook(x, y);
	}

	[Pure]
	public static BigInteger operator *(BigInteger x, BigInteger y)
	{
		return Multiply(x, y);
	}

	private static BigInteger MultiplySchoolBook(BigInteger x, BigInteger y)
	{
		int length = x.Length;
		int length2 = y.Length;
		int num = length + length2;
		uint[] data = x._data;
		uint[] data2 = y._data;
		uint[] array = new uint[num];
		for (int i = 0; i < length; i++)
		{
			uint num2 = data[i];
			int num3 = i;
			ulong num4 = 0uL;
			for (int j = 0; j < length2; j++)
			{
				num4 = (ulong)((long)num4 + (long)num2 * (long)data2[j] + array[num3]);
				array[num3++] = (uint)num4;
				num4 >>= 32;
			}
			while (num4 != 0L)
			{
				num4 += array[num3];
				array[num3++] = (uint)num4;
				num4 >>= 32;
			}
		}
		return new BigInteger(x._sign * y._sign, array);
	}

	private static BigInteger MultiplyKaratsuba(BigInteger x, BigInteger y)
	{
		int num = Math.Max(x.Length, y.Length) / 2;
		if (num > 16 && x.Length >= 16 && y.Length >= 16)
		{
			int shift = 32 * num;
			BigInteger bigInteger = RightShift(x, shift);
			BigInteger bigInteger2 = x.RestrictTo(num);
			BigInteger bigInteger3 = RightShift(y, shift);
			BigInteger bigInteger4 = y.RestrictTo(num);
			BigInteger bigInteger5 = Multiply(bigInteger, bigInteger3);
			BigInteger bigInteger6 = Multiply(bigInteger2, bigInteger4);
			BigInteger bigInteger7 = Multiply(bigInteger + bigInteger2, bigInteger3 + bigInteger4);
			BigInteger bigInteger8 = bigInteger7 - (bigInteger5 + bigInteger6);
			return bigInteger6 + LeftShift(bigInteger8 + LeftShift(bigInteger5, shift), shift);
		}
		return MultiplySchoolBook(x, y);
	}

	private BigInteger RestrictTo(int numDigits)
	{
		Contract.Requires(numDigits > 0);
		int num = Math.Min(numDigits, Length);
		if (num == Length)
		{
			return this;
		}
		BigInteger result = new BigInteger(_sign, _data);
		result._length = num;
		return result;
	}

	public static BigInteger Divide(BigInteger dividend, BigInteger divisor)
	{
		return dividend / divisor;
	}

	public static BigInteger operator /(BigInteger dividend, BigInteger divisor)
	{
		BigInteger remainder;
		return DivRem(dividend, divisor, out remainder);
	}

	private static int GetNormalizeShift(uint value)
	{
		int num = 0;
		if ((value & 0xFFFF0000u) == 0)
		{
			value <<= 16;
			num += 16;
		}
		if ((value & 0xFF000000u) == 0)
		{
			value <<= 8;
			num += 8;
		}
		if ((value & 0xF0000000u) == 0)
		{
			value <<= 4;
			num += 4;
		}
		if ((value & 0xC0000000u) == 0)
		{
			value <<= 2;
			num += 2;
		}
		if ((value & 0x80000000u) == 0)
		{
			value <<= 1;
			num++;
		}
		return num;
	}

	[Conditional("DEBUG")]
	private static void TestNormalize(uint[] u, uint[] un, int shift)
	{
		new BigInteger(1, u);
		BigInteger x = new BigInteger(1, un);
		RightShift(x, shift);
	}

	[Conditional("DEBUG")]
	private static void TestDivisionStep(uint[] un, uint[] vn, uint[] q, uint[] u, uint[] v)
	{
		int length = GetLength(v);
		int normalizeShift = GetNormalizeShift(v[length - 1]);
		BigInteger bigInteger = new BigInteger(1, un);
		BigInteger bigInteger2 = new BigInteger(1, vn);
		BigInteger bigInteger3 = new BigInteger(1, q);
		BigInteger x = new BigInteger(1, u);
		_ = bigInteger2 * bigInteger3 + bigInteger;
		LeftShift(x, normalizeShift);
	}

	[Conditional("DEBUG")]
	private static void TestResult(uint[] u, uint[] v, uint[] q, uint[] r)
	{
		new BigInteger(1, u);
		BigInteger bigInteger = new BigInteger(1, v);
		BigInteger bigInteger2 = new BigInteger(1, q);
		BigInteger bigInteger3 = new BigInteger(1, r);
		BigInteger bigInteger4 = bigInteger * bigInteger2;
		_ = bigInteger4 + bigInteger3;
	}

	private static void Normalize(uint[] u, int l, uint[] un, int shift)
	{
		uint num = 0u;
		int i;
		if (shift > 0)
		{
			int num2 = 32 - shift;
			for (i = 0; i < l; i++)
			{
				uint num3 = u[i];
				un[i] = (num3 << shift) | num;
				num = num3 >> num2;
			}
		}
		else
		{
			for (i = 0; i < l; i++)
			{
				un[i] = u[i];
			}
		}
		while (i < un.Length)
		{
			un[i++] = 0u;
		}
		if (num != 0)
		{
			un[l] = num;
		}
	}

	private static void Unnormalize(uint[] un, out uint[] r, int shift)
	{
		int length = GetLength(un);
		r = new uint[length];
		if (shift > 0)
		{
			int num = 32 - shift;
			uint num2 = 0u;
			for (int num3 = length - 1; num3 >= 0; num3--)
			{
				uint num4 = un[num3];
				r[num3] = (num4 >> shift) | num2;
				num2 = num4 << num;
			}
		}
		else
		{
			for (int i = 0; i < length; i++)
			{
				r[i] = un[i];
			}
		}
	}

	private static void DivModUnsigned(uint[] u, uint[] v, out uint[] q, out uint[] r)
	{
		int length = GetLength(u);
		int length2 = GetLength(v);
		if (length2 <= 1)
		{
			if (length2 == 0)
			{
				throw new DivideByZeroException();
			}
			ulong num = 0uL;
			uint num2 = v[0];
			q = new uint[length];
			r = new uint[1];
			for (int num3 = length - 1; num3 >= 0; num3--)
			{
				num *= 4294967296L;
				num += u[num3];
				ulong num4 = num / num2;
				num -= num4 * num2;
				q[num3] = (uint)num4;
			}
			r[0] = (uint)num;
		}
		else if (length >= length2)
		{
			int normalizeShift = GetNormalizeShift(v[length2 - 1]);
			uint[] array = new uint[length + 1];
			uint[] array2 = new uint[length2];
			Normalize(u, length, array, normalizeShift);
			Normalize(v, length2, array2, normalizeShift);
			q = new uint[length - length2 + 1];
			r = null;
			for (int num5 = length - length2; num5 >= 0; num5--)
			{
				ulong num6 = (ulong)(4294967296L * (long)array[num5 + length2] + array[num5 + length2 - 1]);
				ulong num7 = num6 / array2[length2 - 1];
				num6 -= num7 * array2[length2 - 1];
				while (num7 >= 4294967296L || num7 * array2[length2 - 2] > num6 * 4294967296L + array[num5 + length2 - 2])
				{
					num7--;
					num6 += array2[length2 - 1];
					if (num6 >= 4294967296L)
					{
						break;
					}
				}
				long num8 = 0L;
				long num9 = 0L;
				for (int i = 0; i < length2; i++)
				{
					ulong num10 = array2[i] * num7;
					num9 = (long)array[i + num5] - (long)(uint)num10 - num8;
					array[i + num5] = (uint)num9;
					num10 >>= 32;
					num9 >>= 32;
					num8 = (long)num10 - num9;
				}
				num9 = array[num5 + length2] - num8;
				array[num5 + length2] = (uint)num9;
				q[num5] = (uint)num7;
				if (num9 < 0L)
				{
					q[num5]--;
					ulong num11 = 0uL;
					for (int i = 0; i < length2; i++)
					{
						num11 = (ulong)((long)array2[i] + (long)array[num5 + i]) + num11;
						array[num5 + i] = (uint)num11;
						num11 >>= 32;
					}
					num11 += array[num5 + length2];
					array[num5 + length2] = (uint)num11;
				}
			}
			Unnormalize(array, out r, normalizeShift);
		}
		else
		{
			q = zeroArray;
			r = u;
		}
	}

	public static BigInteger DivRem(BigInteger dividend, BigInteger divisor, out BigInteger remainder)
	{
		DivModUnsigned((dividend._data == null) ? zeroArray : dividend._data, (divisor._data == null) ? zeroArray : divisor._data, out var q, out var r);
		remainder = new BigInteger(dividend._sign, r);
		return new BigInteger(dividend._sign * divisor._sign, q);
	}

	private static BigInteger LeftShift(BigInteger x, int shift)
	{
		if (shift == 0)
		{
			return x;
		}
		if (shift < 0)
		{
			return RightShift(x, -shift);
		}
		int num = shift / 32;
		int num2 = shift - num * 32;
		int length = x.Length;
		uint[] data = x._data;
		int num3 = length + num + 1;
		uint[] array = new uint[num3];
		if (num2 == 0)
		{
			for (int i = 0; i < length; i++)
			{
				array[i + num] = data[i];
			}
		}
		else
		{
			int num4 = 32 - num2;
			uint num5 = 0u;
			int j;
			for (j = 0; j < length; j++)
			{
				uint num6 = data[j];
				array[j + num] = (num6 << num2) | num5;
				num5 = num6 >> num4;
			}
			array[j + num] = num5;
		}
		return new BigInteger(x._sign, array);
	}

	private static BigInteger RightShift(BigInteger x, int shift)
	{
		if (shift == 0)
		{
			return x;
		}
		if (shift < 0)
		{
			return LeftShift(x, -shift);
		}
		int num = shift / 32;
		int num2 = shift - num * 32;
		int length = x.Length;
		uint[] data = x._data;
		int num3 = length - num;
		if (num3 < 0)
		{
			num3 = 0;
		}
		uint[] array = new uint[num3];
		if (num2 == 0)
		{
			for (int num4 = length - 1; num4 >= num; num4--)
			{
				array[num4 - num] = data[num4];
			}
		}
		else
		{
			int num5 = 32 - num2;
			uint num6 = 0u;
			for (int num7 = length - 1; num7 >= num; num7--)
			{
				uint num8 = data[num7];
				array[num7 - num] = (num8 >> num2) | num6;
				num6 = num8 << num5;
			}
		}
		return new BigInteger(x._sign, array);
	}

	public static BigInteger Parse(string s)
	{
		return Parse(s, CultureInfo.CurrentCulture);
	}

	public static BigInteger Parse(string s, IFormatProvider provider)
	{
		return Parse(s, NumberStyles.Integer, provider);
	}

	public static BigInteger Parse(string s, NumberStyles style)
	{
		return Parse(s, style, CultureInfo.CurrentCulture);
	}

	public static BigInteger Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		if (!TryParse(s, style, provider, out var value, out var error))
		{
			throw new FormatException(error);
		}
		return value;
	}

	public static bool TryParse(string s, out BigInteger b)
	{
		string error;
		return TryParse(s, NumberStyles.Integer, CultureInfo.CurrentCulture, out b, out error);
	}

	public static bool TryParse(string s, NumberStyles style, IFormatProvider formatProvider, out BigInteger value)
	{
		string error;
		return TryParse(s, style, formatProvider, out value, out error);
	}

	private static bool TryParse(string s, NumberStyles style, IFormatProvider formatProvider, out BigInteger value, out string error)
	{
		Contract.Requires((s != null) ? null : new ArgumentNullException("s"));
		if (formatProvider == null)
		{
			formatProvider = CultureInfo.CurrentCulture;
		}
		if (((uint)style & 0xFFFFFDF8u) != 0)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentUICulture, Res.UnsupportedNumberStyle, new object[1] { style }));
		}
		error = null;
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)formatProvider.GetFormat(typeof(NumberFormatInfo));
		uint num = (((style & NumberStyles.AllowHexSpecifier) != 0) ? 16u : 10u);
		int i = 0;
		bool flag = false;
		if ((style & NumberStyles.AllowLeadingWhite) != 0)
		{
			for (; i < s.Length && IsWhiteSpace(s[i]); i++)
			{
			}
		}
		if ((style & NumberStyles.AllowLeadingSign) != 0)
		{
			int length = numberFormatInfo.NegativeSign.Length;
			if (length + i < s.Length && string.Compare(s, i, numberFormatInfo.NegativeSign, 0, length, ignoreCase: false, CultureInfo.CurrentCulture) == 0)
			{
				flag = true;
				i += numberFormatInfo.NegativeSign.Length;
			}
		}
		value = Zero;
		BigInteger one = One;
		if (i == s.Length)
		{
			error = Res.ParsedStringWasInvalid;
			return false;
		}
		int num2 = s.Length - 1;
		while (true)
		{
			if (num2 >= i)
			{
				if ((style & NumberStyles.AllowTrailingWhite) != 0 && IsWhiteSpace(s[num2]))
				{
					int num3 = num2;
					while (num3 >= i && IsWhiteSpace(s[num3]))
					{
						num3--;
					}
					if (num3 < i)
					{
						error = Res.ParsedStringWasInvalid;
						return false;
					}
					num2 = num3;
				}
				uint num4 = ParseSingleDigit(s[num2], num, out error);
				if (error != null)
				{
					break;
				}
				if (num4 != 0)
				{
					value += num4 * one;
				}
				one *= (BigInteger)num;
				num2--;
				continue;
			}
			if (value._sign == 1 && flag)
			{
				value = -value;
			}
			return true;
		}
		return false;
	}

	private static uint ParseSingleDigit(char c, ulong radix, out string error)
	{
		error = null;
		if (c >= '0' && c <= '9')
		{
			return (uint)(c - 48);
		}
		if (radix == 16L)
		{
			c = (char)(c & 0xFFFFFFDFu);
			if (c >= 'A' && c <= 'F')
			{
				return (uint)(c - 65 + 10);
			}
		}
		error = Res.InvalidCharactersInString;
		return uint.MaxValue;
	}

	private static bool IsWhiteSpace(char ch)
	{
		if (ch != ' ')
		{
			if (ch >= '\t')
			{
				return ch <= '\r';
			}
			return false;
		}
		return true;
	}

	public string ToString(string format)
	{
		return ToString(format, CultureInfo.CurrentCulture);
	}

	public string ToString(IFormatProvider formatProvider)
	{
		if (formatProvider == null)
		{
			formatProvider = CultureInfo.CurrentCulture;
		}
		return ToString(10u, useCapitalHexDigits: false, (NumberFormatInfo)formatProvider.GetFormat(typeof(NumberFormatInfo)));
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		if (formatProvider == null)
		{
			formatProvider = CultureInfo.CurrentCulture;
		}
		uint num = 10u;
		bool flag = false;
		if (!string.IsNullOrEmpty(format))
		{
			char c = format[0];
			switch (c)
			{
			default:
				throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Currently not supported format: {0}", new object[1] { format }));
			case 'X':
			case 'x':
				num = 16u;
				flag = c == 'X';
				break;
			case 'D':
			case 'G':
			case 'd':
			case 'g':
				break;
			}
		}
		return ToString(num, flag, (NumberFormatInfo)formatProvider.GetFormat(typeof(NumberFormatInfo)));
	}

	public override string ToString()
	{
		return ToString(10u, useCapitalHexDigits: false, CultureInfo.CurrentCulture.NumberFormat);
	}

	private string ToString(uint radix, bool useCapitalHexDigits, NumberFormatInfo info)
	{
		Contract.Requires(radix >= 2 && radix <= 36);
		if (_sign == 0)
		{
			return "0";
		}
		_ = Length;
		List<uint> list = new List<uint>();
		uint[] n = copy(_data);
		int nl = Length;
		uint d = groupRadixValues[radix];
		while (nl > 0)
		{
			uint item = div(n, ref nl, d);
			list.Add(item);
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (_sign == -1)
		{
			stringBuilder.Append(info.NegativeSign);
		}
		int num = list.Count - 1;
		char[] tmp = new char[maxCharsPerDigit[radix]];
		AppendRadix(list[num--], radix, useCapitalHexDigits, tmp, stringBuilder, leadingZeros: false);
		while (num >= 0)
		{
			AppendRadix(list[num--], radix, useCapitalHexDigits, tmp, stringBuilder, leadingZeros: true);
		}
		return stringBuilder.ToString();
	}

	private static void AppendRadix(uint rem, uint radix, bool useCapitalHexDigits, char[] tmp, StringBuilder buf, bool leadingZeros)
	{
		string text = (useCapitalHexDigits ? "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ" : "0123456789abcdefghijklmnopqrstuvwxyz");
		int num = tmp.Length;
		int num2 = num;
		while (num2 > 0 && (leadingZeros || rem != 0))
		{
			uint index = rem % radix;
			rem /= radix;
			tmp[--num2] = text[(int)index];
		}
		if (leadingZeros)
		{
			buf.Append(tmp);
		}
		else
		{
			buf.Append(tmp, num2, num - num2);
		}
	}

	private static uint div(uint[] n, ref int nl, uint d)
	{
		ulong num = 0uL;
		int num2 = nl;
		bool flag = false;
		while (--num2 >= 0)
		{
			num <<= 32;
			num |= n[num2];
			if ((n[num2] = (uint)(num / d)) == 0)
			{
				if (!flag)
				{
					nl--;
				}
			}
			else
			{
				flag = true;
			}
			num %= d;
		}
		return (uint)num;
	}

	public override int GetHashCode()
	{
		if (_sign == 0)
		{
			return 0;
		}
		return (int)_data[0];
	}

	public bool Equals(BigInteger other)
	{
		if (_sign != other._sign)
		{
			return false;
		}
		int length = Length;
		int length2 = other.Length;
		if (length != length2)
		{
			return false;
		}
		uint num = 0u;
		while (true)
		{
			if (num < length)
			{
				if (_data[num] != other._data[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is BigInteger))
		{
			return false;
		}
		return Equals((BigInteger)obj);
	}

	public int CompareTo(BigInteger other)
	{
		return Compare(this, other);
	}

	public int CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		if (!(obj is BigInteger))
		{
			throw new ArgumentException(Res.MustBeBigInt);
		}
		return Compare(this, (BigInteger)obj);
	}
}
