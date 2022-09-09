using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace System;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class TimeZoneInfo : ISerializable, IEquatable<TimeZoneInfo>, IDeserializationCallback
{
	private enum TimeZoneInfoResult
	{
		Success,
		TimeZoneNotFoundException,
		InvalidTimeZoneException,
		SecurityException
	}

	[Serializable]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class AdjustmentRule : ISerializable, IEquatable<AdjustmentRule>, IDeserializationCallback
	{
		private DateTime m_dateStart;

		private DateTime m_dateEnd;

		private TimeSpan m_daylightDelta;

		private TransitionTime m_daylightTransitionStart;

		private TransitionTime m_daylightTransitionEnd;

		public DateTime DateStart => m_dateStart;

		public DateTime DateEnd => m_dateEnd;

		public TimeSpan DaylightDelta => m_daylightDelta;

		public TransitionTime DaylightTransitionStart => m_daylightTransitionStart;

		public TransitionTime DaylightTransitionEnd => m_daylightTransitionEnd;

		public bool Equals(AdjustmentRule other)
		{
			return other != null && m_dateStart == other.m_dateStart && m_dateEnd == other.m_dateEnd && m_daylightDelta == other.m_daylightDelta && m_daylightTransitionEnd.Equals(other.m_daylightTransitionEnd) && m_daylightTransitionStart.Equals(other.m_daylightTransitionStart);
		}

		public override int GetHashCode()
		{
			return m_dateStart.GetHashCode();
		}

		private AdjustmentRule()
		{
		}

		public static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd)
		{
			ValidateAdjustmentRule(dateStart, dateEnd, daylightDelta, daylightTransitionStart, daylightTransitionEnd);
			AdjustmentRule adjustmentRule = new AdjustmentRule();
			adjustmentRule.m_dateStart = dateStart;
			adjustmentRule.m_dateEnd = dateEnd;
			adjustmentRule.m_daylightDelta = daylightDelta;
			adjustmentRule.m_daylightTransitionStart = daylightTransitionStart;
			adjustmentRule.m_daylightTransitionEnd = daylightTransitionEnd;
			return adjustmentRule;
		}

		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd)
		{
			if (dateStart.Kind != 0)
			{
				throw new ArgumentException(SR.GetString("Argument_DateTimeKindMustBeUnspecified"), "dateStart");
			}
			if (dateEnd.Kind != 0)
			{
				throw new ArgumentException(SR.GetString("Argument_DateTimeKindMustBeUnspecified"), "dateEnd");
			}
			if (daylightTransitionStart.Equals(daylightTransitionEnd))
			{
				throw new ArgumentException(SR.GetString("Argument_TransitionTimesAreIdentical"), "daylightTransitionEnd");
			}
			if (dateStart > dateEnd)
			{
				throw new ArgumentException(SR.GetString("Argument_OutOfOrderDateTimes"), "dateStart");
			}
			if (UtcOffsetOutOfRange(daylightDelta))
			{
				throw new ArgumentOutOfRangeException("daylightDelta", daylightDelta, SR.GetString("ArgumentOutOfRange_UtcOffset"));
			}
			if (daylightDelta.Ticks % 600000000L != 0L)
			{
				throw new ArgumentException(SR.GetString("Argument_TimeSpanHasSeconds"), "daylightDelta");
			}
			if (dateStart.TimeOfDay != TimeSpan.Zero)
			{
				throw new ArgumentException(SR.GetString("Argument_DateTimeHasTimeOfDay"), "dateStart");
			}
			if (dateEnd.TimeOfDay != TimeSpan.Zero)
			{
				throw new ArgumentException(SR.GetString("Argument_DateTimeHasTimeOfDay"), "dateEnd");
			}
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
			try
			{
				ValidateAdjustmentRule(m_dateStart, m_dateEnd, m_daylightDelta, m_daylightTransitionStart, m_daylightTransitionEnd);
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException);
			}
		}

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("DateStart", m_dateStart);
			info.AddValue("DateEnd", m_dateEnd);
			info.AddValue("DaylightDelta", m_daylightDelta);
			info.AddValue("DaylightTransitionStart", m_daylightTransitionStart);
			info.AddValue("DaylightTransitionEnd", m_daylightTransitionEnd);
		}

		private AdjustmentRule(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			m_dateStart = (DateTime)info.GetValue("DateStart", typeof(DateTime));
			m_dateEnd = (DateTime)info.GetValue("DateEnd", typeof(DateTime));
			m_daylightDelta = (TimeSpan)info.GetValue("DaylightDelta", typeof(TimeSpan));
			m_daylightTransitionStart = (TransitionTime)info.GetValue("DaylightTransitionStart", typeof(TransitionTime));
			m_daylightTransitionEnd = (TransitionTime)info.GetValue("DaylightTransitionEnd", typeof(TransitionTime));
		}
	}

	[Serializable]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public struct TransitionTime : ISerializable, IEquatable<TransitionTime>, IDeserializationCallback
	{
		private DateTime m_timeOfDay;

		private byte m_month;

		private byte m_week;

		private byte m_day;

		private DayOfWeek m_dayOfWeek;

		private bool m_isFixedDateRule;

		public DateTime TimeOfDay => m_timeOfDay;

		public int Month => m_month;

		public int Week => m_week;

		public int Day => m_day;

		public DayOfWeek DayOfWeek => m_dayOfWeek;

		public bool IsFixedDateRule => m_isFixedDateRule;

		public override bool Equals(object obj)
		{
			if (obj is TransitionTime)
			{
				return Equals((TransitionTime)obj);
			}
			return false;
		}

		public static bool operator ==(TransitionTime left, TransitionTime right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(TransitionTime left, TransitionTime right)
		{
			return !left.Equals(right);
		}

		public bool Equals(TransitionTime other)
		{
			bool result;
			if (result = m_isFixedDateRule == other.m_isFixedDateRule && m_timeOfDay == other.m_timeOfDay && m_month == other.m_month)
			{
				result = ((!other.m_isFixedDateRule) ? (m_week == other.m_week && m_dayOfWeek == other.m_dayOfWeek) : (m_day == other.m_day));
			}
			return result;
		}

		public override int GetHashCode()
		{
			return m_month ^ (m_week << 8);
		}

		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
		{
			return CreateTransitionTime(timeOfDay, month, 1, day, DayOfWeek.Sunday, isFixedDateRule: true);
		}

		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
		{
			return CreateTransitionTime(timeOfDay, month, week, 1, dayOfWeek, isFixedDateRule: false);
		}

		private static TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
		{
			ValidateTransitionTime(timeOfDay, month, week, day, dayOfWeek);
			TransitionTime result = default(TransitionTime);
			result.m_isFixedDateRule = isFixedDateRule;
			result.m_timeOfDay = timeOfDay;
			result.m_dayOfWeek = dayOfWeek;
			result.m_day = (byte)day;
			result.m_week = (byte)week;
			result.m_month = (byte)month;
			return result;
		}

		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
		{
			if (timeOfDay.Kind != 0)
			{
				throw new ArgumentException(SR.GetString("Argument_DateTimeKindMustBeUnspecified"), "timeOfDay");
			}
			if (month >= 1 && month <= 12)
			{
				if (day >= 1 && day <= 31)
				{
					if (week >= 1 && week <= 5)
					{
						if (dayOfWeek >= DayOfWeek.Sunday && dayOfWeek <= DayOfWeek.Saturday)
						{
							if (timeOfDay.Year != 1 || timeOfDay.Month != 1 || timeOfDay.Day != 1 || timeOfDay.Ticks % 10000L != 0L)
							{
								throw new ArgumentException(SR.GetString("Argument_DateTimeHasTicks"), "timeOfDay");
							}
							return;
						}
						throw new ArgumentOutOfRangeException("dayOfWeek", SR.GetString("ArgumentOutOfRange_DayOfWeek"));
					}
					throw new ArgumentOutOfRangeException("week", SR.GetString("ArgumentOutOfRange_Week"));
				}
				throw new ArgumentOutOfRangeException("day", SR.GetString("ArgumentOutOfRange_Day"));
			}
			throw new ArgumentOutOfRangeException("month", SR.GetString("ArgumentOutOfRange_Month"));
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
			try
			{
				ValidateTransitionTime(m_timeOfDay, m_month, m_week, m_day, m_dayOfWeek);
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException);
			}
		}

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("TimeOfDay", m_timeOfDay);
			info.AddValue("Month", m_month);
			info.AddValue("Week", m_week);
			info.AddValue("Day", m_day);
			info.AddValue("DayOfWeek", m_dayOfWeek);
			info.AddValue("IsFixedDateRule", m_isFixedDateRule);
		}

		private TransitionTime(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			m_timeOfDay = (DateTime)info.GetValue("TimeOfDay", typeof(DateTime));
			m_month = (byte)info.GetValue("Month", typeof(byte));
			m_week = (byte)info.GetValue("Week", typeof(byte));
			m_day = (byte)info.GetValue("Day", typeof(byte));
			m_dayOfWeek = (DayOfWeek)info.GetValue("DayOfWeek", typeof(DayOfWeek));
			m_isFixedDateRule = (bool)info.GetValue("IsFixedDateRule", typeof(bool));
		}
	}

	private sealed class StringSerializer
	{
		private enum State
		{
			Escaped,
			NotEscaped,
			StartOfToken,
			EndOfLine
		}

		private const int initialCapacityForString = 64;

		private const char esc = '\\';

		private const char sep = ';';

		private const char lhs = '[';

		private const char rhs = ']';

		private const string escString = "\\";

		private const string sepString = ";";

		private const string lhsString = "[";

		private const string rhsString = "]";

		private const string escapedEsc = "\\\\";

		private const string escapedSep = "\\;";

		private const string escapedLhs = "\\[";

		private const string escapedRhs = "\\]";

		private const string dateTimeFormat = "MM:dd:yyyy";

		private const string timeOfDayFormat = "HH:mm:ss.FFF";

		private string m_serializedText;

		private int m_currentTokenStartIndex;

		private State m_state;

		public static string GetSerializedString(TimeZoneInfo zone)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(SerializeSubstitute(zone.Id));
			stringBuilder.Append(';');
			stringBuilder.Append(SerializeSubstitute(zone.BaseUtcOffset.TotalMinutes.ToString(CultureInfo.InvariantCulture)));
			stringBuilder.Append(';');
			stringBuilder.Append(SerializeSubstitute(zone.DisplayName));
			stringBuilder.Append(';');
			stringBuilder.Append(SerializeSubstitute(zone.StandardName));
			stringBuilder.Append(';');
			stringBuilder.Append(SerializeSubstitute(zone.DaylightName));
			stringBuilder.Append(';');
			AdjustmentRule[] adjustmentRules = zone.GetAdjustmentRules();
			if (adjustmentRules != null && adjustmentRules.Length > 0)
			{
				foreach (AdjustmentRule adjustmentRule in adjustmentRules)
				{
					stringBuilder.Append('[');
					stringBuilder.Append(SerializeSubstitute(adjustmentRule.DateStart.ToString("MM:dd:yyyy", DateTimeFormatInfo.InvariantInfo)));
					stringBuilder.Append(';');
					stringBuilder.Append(SerializeSubstitute(adjustmentRule.DateEnd.ToString("MM:dd:yyyy", DateTimeFormatInfo.InvariantInfo)));
					stringBuilder.Append(';');
					stringBuilder.Append(SerializeSubstitute(adjustmentRule.DaylightDelta.TotalMinutes.ToString(CultureInfo.InvariantCulture)));
					stringBuilder.Append(';');
					SerializeTransitionTime(adjustmentRule.DaylightTransitionStart, stringBuilder);
					stringBuilder.Append(';');
					SerializeTransitionTime(adjustmentRule.DaylightTransitionEnd, stringBuilder);
					stringBuilder.Append(';');
					stringBuilder.Append(']');
				}
			}
			stringBuilder.Append(';');
			return stringBuilder.ToString();
		}

		public static TimeZoneInfo GetDeserializedTimeZoneInfo(string source)
		{
			StringSerializer stringSerializer = new StringSerializer(source);
			string nextStringValue = stringSerializer.GetNextStringValue(canEndWithoutSeparator: false);
			TimeSpan nextTimeSpanValue = stringSerializer.GetNextTimeSpanValue(canEndWithoutSeparator: false);
			string nextStringValue2 = stringSerializer.GetNextStringValue(canEndWithoutSeparator: false);
			string nextStringValue3 = stringSerializer.GetNextStringValue(canEndWithoutSeparator: false);
			string nextStringValue4 = stringSerializer.GetNextStringValue(canEndWithoutSeparator: false);
			AdjustmentRule[] nextAdjustmentRuleArrayValue = stringSerializer.GetNextAdjustmentRuleArrayValue(canEndWithoutSeparator: false);
			try
			{
				return CreateCustomTimeZone(nextStringValue, nextTimeSpanValue, nextStringValue2, nextStringValue3, nextStringValue4, nextAdjustmentRuleArrayValue);
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException);
			}
			catch (InvalidTimeZoneException innerException2)
			{
				throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException2);
			}
		}

		private StringSerializer(string str)
		{
			m_serializedText = str;
			m_state = State.StartOfToken;
		}

		private static string SerializeSubstitute(string text)
		{
			text = text.Replace("\\", "\\\\");
			text = text.Replace("[", "\\[");
			text = text.Replace("]", "\\]");
			return text.Replace(";", "\\;");
		}

		private static void SerializeTransitionTime(TransitionTime time, StringBuilder serializedText)
		{
			serializedText.Append('[');
			serializedText.Append((time.IsFixedDateRule ? 1 : 0).ToString(CultureInfo.InvariantCulture));
			serializedText.Append(';');
			if (time.IsFixedDateRule)
			{
				serializedText.Append(SerializeSubstitute(time.TimeOfDay.ToString("HH:mm:ss.FFF", DateTimeFormatInfo.InvariantInfo)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(time.Month.ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(time.Day.ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
			}
			else
			{
				serializedText.Append(SerializeSubstitute(time.TimeOfDay.ToString("HH:mm:ss.FFF", DateTimeFormatInfo.InvariantInfo)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(time.Month.ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(time.Week.ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(((int)time.DayOfWeek).ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
			}
			serializedText.Append(']');
		}

		private static void VerifyIsEscapableCharacter(char c)
		{
			if (c != '\\' && c != ';' && c != '[' && c != ']')
			{
				throw new SerializationException(SR.GetString("Serialization_InvalidEscapeSequence", c));
			}
		}

		private void SkipVersionNextDataFields(int depth)
		{
			if (m_currentTokenStartIndex >= 0 && m_currentTokenStartIndex < m_serializedText.Length)
			{
				State state = State.NotEscaped;
				for (int i = m_currentTokenStartIndex; i < m_serializedText.Length; i++)
				{
					switch (state)
					{
					case State.Escaped:
						VerifyIsEscapableCharacter(m_serializedText[i]);
						state = State.NotEscaped;
						break;
					case State.NotEscaped:
						switch (m_serializedText[i])
						{
						case '[':
							depth++;
							break;
						case '\\':
							state = State.Escaped;
							break;
						case ']':
							depth--;
							if (depth == 0)
							{
								m_currentTokenStartIndex = i + 1;
								if (m_currentTokenStartIndex >= m_serializedText.Length)
								{
									m_state = State.EndOfLine;
								}
								else
								{
									m_state = State.StartOfToken;
								}
								return;
							}
							break;
						case '\0':
							throw new SerializationException(SR.GetString("Serialization_InvalidData"));
						}
						break;
					}
				}
				throw new SerializationException(SR.GetString("Serialization_InvalidData"));
			}
			throw new SerializationException(SR.GetString("Serialization_InvalidData"));
		}

		private string GetNextStringValue(bool canEndWithoutSeparator)
		{
			if (m_state == State.EndOfLine)
			{
				if (canEndWithoutSeparator)
				{
					return null;
				}
				throw new SerializationException(SR.GetString("Serialization_InvalidData"));
			}
			if (m_currentTokenStartIndex >= 0 && m_currentTokenStartIndex < m_serializedText.Length)
			{
				State state = State.NotEscaped;
				StringBuilder stringBuilder = new StringBuilder(64);
				for (int i = m_currentTokenStartIndex; i < m_serializedText.Length; i++)
				{
					switch (state)
					{
					case State.Escaped:
						VerifyIsEscapableCharacter(m_serializedText[i]);
						stringBuilder.Append(m_serializedText[i]);
						state = State.NotEscaped;
						break;
					case State.NotEscaped:
						switch (m_serializedText[i])
						{
						default:
							stringBuilder.Append(m_serializedText[i]);
							break;
						case '\\':
							state = State.Escaped;
							break;
						case '[':
							throw new SerializationException(SR.GetString("Serialization_InvalidData"));
						case ']':
							if (canEndWithoutSeparator)
							{
								m_currentTokenStartIndex = i;
								m_state = State.StartOfToken;
								return stringBuilder.ToString();
							}
							throw new SerializationException(SR.GetString("Serialization_InvalidData"));
						case ';':
							m_currentTokenStartIndex = i + 1;
							if (m_currentTokenStartIndex >= m_serializedText.Length)
							{
								m_state = State.EndOfLine;
							}
							else
							{
								m_state = State.StartOfToken;
							}
							return stringBuilder.ToString();
						case '\0':
							throw new SerializationException(SR.GetString("Serialization_InvalidData"));
						}
						break;
					}
				}
				if (state == State.Escaped)
				{
					throw new SerializationException(SR.GetString("Serialization_InvalidEscapeSequence", string.Empty));
				}
				if (!canEndWithoutSeparator)
				{
					throw new SerializationException(SR.GetString("Serialization_InvalidData"));
				}
				m_currentTokenStartIndex = m_serializedText.Length;
				m_state = State.EndOfLine;
				return stringBuilder.ToString();
			}
			throw new SerializationException(SR.GetString("Serialization_InvalidData"));
		}

		private DateTime GetNextDateTimeValue(bool canEndWithoutSeparator, string format)
		{
			string nextStringValue = GetNextStringValue(canEndWithoutSeparator);
			if (!DateTime.TryParseExact(nextStringValue, format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out var result))
			{
				throw new SerializationException(SR.GetString("Serialization_InvalidData"));
			}
			return result;
		}

		private TimeSpan GetNextTimeSpanValue(bool canEndWithoutSeparator)
		{
			int nextInt32Value = GetNextInt32Value(canEndWithoutSeparator);
			try
			{
				return new TimeSpan(0, nextInt32Value, 0);
			}
			catch (ArgumentOutOfRangeException innerException)
			{
				throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException);
			}
		}

		private int GetNextInt32Value(bool canEndWithoutSeparator)
		{
			string nextStringValue = GetNextStringValue(canEndWithoutSeparator);
			if (!int.TryParse(nextStringValue, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out var result))
			{
				throw new SerializationException(SR.GetString("Serialization_InvalidData"));
			}
			return result;
		}

		private AdjustmentRule[] GetNextAdjustmentRuleArrayValue(bool canEndWithoutSeparator)
		{
			List<AdjustmentRule> list = new List<AdjustmentRule>(1);
			int num = 0;
			for (AdjustmentRule nextAdjustmentRuleValue = GetNextAdjustmentRuleValue(canEndWithoutSeparator: true); nextAdjustmentRuleValue != null; nextAdjustmentRuleValue = GetNextAdjustmentRuleValue(canEndWithoutSeparator: true))
			{
				list.Add(nextAdjustmentRuleValue);
				num++;
			}
			if (!canEndWithoutSeparator)
			{
				if (m_state == State.EndOfLine)
				{
					throw new SerializationException(SR.GetString("Serialization_InvalidData"));
				}
				if (m_currentTokenStartIndex < 0 || m_currentTokenStartIndex >= m_serializedText.Length)
				{
					throw new SerializationException(SR.GetString("Serialization_InvalidData"));
				}
			}
			if (num == 0)
			{
				return null;
			}
			return list.ToArray();
		}

		private AdjustmentRule GetNextAdjustmentRuleValue(bool canEndWithoutSeparator)
		{
			if (m_state == State.EndOfLine)
			{
				if (canEndWithoutSeparator)
				{
					return null;
				}
				throw new SerializationException(SR.GetString("Serialization_InvalidData"));
			}
			if (m_currentTokenStartIndex >= 0 && m_currentTokenStartIndex < m_serializedText.Length)
			{
				if (m_serializedText[m_currentTokenStartIndex] == ';')
				{
					return null;
				}
				if (m_serializedText[m_currentTokenStartIndex] != '[')
				{
					throw new SerializationException(SR.GetString("Serialization_InvalidData"));
				}
				m_currentTokenStartIndex++;
				DateTime nextDateTimeValue = GetNextDateTimeValue(canEndWithoutSeparator: false, "MM:dd:yyyy");
				DateTime nextDateTimeValue2 = GetNextDateTimeValue(canEndWithoutSeparator: false, "MM:dd:yyyy");
				TimeSpan nextTimeSpanValue = GetNextTimeSpanValue(canEndWithoutSeparator: false);
				TransitionTime nextTransitionTimeValue = GetNextTransitionTimeValue(canEndWithoutSeparator: false);
				TransitionTime nextTransitionTimeValue2 = GetNextTransitionTimeValue(canEndWithoutSeparator: false);
				if (m_state != State.EndOfLine && m_currentTokenStartIndex < m_serializedText.Length)
				{
					if (m_serializedText[m_currentTokenStartIndex] != ']')
					{
						SkipVersionNextDataFields(1);
					}
					else
					{
						m_currentTokenStartIndex++;
					}
					AdjustmentRule result;
					try
					{
						result = AdjustmentRule.CreateAdjustmentRule(nextDateTimeValue, nextDateTimeValue2, nextTimeSpanValue, nextTransitionTimeValue, nextTransitionTimeValue2);
					}
					catch (ArgumentException innerException)
					{
						throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException);
					}
					if (m_currentTokenStartIndex >= m_serializedText.Length)
					{
						m_state = State.EndOfLine;
					}
					else
					{
						m_state = State.StartOfToken;
					}
					return result;
				}
				throw new SerializationException(SR.GetString("Serialization_InvalidData"));
			}
			throw new SerializationException(SR.GetString("Serialization_InvalidData"));
		}

		private TransitionTime GetNextTransitionTimeValue(bool canEndWithoutSeparator)
		{
			if (m_state != State.EndOfLine && (m_currentTokenStartIndex >= m_serializedText.Length || m_serializedText[m_currentTokenStartIndex] != ']'))
			{
				if (m_currentTokenStartIndex >= 0 && m_currentTokenStartIndex < m_serializedText.Length)
				{
					if (m_serializedText[m_currentTokenStartIndex] != '[')
					{
						throw new SerializationException(SR.GetString("Serialization_InvalidData"));
					}
					m_currentTokenStartIndex++;
					int nextInt32Value = GetNextInt32Value(canEndWithoutSeparator: false);
					if (nextInt32Value != 0 && nextInt32Value != 1)
					{
						throw new SerializationException(SR.GetString("Serialization_InvalidData"));
					}
					DateTime nextDateTimeValue = GetNextDateTimeValue(canEndWithoutSeparator: false, "HH:mm:ss.FFF");
					nextDateTimeValue = new DateTime(1, 1, 1, nextDateTimeValue.Hour, nextDateTimeValue.Minute, nextDateTimeValue.Second, nextDateTimeValue.Millisecond);
					int nextInt32Value2 = GetNextInt32Value(canEndWithoutSeparator: false);
					TransitionTime result;
					if (nextInt32Value == 1)
					{
						int nextInt32Value3 = GetNextInt32Value(canEndWithoutSeparator: false);
						try
						{
							result = TransitionTime.CreateFixedDateRule(nextDateTimeValue, nextInt32Value2, nextInt32Value3);
						}
						catch (ArgumentException innerException)
						{
							throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException);
						}
					}
					else
					{
						int nextInt32Value4 = GetNextInt32Value(canEndWithoutSeparator: false);
						int nextInt32Value5 = GetNextInt32Value(canEndWithoutSeparator: false);
						try
						{
							result = TransitionTime.CreateFloatingDateRule(nextDateTimeValue, nextInt32Value2, nextInt32Value4, (DayOfWeek)nextInt32Value5);
						}
						catch (ArgumentException innerException2)
						{
							throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException2);
						}
					}
					if (m_state != State.EndOfLine && m_currentTokenStartIndex < m_serializedText.Length)
					{
						if (m_serializedText[m_currentTokenStartIndex] != ']')
						{
							SkipVersionNextDataFields(1);
						}
						else
						{
							m_currentTokenStartIndex++;
						}
						bool flag = false;
						if (m_currentTokenStartIndex < m_serializedText.Length && m_serializedText[m_currentTokenStartIndex] == ';')
						{
							m_currentTokenStartIndex++;
							flag = true;
						}
						if (!flag && !canEndWithoutSeparator)
						{
							throw new SerializationException(SR.GetString("Serialization_InvalidData"));
						}
						if (m_currentTokenStartIndex >= m_serializedText.Length)
						{
							m_state = State.EndOfLine;
						}
						else
						{
							m_state = State.StartOfToken;
						}
						return result;
					}
					throw new SerializationException(SR.GetString("Serialization_InvalidData"));
				}
				throw new SerializationException(SR.GetString("Serialization_InvalidData"));
			}
			throw new SerializationException(SR.GetString("Serialization_InvalidData"));
		}
	}

	private class TimeZoneInfoComparer : IComparer<TimeZoneInfo>
	{
		int IComparer<TimeZoneInfo>.Compare(TimeZoneInfo x, TimeZoneInfo y)
		{
			return string.Compare(x.DisplayName, y.DisplayName, StringComparison.Ordinal);
		}
	}

	private const string c_timeZonesRegistryHive = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones";

	private const string c_timeZonesRegistryHivePermissionList = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones";

	private const string c_displayValue = "Display";

	private const string c_daylightValue = "Dlt";

	private const string c_standardValue = "Std";

	private const string c_muiDisplayValue = "MUI_Display";

	private const string c_muiDaylightValue = "MUI_Dlt";

	private const string c_muiStandardValue = "MUI_Std";

	private const string c_timeZoneInfoValue = "TZI";

	private const string c_firstEntryValue = "FirstEntry";

	private const string c_lastEntryValue = "LastEntry";

	private const string c_timeZoneInfoRegistryHive = "SYSTEM\\CurrentControlSet\\Control\\TimeZoneInformation";

	private const string c_timeZoneInfoRegistryHivePermissionList = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\TimeZoneInformation";

	private const string c_disableDST = "DisableAutoDaylightTimeSet";

	private const string c_disableDynamicDST = "DynamicDaylightTimeDisabled";

	private const string c_utcId = "UTC";

	private const string c_localId = "Local";

	private const int c_maxKeyLength = 255;

	private const long c_ticksPerMillisecond = 10000L;

	private const long c_ticksPerSecond = 10000000L;

	private const long c_ticksPerMinute = 600000000L;

	private const long c_ticksPerHour = 36000000000L;

	private const long c_ticksPerDay = 864000000000L;

	private const long c_ticksPerDayRange = 863999990000L;

	private string m_id;

	private string m_displayName;

	private string m_standardDisplayName;

	private string m_daylightDisplayName;

	private TimeSpan m_baseUtcOffset;

	private bool m_supportsDaylightSavingTime;

	private AdjustmentRule[] m_adjustmentRules;

	private static TimeZoneInfo s_localTimeZone;

	private static TimeZoneInfo s_utcTimeZone;

	private static ReadOnlyCollection<TimeZoneInfo> s_readOnlySystemTimeZones;

	private static bool s_allSystemTimeZonesRead = false;

	private static Dictionary<string, TimeZoneInfo> s_hiddenSystemTimeZones;

	private static object s_hiddenInternalSyncObject;

	private static Dictionary<string, TimeZoneInfo> s_systemTimeZones
	{
		get
		{
			if (s_hiddenSystemTimeZones == null)
			{
				s_hiddenSystemTimeZones = new Dictionary<string, TimeZoneInfo>();
			}
			return s_hiddenSystemTimeZones;
		}
		set
		{
			s_hiddenSystemTimeZones = value;
		}
	}

	private static object s_internalSyncObject
	{
		get
		{
			if (s_hiddenInternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_hiddenInternalSyncObject, value, null);
			}
			return s_hiddenInternalSyncObject;
		}
	}

	public string Id => m_id;

	public string DisplayName
	{
		get
		{
			if (m_displayName != null)
			{
				return m_displayName;
			}
			return string.Empty;
		}
	}

	public string StandardName
	{
		get
		{
			if (m_standardDisplayName != null)
			{
				return m_standardDisplayName;
			}
			return string.Empty;
		}
	}

	public string DaylightName
	{
		get
		{
			if (m_daylightDisplayName != null)
			{
				return m_daylightDisplayName;
			}
			return string.Empty;
		}
	}

	public TimeSpan BaseUtcOffset => m_baseUtcOffset;

	public bool SupportsDaylightSavingTime => m_supportsDaylightSavingTime;

	public static TimeZoneInfo Local
	{
		[SecurityCritical]
		get
		{
			TimeZoneInfo timeZoneInfo = s_localTimeZone;
			if (timeZoneInfo == null)
			{
				lock (s_internalSyncObject)
				{
					if (s_localTimeZone == null)
					{
						TimeZoneInfo localTimeZone = GetLocalTimeZone();
						s_localTimeZone = new TimeZoneInfo(localTimeZone.m_id, localTimeZone.m_baseUtcOffset, localTimeZone.m_displayName, localTimeZone.m_standardDisplayName, localTimeZone.m_daylightDisplayName, localTimeZone.m_adjustmentRules, disableDaylightSavingTime: false);
					}
					return s_localTimeZone;
				}
			}
			return timeZoneInfo;
		}
	}

	public static TimeZoneInfo Utc
	{
		get
		{
			TimeZoneInfo timeZoneInfo = s_utcTimeZone;
			if (timeZoneInfo == null)
			{
				lock (s_internalSyncObject)
				{
					if (s_utcTimeZone == null)
					{
						s_utcTimeZone = CreateCustomTimeZone("UTC", TimeSpan.Zero, "UTC", "UTC");
					}
					return s_utcTimeZone;
				}
			}
			return timeZoneInfo;
		}
	}

	public AdjustmentRule[] GetAdjustmentRules()
	{
		if (m_adjustmentRules == null)
		{
			return new AdjustmentRule[0];
		}
		return (AdjustmentRule[])m_adjustmentRules.Clone();
	}

	public TimeSpan[] GetAmbiguousTimeOffsets(DateTimeOffset dateTimeOffset)
	{
		if (!m_supportsDaylightSavingTime)
		{
			throw new ArgumentException(SR.GetString("Argument_DateTimeOffsetIsNotAmbiguous"), "dateTimeOffset");
		}
		DateTime dateTime = ConvertTime(dateTimeOffset, this).DateTime;
		bool flag = false;
		AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime);
		if (adjustmentRuleForTime != null)
		{
			DaylightTime daylightTime = GetDaylightTime(dateTime.Year, adjustmentRuleForTime);
			flag = GetIsAmbiguousTime(dateTime, adjustmentRuleForTime, daylightTime);
		}
		if (!flag)
		{
			throw new ArgumentException(SR.GetString("Argument_DateTimeOffsetIsNotAmbiguous"), "dateTimeOffset");
		}
		TimeSpan[] array = new TimeSpan[2];
		if (adjustmentRuleForTime.DaylightDelta > TimeSpan.Zero)
		{
			ref TimeSpan reference = ref array[0];
			reference = m_baseUtcOffset;
			ref TimeSpan reference2 = ref array[1];
			reference2 = m_baseUtcOffset + adjustmentRuleForTime.DaylightDelta;
		}
		else
		{
			ref TimeSpan reference3 = ref array[0];
			reference3 = m_baseUtcOffset + adjustmentRuleForTime.DaylightDelta;
			ref TimeSpan reference4 = ref array[1];
			reference4 = m_baseUtcOffset;
		}
		return array;
	}

	public TimeSpan[] GetAmbiguousTimeOffsets(DateTime dateTime)
	{
		if (!m_supportsDaylightSavingTime)
		{
			throw new ArgumentException(SR.GetString("Argument_DateTimeIsNotAmbiguous"), "dateTime");
		}
		DateTime dateTime2;
		if (dateTime.Kind == DateTimeKind.Local)
		{
			lock (s_internalSyncObject)
			{
				dateTime2 = ConvertTime(dateTime, Local, this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
		}
		else if (dateTime.Kind == DateTimeKind.Utc)
		{
			lock (s_internalSyncObject)
			{
				dateTime2 = ConvertTime(dateTime, Utc, this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
		}
		else
		{
			dateTime2 = dateTime;
		}
		bool flag = false;
		AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime2);
		if (adjustmentRuleForTime != null)
		{
			DaylightTime daylightTime = GetDaylightTime(dateTime2.Year, adjustmentRuleForTime);
			flag = GetIsAmbiguousTime(dateTime2, adjustmentRuleForTime, daylightTime);
		}
		if (!flag)
		{
			throw new ArgumentException(SR.GetString("Argument_DateTimeIsNotAmbiguous"), "dateTime");
		}
		TimeSpan[] array = new TimeSpan[2];
		if (adjustmentRuleForTime.DaylightDelta > TimeSpan.Zero)
		{
			ref TimeSpan reference = ref array[0];
			reference = m_baseUtcOffset;
			ref TimeSpan reference2 = ref array[1];
			reference2 = m_baseUtcOffset + adjustmentRuleForTime.DaylightDelta;
		}
		else
		{
			ref TimeSpan reference3 = ref array[0];
			reference3 = m_baseUtcOffset + adjustmentRuleForTime.DaylightDelta;
			ref TimeSpan reference4 = ref array[1];
			reference4 = m_baseUtcOffset;
		}
		return array;
	}

	public TimeSpan GetUtcOffset(DateTimeOffset dateTimeOffset)
	{
		return GetUtcOffsetFromUtc(dateTimeOffset.UtcDateTime, this);
	}

	public TimeSpan GetUtcOffset(DateTime dateTime)
	{
		if (dateTime.Kind == DateTimeKind.Local)
		{
			DateTime time;
			lock (s_internalSyncObject)
			{
				if (GetCorrespondingKind() == DateTimeKind.Local)
				{
					return GetUtcOffset(dateTime, this);
				}
				time = ConvertTime(dateTime, Local, Utc, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
			return GetUtcOffsetFromUtc(time, this);
		}
		if (dateTime.Kind == DateTimeKind.Utc)
		{
			if (GetCorrespondingKind() == DateTimeKind.Utc)
			{
				return m_baseUtcOffset;
			}
			return GetUtcOffsetFromUtc(dateTime, this);
		}
		return GetUtcOffset(dateTime, this);
	}

	public bool IsAmbiguousTime(DateTimeOffset dateTimeOffset)
	{
		if (!m_supportsDaylightSavingTime)
		{
			return false;
		}
		return IsAmbiguousTime(ConvertTime(dateTimeOffset, this).DateTime);
	}

	public bool IsAmbiguousTime(DateTime dateTime)
	{
		if (!m_supportsDaylightSavingTime)
		{
			return false;
		}
		DateTime dateTime2;
		if (dateTime.Kind == DateTimeKind.Local)
		{
			lock (s_internalSyncObject)
			{
				dateTime2 = ConvertTime(dateTime, Local, this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
		}
		else if (dateTime.Kind == DateTimeKind.Utc)
		{
			lock (s_internalSyncObject)
			{
				dateTime2 = ConvertTime(dateTime, Utc, this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
		}
		else
		{
			dateTime2 = dateTime;
		}
		AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime2);
		if (adjustmentRuleForTime != null)
		{
			DaylightTime daylightTime = GetDaylightTime(dateTime2.Year, adjustmentRuleForTime);
			return GetIsAmbiguousTime(dateTime2, adjustmentRuleForTime, daylightTime);
		}
		return false;
	}

	public bool IsDaylightSavingTime(DateTimeOffset dateTimeOffset)
	{
		GetUtcOffsetFromUtc(dateTimeOffset.UtcDateTime, this, out var isDaylightSavings);
		return isDaylightSavings;
	}

	public bool IsDaylightSavingTime(DateTime dateTime)
	{
		if (m_supportsDaylightSavingTime && m_adjustmentRules != null)
		{
			DateTime dateTime2;
			if (dateTime.Kind == DateTimeKind.Local)
			{
				lock (s_internalSyncObject)
				{
					dateTime2 = ConvertTime(dateTime, Local, this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
				}
			}
			else
			{
				if (dateTime.Kind == DateTimeKind.Utc)
				{
					if (GetCorrespondingKind() == DateTimeKind.Utc)
					{
						return false;
					}
					GetUtcOffsetFromUtc(dateTime, this, out var isDaylightSavings);
					return isDaylightSavings;
				}
				dateTime2 = dateTime;
			}
			AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime2);
			if (adjustmentRuleForTime != null)
			{
				DaylightTime daylightTime = GetDaylightTime(dateTime2.Year, adjustmentRuleForTime);
				return GetIsDaylightSavings(dateTime2, adjustmentRuleForTime, daylightTime);
			}
			return false;
		}
		return false;
	}

	public bool IsInvalidTime(DateTime dateTime)
	{
		bool result = false;
		if (dateTime.Kind == DateTimeKind.Unspecified || (dateTime.Kind == DateTimeKind.Local && GetCorrespondingKind() == DateTimeKind.Local))
		{
			AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime);
			if (adjustmentRuleForTime != null)
			{
				DaylightTime daylightTime = GetDaylightTime(dateTime.Year, adjustmentRuleForTime);
				result = GetIsInvalidTime(dateTime, adjustmentRuleForTime, daylightTime);
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	public static void ClearCachedData()
	{
		lock (s_internalSyncObject)
		{
			s_localTimeZone = null;
			s_utcTimeZone = null;
			s_systemTimeZones = null;
			s_readOnlySystemTimeZones = null;
			s_allSystemTimeZonesRead = false;
		}
	}

	public static DateTimeOffset ConvertTimeBySystemTimeZoneId(DateTimeOffset dateTimeOffset, string destinationTimeZoneId)
	{
		return ConvertTime(dateTimeOffset, FindSystemTimeZoneById(destinationTimeZoneId));
	}

	public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string destinationTimeZoneId)
	{
		return ConvertTime(dateTime, FindSystemTimeZoneById(destinationTimeZoneId));
	}

	public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string sourceTimeZoneId, string destinationTimeZoneId)
	{
		if (dateTime.Kind == DateTimeKind.Local && string.Compare(sourceTimeZoneId, Local.Id, StringComparison.OrdinalIgnoreCase) == 0)
		{
			lock (s_internalSyncObject)
			{
				return ConvertTime(dateTime, Local, FindSystemTimeZoneById(destinationTimeZoneId));
			}
		}
		if (dateTime.Kind == DateTimeKind.Utc && string.Compare(sourceTimeZoneId, Utc.Id, StringComparison.OrdinalIgnoreCase) == 0)
		{
			lock (s_internalSyncObject)
			{
				return ConvertTime(dateTime, Utc, FindSystemTimeZoneById(destinationTimeZoneId));
			}
		}
		return ConvertTime(dateTime, FindSystemTimeZoneById(sourceTimeZoneId), FindSystemTimeZoneById(destinationTimeZoneId));
	}

	public static DateTimeOffset ConvertTime(DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
	{
		if (destinationTimeZone == null)
		{
			throw new ArgumentNullException("destinationTimeZone");
		}
		DateTime utcDateTime = dateTimeOffset.UtcDateTime;
		TimeSpan utcOffsetFromUtc = GetUtcOffsetFromUtc(utcDateTime, destinationTimeZone);
		long num = utcDateTime.Ticks + utcOffsetFromUtc.Ticks;
		DateTimeOffset maxValue = DateTimeOffset.MaxValue;
		if (num > maxValue.Ticks)
		{
			return DateTimeOffset.MaxValue;
		}
		DateTimeOffset minValue = DateTimeOffset.MinValue;
		if (num < minValue.Ticks)
		{
			return DateTimeOffset.MinValue;
		}
		return new DateTimeOffset(num, utcOffsetFromUtc);
	}

	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo destinationTimeZone)
	{
		if (destinationTimeZone == null)
		{
			throw new ArgumentNullException("destinationTimeZone");
		}
		if (dateTime.Kind == DateTimeKind.Utc)
		{
			lock (s_internalSyncObject)
			{
				return ConvertTime(dateTime, Utc, destinationTimeZone);
			}
		}
		lock (s_internalSyncObject)
		{
			return ConvertTime(dateTime, Local, destinationTimeZone);
		}
	}

	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone)
	{
		return ConvertTime(dateTime, sourceTimeZone, destinationTimeZone, TimeZoneInfoOptions.None);
	}

	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
	{
		if (sourceTimeZone == null)
		{
			throw new ArgumentNullException("sourceTimeZone");
		}
		if (destinationTimeZone == null)
		{
			throw new ArgumentNullException("destinationTimeZone");
		}
		DateTimeKind correspondingKind = sourceTimeZone.GetCorrespondingKind();
		if ((flags & TimeZoneInfoOptions.NoThrowOnInvalidTime) == 0 && dateTime.Kind != 0 && dateTime.Kind != correspondingKind)
		{
			throw new ArgumentException(SR.GetString("Argument_ConvertMismatch"), "sourceTimeZone");
		}
		AdjustmentRule adjustmentRuleForTime = sourceTimeZone.GetAdjustmentRuleForTime(dateTime);
		TimeSpan baseUtcOffset = sourceTimeZone.BaseUtcOffset;
		if (adjustmentRuleForTime != null)
		{
			bool flag = false;
			DaylightTime daylightTime = GetDaylightTime(dateTime.Year, adjustmentRuleForTime);
			if ((flags & TimeZoneInfoOptions.NoThrowOnInvalidTime) == 0 && GetIsInvalidTime(dateTime, adjustmentRuleForTime, daylightTime))
			{
				throw new ArgumentException(SR.GetString("Argument_DateTimeIsInvalid"), "dateTime");
			}
			flag = GetIsDaylightSavings(dateTime, adjustmentRuleForTime, daylightTime);
			baseUtcOffset += (flag ? adjustmentRuleForTime.DaylightDelta : TimeSpan.Zero);
		}
		DateTimeKind dateTimeKind = destinationTimeZone.GetCorrespondingKind();
		if (dateTime.Kind != 0 && correspondingKind != 0 && correspondingKind == dateTimeKind)
		{
			return dateTime;
		}
		long ticks = dateTime.Ticks - baseUtcOffset.Ticks;
		DateTime dateTime2 = ConvertUtcToTimeZone(ticks, destinationTimeZone);
		if (dateTimeKind == DateTimeKind.Local)
		{
			dateTimeKind = DateTimeKind.Unspecified;
		}
		return new DateTime(dateTime2.Ticks, dateTimeKind);
	}

	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone)
	{
		lock (s_internalSyncObject)
		{
			return ConvertTime(dateTime, Utc, destinationTimeZone);
		}
	}

	public static DateTime ConvertTimeToUtc(DateTime dateTime)
	{
		if (dateTime.Kind == DateTimeKind.Utc)
		{
			return dateTime;
		}
		lock (s_internalSyncObject)
		{
			return ConvertTime(dateTime, Local, Utc);
		}
	}

	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone)
	{
		lock (s_internalSyncObject)
		{
			return ConvertTime(dateTime, sourceTimeZone, Utc);
		}
	}

	public bool Equals(TimeZoneInfo other)
	{
		if (other != null && string.Compare(m_id, other.m_id, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return HasSameRules(other);
		}
		return false;
	}

	public static TimeZoneInfo FindSystemTimeZoneById(string id)
	{
		if (string.Compare(id, "UTC", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return Utc;
		}
		lock (s_internalSyncObject)
		{
			return GetTimeZone(id);
		}
	}

	public static TimeZoneInfo FromSerializedString(string source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (source.Length == 0)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidSerializedString", source), "source");
		}
		return StringSerializer.GetDeserializedTimeZoneInfo(source);
	}

	public override int GetHashCode()
	{
		return m_id.ToUpperInvariant().GetHashCode();
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		lock (s_internalSyncObject)
		{
			if (!s_allSystemTimeZonesRead)
			{
				PermissionSet permissionSet = new PermissionSet(PermissionState.None);
				permissionSet.AddPermission((IPermission?)new RegistryPermission((RegistryPermissionAccess)1, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones"));
				permissionSet.Assert();
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey))
				{
					if (registryKey == null)
					{
						List<TimeZoneInfo> list = ((s_systemTimeZones == null) ? new List<TimeZoneInfo>() : new List<TimeZoneInfo>(s_systemTimeZones.Values));
						s_readOnlySystemTimeZones = new ReadOnlyCollection<TimeZoneInfo>(list);
						s_allSystemTimeZonesRead = true;
						return s_readOnlySystemTimeZones;
					}
					string[] subKeyNames = registryKey.GetSubKeyNames();
					foreach (string id in subKeyNames)
					{
						TryGetTimeZone(id, dstDisabled: false, out var _, out var _);
					}
				}
				IComparer<TimeZoneInfo> comparer = new TimeZoneInfoComparer();
				List<TimeZoneInfo> list2 = new List<TimeZoneInfo>(s_systemTimeZones.Values);
				list2.Sort(comparer);
				s_readOnlySystemTimeZones = new ReadOnlyCollection<TimeZoneInfo>(list2);
				s_allSystemTimeZonesRead = true;
			}
			return s_readOnlySystemTimeZones;
		}
	}

	public bool HasSameRules(TimeZoneInfo other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (!(m_baseUtcOffset != other.m_baseUtcOffset) && m_supportsDaylightSavingTime == other.m_supportsDaylightSavingTime)
		{
			AdjustmentRule[] adjustmentRules = m_adjustmentRules;
			AdjustmentRule[] adjustmentRules2 = other.m_adjustmentRules;
			bool result;
			if (!(result = (adjustmentRules == null && adjustmentRules2 == null) || (adjustmentRules != null && adjustmentRules2 != null)))
			{
				return false;
			}
			if (adjustmentRules != null)
			{
				if (adjustmentRules.Length != adjustmentRules2.Length)
				{
					return false;
				}
				for (int i = 0; i < adjustmentRules.Length; i++)
				{
					if (!adjustmentRules[i].Equals(adjustmentRules2[i]))
					{
						return false;
					}
				}
			}
			return result;
		}
		return false;
	}

	public string ToSerializedString()
	{
		return StringSerializer.GetSerializedString(this);
	}

	public override string ToString()
	{
		return DisplayName;
	}

	private TimeZoneInfo(NativeMethods.TimeZoneInformation zone, bool dstDisabled)
	{
		if (string.IsNullOrEmpty(zone.StandardName))
		{
			m_id = "Local";
		}
		else
		{
			m_id = zone.StandardName;
		}
		m_baseUtcOffset = new TimeSpan(0, -zone.Bias, 0);
		if (!dstDisabled)
		{
			NativeMethods.RegistryTimeZoneInformation timeZoneInformation = new NativeMethods.RegistryTimeZoneInformation(zone);
			DateTime minValue = DateTime.MinValue;
			DateTime date = minValue.Date;
			DateTime maxValue = DateTime.MaxValue;
			AdjustmentRule adjustmentRule = CreateAdjustmentRuleFromTimeZoneInformation(timeZoneInformation, date, maxValue.Date);
			if (adjustmentRule != null)
			{
				m_adjustmentRules = new AdjustmentRule[1];
				m_adjustmentRules[0] = adjustmentRule;
			}
		}
		ValidateTimeZoneInfo(m_id, m_baseUtcOffset, m_adjustmentRules, out m_supportsDaylightSavingTime);
		m_displayName = zone.StandardName;
		m_standardDisplayName = zone.StandardName;
		m_daylightDisplayName = zone.DaylightName;
	}

	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
	{
		ValidateTimeZoneInfo(id, baseUtcOffset, adjustmentRules, out var adjustmentRulesSupportDst);
		if (!disableDaylightSavingTime && adjustmentRules != null && adjustmentRules.Length > 0)
		{
			m_adjustmentRules = (AdjustmentRule[])adjustmentRules.Clone();
		}
		m_id = id;
		m_baseUtcOffset = baseUtcOffset;
		m_displayName = displayName;
		m_standardDisplayName = standardDisplayName;
		m_daylightDisplayName = (disableDaylightSavingTime ? null : daylightDisplayName);
		m_supportsDaylightSavingTime = adjustmentRulesSupportDst && !disableDaylightSavingTime;
	}

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
	{
		return new TimeZoneInfo(id, baseUtcOffset, displayName, standardDisplayName, standardDisplayName, null, disableDaylightSavingTime: false);
	}

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules)
	{
		return new TimeZoneInfo(id, baseUtcOffset, displayName, standardDisplayName, daylightDisplayName, adjustmentRules, disableDaylightSavingTime: false);
	}

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
	{
		return new TimeZoneInfo(id, baseUtcOffset, displayName, standardDisplayName, daylightDisplayName, adjustmentRules, disableDaylightSavingTime);
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
		try
		{
			ValidateTimeZoneInfo(m_id, m_baseUtcOffset, m_adjustmentRules, out var adjustmentRulesSupportDst);
			if (adjustmentRulesSupportDst != m_supportsDaylightSavingTime)
			{
				throw new SerializationException(SR.GetString("Serialization_CorruptField", "SupportsDaylightSavingTime"));
			}
		}
		catch (ArgumentException innerException)
		{
			throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException);
		}
		catch (InvalidTimeZoneException innerException2)
		{
			throw new SerializationException(SR.GetString("Serialization_InvalidData"), innerException2);
		}
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("Id", m_id);
		info.AddValue("DisplayName", m_displayName);
		info.AddValue("StandardName", m_standardDisplayName);
		info.AddValue("DaylightName", m_daylightDisplayName);
		info.AddValue("BaseUtcOffset", m_baseUtcOffset);
		info.AddValue("AdjustmentRules", m_adjustmentRules);
		info.AddValue("SupportsDaylightSavingTime", m_supportsDaylightSavingTime);
	}

	private TimeZoneInfo(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		m_id = (string)info.GetValue("Id", typeof(string));
		m_displayName = (string)info.GetValue("DisplayName", typeof(string));
		m_standardDisplayName = (string)info.GetValue("StandardName", typeof(string));
		m_daylightDisplayName = (string)info.GetValue("DaylightName", typeof(string));
		m_baseUtcOffset = (TimeSpan)info.GetValue("BaseUtcOffset", typeof(TimeSpan));
		m_adjustmentRules = (AdjustmentRule[])info.GetValue("AdjustmentRules", typeof(AdjustmentRule[]));
		m_supportsDaylightSavingTime = (bool)info.GetValue("SupportsDaylightSavingTime", typeof(bool));
	}

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime)
	{
		if (m_adjustmentRules != null && m_adjustmentRules.Length != 0)
		{
			DateTime date = dateTime.Date;
			int num = 0;
			while (true)
			{
				if (num < m_adjustmentRules.Length)
				{
					if (m_adjustmentRules[num].DateStart <= date && m_adjustmentRules[num].DateEnd >= date)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return m_adjustmentRules[num];
		}
		return null;
	}

	private DateTimeKind GetCorrespondingKind()
	{
		if (this == s_utcTimeZone)
		{
			return DateTimeKind.Utc;
		}
		if (this == s_localTimeZone)
		{
			return DateTimeKind.Local;
		}
		return DateTimeKind.Unspecified;
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	private static bool CheckDaylightSavingTimeDisabled()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		try
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission((IPermission?)new RegistryPermission((RegistryPermissionAccess)1, "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\TimeZoneInformation"));
			permissionSet.Assert();
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\TimeZoneInformation", RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey);
			if (registryKey == null)
			{
				return false;
			}
			int num = 0;
			try
			{
				num = (int)registryKey.GetValue("DisableAutoDaylightTimeSet", 0, RegistryValueOptions.None);
			}
			catch (InvalidCastException)
			{
			}
			if (num == 1)
			{
				return true;
			}
			try
			{
				num = (int)registryKey.GetValue("DynamicDaylightTimeDisabled", 0, RegistryValueOptions.None);
			}
			catch (InvalidCastException)
			{
			}
			if (num == 1)
			{
				return true;
			}
		}
		finally
		{
			PermissionSet.RevertAssert();
		}
		return false;
	}

	private static bool CheckDaylightSavingTimeNotSupported(NativeMethods.TimeZoneInformation timeZone)
	{
		if (timeZone.DaylightDate.Year == timeZone.StandardDate.Year && timeZone.DaylightDate.Month == timeZone.StandardDate.Month && timeZone.DaylightDate.DayOfWeek == timeZone.StandardDate.DayOfWeek && timeZone.DaylightDate.Day == timeZone.StandardDate.Day && timeZone.DaylightDate.Hour == timeZone.StandardDate.Hour && timeZone.DaylightDate.Minute == timeZone.StandardDate.Minute && timeZone.DaylightDate.Second == timeZone.StandardDate.Second)
		{
			return timeZone.DaylightDate.Milliseconds == timeZone.StandardDate.Milliseconds;
		}
		return false;
	}

	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone)
	{
		long num = ticks;
		DateTime maxValue = DateTime.MaxValue;
		DateTime time;
		if (num > maxValue.Ticks)
		{
			time = DateTime.MaxValue;
		}
		else
		{
			long num2 = ticks;
			DateTime minValue = DateTime.MinValue;
			time = ((num2 >= minValue.Ticks) ? new DateTime(ticks) : DateTime.MinValue);
		}
		ticks += GetUtcOffsetFromUtc(time, destinationTimeZone).Ticks;
		long num3 = ticks;
		DateTime maxValue2 = DateTime.MaxValue;
		if (num3 > maxValue2.Ticks)
		{
			return DateTime.MaxValue;
		}
		long num4 = ticks;
		DateTime minValue2 = DateTime.MinValue;
		if (num4 < minValue2.Ticks)
		{
			return DateTime.MinValue;
		}
		return new DateTime(ticks);
	}

	private static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(NativeMethods.RegistryTimeZoneInformation timeZoneInformation, DateTime startDate, DateTime endDate)
	{
		if (timeZoneInformation.StandardDate.Month == 0)
		{
			return null;
		}
		TransitionTime? transitionTime = TransitionTimeFromTimeZoneInformation(timeZoneInformation, readStartDate: true);
		if (!transitionTime.HasValue)
		{
			return null;
		}
		TransitionTime? transitionTime2 = TransitionTimeFromTimeZoneInformation(timeZoneInformation, readStartDate: false);
		if (!transitionTime2.HasValue)
		{
			return null;
		}
		if (transitionTime.Equals(transitionTime2))
		{
			return null;
		}
		return AdjustmentRule.CreateAdjustmentRule(startDate, endDate, new TimeSpan(0, -timeZoneInformation.DaylightBias, 0), transitionTime.Value, transitionTime2.Value);
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	private static string FindIdFromTimeZoneInformation(NativeMethods.TimeZoneInformation timeZone, out bool dstDisabled)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		dstDisabled = false;
		try
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission((IPermission?)new RegistryPermission((RegistryPermissionAccess)1, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones"));
			permissionSet.Assert();
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey);
			if (registryKey == null)
			{
				return null;
			}
			string[] subKeyNames = registryKey.GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				if (TryCompareTimeZoneInformationToRegistry(timeZone, text, out dstDisabled))
				{
					return text;
				}
			}
		}
		finally
		{
			PermissionSet.RevertAssert();
		}
		return null;
	}

	private static DaylightTime GetDaylightTime(int year, AdjustmentRule rule)
	{
		TimeSpan daylightDelta = rule.DaylightDelta;
		DateTime start = TransitionTimeToDateTime(year, rule.DaylightTransitionStart);
		DateTime end = TransitionTimeToDateTime(year, rule.DaylightTransitionEnd);
		return new DaylightTime(start, end, daylightDelta);
	}

	private static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTime daylightTime)
	{
		if (rule == null)
		{
			return false;
		}
		bool flag = rule.DaylightDelta > TimeSpan.Zero;
		DateTime startTime = daylightTime.Start + (flag ? rule.DaylightDelta : TimeSpan.Zero);
		DateTime endTime = daylightTime.End + (flag ? (-rule.DaylightDelta) : TimeSpan.Zero);
		return CheckIsDst(startTime, time, endTime);
	}

	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int Year, TimeSpan utc, AdjustmentRule rule)
	{
		if (rule == null)
		{
			return false;
		}
		DaylightTime daylightTime = GetDaylightTime(Year, rule);
		DateTime startTime = daylightTime.Start - utc;
		DateTime endTime = daylightTime.End - utc - rule.DaylightDelta;
		return CheckIsDst(startTime, time, endTime);
	}

	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime)
	{
		if (startTime.Year != endTime.Year)
		{
			endTime = endTime.AddYears(startTime.Year - endTime.Year);
		}
		if (startTime.Year != time.Year)
		{
			time = time.AddYears(startTime.Year - time.Year);
		}
		if (startTime > endTime)
		{
			return time < endTime || time >= startTime;
		}
		return time >= startTime && time < endTime;
	}

	private static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTime daylightTime)
	{
		bool result = false;
		if (rule != null && !(rule.DaylightDelta == TimeSpan.Zero))
		{
			DateTime dateTime;
			DateTime dateTime2;
			if (rule.DaylightDelta > TimeSpan.Zero)
			{
				dateTime = daylightTime.End;
				dateTime2 = daylightTime.End - rule.DaylightDelta;
			}
			else
			{
				dateTime = daylightTime.Start;
				dateTime2 = daylightTime.Start + rule.DaylightDelta;
			}
			if (!(result = time >= dateTime2 && time < dateTime) && dateTime.Year != dateTime2.Year)
			{
				try
				{
					DateTime dateTime3 = dateTime.AddYears(1);
					DateTime dateTime4 = dateTime2.AddYears(1);
					result = time >= dateTime4 && time < dateTime3;
				}
				catch (ArgumentOutOfRangeException)
				{
				}
				if (!result)
				{
					try
					{
						DateTime dateTime3 = dateTime.AddYears(-1);
						DateTime dateTime4 = dateTime2.AddYears(-1);
						result = time >= dateTime4 && time < dateTime3;
						return result;
					}
					catch (ArgumentOutOfRangeException)
					{
						return result;
					}
				}
			}
			return result;
		}
		return result;
	}

	private static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTime daylightTime)
	{
		bool result = false;
		if (rule != null && !(rule.DaylightDelta == TimeSpan.Zero))
		{
			DateTime dateTime;
			DateTime dateTime2;
			if (rule.DaylightDelta < TimeSpan.Zero)
			{
				dateTime = daylightTime.End;
				dateTime2 = daylightTime.End - rule.DaylightDelta;
			}
			else
			{
				dateTime = daylightTime.Start;
				dateTime2 = daylightTime.Start + rule.DaylightDelta;
			}
			if (!(result = time >= dateTime && time < dateTime2) && dateTime.Year != dateTime2.Year)
			{
				try
				{
					DateTime dateTime3 = dateTime.AddYears(1);
					DateTime dateTime4 = dateTime2.AddYears(1);
					result = time >= dateTime3 && time < dateTime4;
				}
				catch (ArgumentOutOfRangeException)
				{
				}
				if (!result)
				{
					try
					{
						DateTime dateTime3 = dateTime.AddYears(-1);
						DateTime dateTime4 = dateTime2.AddYears(-1);
						result = time >= dateTime3 && time < dateTime4;
						return result;
					}
					catch (ArgumentOutOfRangeException)
					{
						return result;
					}
				}
			}
			return result;
		}
		return result;
	}

	[SecurityCritical]
	private static TimeZoneInfo GetLocalTimeZone()
	{
		string text = null;
		try
		{
			NativeMethods.DynamicTimeZoneInformation lpDynamicTimeZoneInformation = default(NativeMethods.DynamicTimeZoneInformation);
			long num = UnsafeNativeMethods.GetDynamicTimeZoneInformation(out lpDynamicTimeZoneInformation);
			if (num == -1L)
			{
				return CreateCustomTimeZone("Local", TimeSpan.Zero, "Local", "Local");
			}
			NativeMethods.TimeZoneInformation timeZoneInformation = new NativeMethods.TimeZoneInformation(lpDynamicTimeZoneInformation);
			bool dstDisabled = CheckDaylightSavingTimeDisabled();
			if (!string.IsNullOrEmpty(lpDynamicTimeZoneInformation.TimeZoneKeyName) && TryGetTimeZone(lpDynamicTimeZoneInformation.TimeZoneKeyName, dstDisabled, out var value, out var _) == TimeZoneInfoResult.Success)
			{
				return value;
			}
			text = FindIdFromTimeZoneInformation(timeZoneInformation, out dstDisabled);
			if (text != null && TryGetTimeZone(text, dstDisabled, out var value2, out var _) == TimeZoneInfoResult.Success)
			{
				return value2;
			}
			return GetLocalTimeZoneFromWin32Data(timeZoneInformation, dstDisabled);
		}
		catch (EntryPointNotFoundException)
		{
			NativeMethods.TimeZoneInformation lpTimeZoneInformation = default(NativeMethods.TimeZoneInformation);
			long num2 = UnsafeNativeMethods.GetTimeZoneInformation(out lpTimeZoneInformation);
			if (num2 == -1L)
			{
				return CreateCustomTimeZone("Local", TimeSpan.Zero, "Local", "Local");
			}
			text = FindIdFromTimeZoneInformation(lpTimeZoneInformation, out var dstDisabled2);
			if (text != null && TryGetTimeZone(text, dstDisabled2, out var value3, out var _) == TimeZoneInfoResult.Success)
			{
				return value3;
			}
			return GetLocalTimeZoneFromWin32Data(lpTimeZoneInformation, dstDisabled2);
		}
	}

	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(NativeMethods.TimeZoneInformation timeZoneInformation, bool dstDisabled)
	{
		try
		{
			return new TimeZoneInfo(timeZoneInformation, dstDisabled);
		}
		catch (ArgumentException)
		{
		}
		catch (InvalidTimeZoneException)
		{
		}
		try
		{
			return new TimeZoneInfo(timeZoneInformation, dstDisabled: true);
		}
		catch (ArgumentException)
		{
		}
		catch (InvalidTimeZoneException)
		{
		}
		return CreateCustomTimeZone("Local", TimeSpan.Zero, "Local", "Local");
	}

	private static TimeZoneInfo GetTimeZone(string id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		TimeZoneInfo value;
		Exception e;
		if (id.Length != 0 && id.Length <= 255 && !id.Contains("\0"))
		{
			return TryGetTimeZone(id, dstDisabled: false, out value, out e) switch
			{
				TimeZoneInfoResult.InvalidTimeZoneException => throw new InvalidTimeZoneException(SR.GetString("InvalidTimeZone_InvalidRegistryData", id), e), 
				TimeZoneInfoResult.SecurityException => throw new SecurityException(SR.GetString("Security_CannotReadRegistryData", id), e), 
				TimeZoneInfoResult.Success => value, 
				_ => throw new TimeZoneNotFoundException(SR.GetString("TimeZoneNotFound_MissingRegistryData", id), e), 
			};
		}
		throw new TimeZoneNotFoundException(SR.GetString("TimeZoneNotFound_MissingRegistryData", id));
	}

	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone)
	{
		TimeSpan baseUtcOffset = zone.BaseUtcOffset;
		AdjustmentRule adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(time);
		if (adjustmentRuleForTime != null)
		{
			DaylightTime daylightTime = GetDaylightTime(time.Year, adjustmentRuleForTime);
			bool isDaylightSavings = GetIsDaylightSavings(time, adjustmentRuleForTime, daylightTime);
			baseUtcOffset += (isDaylightSavings ? adjustmentRuleForTime.DaylightDelta : TimeSpan.Zero);
		}
		return baseUtcOffset;
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone)
	{
		bool isDaylightSavings;
		return GetUtcOffsetFromUtc(time, zone, out isDaylightSavings);
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings)
	{
		isDaylightSavings = false;
		TimeSpan baseUtcOffset = zone.BaseUtcOffset;
		AdjustmentRule adjustmentRuleForTime;
		int year;
		if (time > new DateTime(9999, 12, 31))
		{
			adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(DateTime.MaxValue);
			year = 9999;
		}
		else if (time < new DateTime(1, 1, 2))
		{
			adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(DateTime.MinValue);
			year = 1;
		}
		else
		{
			DateTime dateTime = time + baseUtcOffset;
			year = time.Year;
			adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(dateTime);
		}
		if (adjustmentRuleForTime != null)
		{
			isDaylightSavings = GetIsDaylightSavingsFromUtc(time, year, zone.m_baseUtcOffset, adjustmentRuleForTime);
			baseUtcOffset += (isDaylightSavings ? adjustmentRuleForTime.DaylightDelta : TimeSpan.Zero);
		}
		return baseUtcOffset;
	}

	private static TransitionTime? TransitionTimeFromTimeZoneInformation(NativeMethods.RegistryTimeZoneInformation timeZoneInformation, bool readStartDate)
	{
		if (timeZoneInformation.StandardDate.Month == 0)
		{
			return null;
		}
		return readStartDate ? ((timeZoneInformation.DaylightDate.Year != 0) ? TransitionTime.CreateFixedDateRule(new DateTime(1, 1, 1, timeZoneInformation.DaylightDate.Hour, timeZoneInformation.DaylightDate.Minute, timeZoneInformation.DaylightDate.Second, timeZoneInformation.DaylightDate.Milliseconds), timeZoneInformation.DaylightDate.Month, timeZoneInformation.DaylightDate.Day) : TransitionTime.CreateFloatingDateRule(new DateTime(1, 1, 1, timeZoneInformation.DaylightDate.Hour, timeZoneInformation.DaylightDate.Minute, timeZoneInformation.DaylightDate.Second, timeZoneInformation.DaylightDate.Milliseconds), timeZoneInformation.DaylightDate.Month, timeZoneInformation.DaylightDate.Day, (DayOfWeek)timeZoneInformation.DaylightDate.DayOfWeek)) : ((timeZoneInformation.StandardDate.Year != 0) ? TransitionTime.CreateFixedDateRule(new DateTime(1, 1, 1, timeZoneInformation.StandardDate.Hour, timeZoneInformation.StandardDate.Minute, timeZoneInformation.StandardDate.Second, timeZoneInformation.StandardDate.Milliseconds), timeZoneInformation.StandardDate.Month, timeZoneInformation.StandardDate.Day) : TransitionTime.CreateFloatingDateRule(new DateTime(1, 1, 1, timeZoneInformation.StandardDate.Hour, timeZoneInformation.StandardDate.Minute, timeZoneInformation.StandardDate.Second, timeZoneInformation.StandardDate.Milliseconds), timeZoneInformation.StandardDate.Month, timeZoneInformation.StandardDate.Day, (DayOfWeek)timeZoneInformation.StandardDate.DayOfWeek));
	}

	private static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime)
	{
		DateTime timeOfDay = transitionTime.TimeOfDay;
		DateTime result;
		if (transitionTime.IsFixedDateRule)
		{
			int num = DateTime.DaysInMonth(year, transitionTime.Month);
			result = new DateTime(year, transitionTime.Month, (num < transitionTime.Day) ? num : transitionTime.Day, timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second, timeOfDay.Millisecond);
		}
		else if (transitionTime.Week <= 4)
		{
			result = new DateTime(year, transitionTime.Month, 1, timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second, timeOfDay.Millisecond);
			int dayOfWeek = (int)result.DayOfWeek;
			int num2 = (int)(transitionTime.DayOfWeek - dayOfWeek);
			if (num2 < 0)
			{
				num2 += 7;
			}
			num2 += 7 * (transitionTime.Week - 1);
			if (num2 > 0)
			{
				return result.AddDays(num2);
			}
		}
		else
		{
			int day = DateTime.DaysInMonth(year, transitionTime.Month);
			result = new DateTime(year, transitionTime.Month, day, timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second, timeOfDay.Millisecond);
			int dayOfWeek2 = (int)result.DayOfWeek;
			int num3 = (int)(dayOfWeek2 - transitionTime.DayOfWeek);
			if (num3 < 0)
			{
				num3 += 7;
			}
			if (num3 > 0)
			{
				return result.AddDays(-num3);
			}
		}
		return result;
	}

	private static bool TryCreateAdjustmentRules(string id, NativeMethods.RegistryTimeZoneInformation defaultTimeZoneInformation, out AdjustmentRule[] rules, out Exception e)
	{
		e = null;
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}\\Dynamic DST", new object[2] { "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", id }), RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey);
			if (registryKey == null)
			{
				DateTime minValue = DateTime.MinValue;
				DateTime date = minValue.Date;
				DateTime maxValue = DateTime.MaxValue;
				AdjustmentRule adjustmentRule = CreateAdjustmentRuleFromTimeZoneInformation(defaultTimeZoneInformation, date, maxValue.Date);
				if (adjustmentRule == null)
				{
					rules = null;
				}
				else
				{
					rules = new AdjustmentRule[1];
					rules[0] = adjustmentRule;
				}
				return true;
			}
			int num = (int)registryKey.GetValue("FirstEntry", -1, RegistryValueOptions.None);
			int num2 = (int)registryKey.GetValue("LastEntry", -1, RegistryValueOptions.None);
			if (num == -1 || num2 == -1 || num > num2)
			{
				rules = null;
				return false;
			}
			NativeMethods.RegistryTimeZoneInformation registryTimeZoneInformation = new NativeMethods.RegistryTimeZoneInformation((byte[])registryKey.GetValue(num.ToString(CultureInfo.InvariantCulture), null, RegistryValueOptions.None));
			if (num == num2)
			{
				NativeMethods.RegistryTimeZoneInformation timeZoneInformation = registryTimeZoneInformation;
				DateTime minValue2 = DateTime.MinValue;
				DateTime date2 = minValue2.Date;
				DateTime maxValue2 = DateTime.MaxValue;
				AdjustmentRule adjustmentRule2 = CreateAdjustmentRuleFromTimeZoneInformation(timeZoneInformation, date2, maxValue2.Date);
				if (adjustmentRule2 == null)
				{
					rules = null;
				}
				else
				{
					rules = new AdjustmentRule[1];
					rules[0] = adjustmentRule2;
				}
				return true;
			}
			List<AdjustmentRule> list = new List<AdjustmentRule>(1);
			NativeMethods.RegistryTimeZoneInformation timeZoneInformation2 = registryTimeZoneInformation;
			DateTime minValue3 = DateTime.MinValue;
			AdjustmentRule adjustmentRule3 = CreateAdjustmentRuleFromTimeZoneInformation(timeZoneInformation2, minValue3.Date, new DateTime(num, 12, 31));
			if (adjustmentRule3 != null)
			{
				list.Add(adjustmentRule3);
			}
			for (int i = num + 1; i < num2; i++)
			{
				registryTimeZoneInformation = new NativeMethods.RegistryTimeZoneInformation((byte[])registryKey.GetValue(i.ToString(CultureInfo.InvariantCulture), null, RegistryValueOptions.None));
				AdjustmentRule adjustmentRule4 = CreateAdjustmentRuleFromTimeZoneInformation(registryTimeZoneInformation, new DateTime(i, 1, 1), new DateTime(i, 12, 31));
				if (adjustmentRule4 != null)
				{
					list.Add(adjustmentRule4);
				}
			}
			registryTimeZoneInformation = new NativeMethods.RegistryTimeZoneInformation((byte[])registryKey.GetValue(num2.ToString(CultureInfo.InvariantCulture), null, RegistryValueOptions.None));
			NativeMethods.RegistryTimeZoneInformation timeZoneInformation3 = registryTimeZoneInformation;
			DateTime startDate = new DateTime(num2, 1, 1);
			DateTime maxValue3 = DateTime.MaxValue;
			AdjustmentRule adjustmentRule5 = CreateAdjustmentRuleFromTimeZoneInformation(timeZoneInformation3, startDate, maxValue3.Date);
			if (adjustmentRule5 != null)
			{
				list.Add(adjustmentRule5);
			}
			rules = list.ToArray();
			if (rules != null && rules.Length == 0)
			{
				rules = null;
			}
		}
		catch (InvalidCastException ex)
		{
			rules = null;
			e = ex;
			return false;
		}
		catch (ArgumentOutOfRangeException ex2)
		{
			rules = null;
			e = ex2;
			return false;
		}
		catch (ArgumentException ex3)
		{
			rules = null;
			e = ex3;
			return false;
		}
		return true;
	}

	private static bool TryCompareStandardDate(NativeMethods.TimeZoneInformation timeZone, NativeMethods.RegistryTimeZoneInformation registryTimeZoneInfo)
	{
		if (timeZone.Bias == registryTimeZoneInfo.Bias && timeZone.StandardBias == registryTimeZoneInfo.StandardBias && timeZone.StandardDate.Year == registryTimeZoneInfo.StandardDate.Year && timeZone.StandardDate.Month == registryTimeZoneInfo.StandardDate.Month && timeZone.StandardDate.DayOfWeek == registryTimeZoneInfo.StandardDate.DayOfWeek && timeZone.StandardDate.Day == registryTimeZoneInfo.StandardDate.Day && timeZone.StandardDate.Hour == registryTimeZoneInfo.StandardDate.Hour && timeZone.StandardDate.Minute == registryTimeZoneInfo.StandardDate.Minute && timeZone.StandardDate.Second == registryTimeZoneInfo.StandardDate.Second)
		{
			return timeZone.StandardDate.Milliseconds == registryTimeZoneInfo.StandardDate.Milliseconds;
		}
		return false;
	}

	[SecurityCritical]
	[SecurityTreatAsSafe]
	private static bool TryCompareTimeZoneInformationToRegistry(NativeMethods.TimeZoneInformation timeZone, string id, out bool dstDisabled)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		dstDisabled = false;
		try
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission((IPermission?)new RegistryPermission((RegistryPermissionAccess)1, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones"));
			permissionSet.Assert();
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", new object[2] { "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", id }), RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey);
			if (registryKey == null)
			{
				return false;
			}
			NativeMethods.RegistryTimeZoneInformation registryTimeZoneInfo;
			try
			{
				registryTimeZoneInfo = new NativeMethods.RegistryTimeZoneInformation((byte[])registryKey.GetValue("TZI", null, RegistryValueOptions.None));
			}
			catch (InvalidCastException)
			{
				return false;
			}
			catch (ArgumentException)
			{
				return false;
			}
			bool flag;
			if (!(flag = TryCompareStandardDate(timeZone, registryTimeZoneInfo)))
			{
				return false;
			}
			dstDisabled = CheckDaylightSavingTimeDisabled();
			if (flag = dstDisabled || CheckDaylightSavingTimeNotSupported(timeZone) || (timeZone.DaylightBias == registryTimeZoneInfo.DaylightBias && timeZone.DaylightDate.Year == registryTimeZoneInfo.DaylightDate.Year && timeZone.DaylightDate.Month == registryTimeZoneInfo.DaylightDate.Month && timeZone.DaylightDate.DayOfWeek == registryTimeZoneInfo.DaylightDate.DayOfWeek && timeZone.DaylightDate.Day == registryTimeZoneInfo.DaylightDate.Day && timeZone.DaylightDate.Hour == registryTimeZoneInfo.DaylightDate.Hour && timeZone.DaylightDate.Minute == registryTimeZoneInfo.DaylightDate.Minute && timeZone.DaylightDate.Second == registryTimeZoneInfo.DaylightDate.Second && timeZone.DaylightDate.Milliseconds == registryTimeZoneInfo.DaylightDate.Milliseconds))
			{
				string strA = registryKey.GetValue("Std", string.Empty, RegistryValueOptions.None) as string;
				flag = string.Compare(strA, timeZone.StandardName, StringComparison.Ordinal) == 0;
			}
			return flag;
		}
		finally
		{
			PermissionSet.RevertAssert();
		}
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	private static string TryGetLocalizedNameByMuiNativeResource(string resource)
	{
		if (string.IsNullOrEmpty(resource))
		{
			return string.Empty;
		}
		string[] array = resource.Split(new char[1] { ',' }, StringSplitOptions.None);
		if (array.Length != 2)
		{
			return string.Empty;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = array[0].TrimStart(new char[1] { '@' });
		string filePath;
		try
		{
			filePath = Path.Combine(folderPath, path);
		}
		catch (ArgumentException)
		{
			return string.Empty;
		}
		if (!int.TryParse(array[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return string.Empty;
		}
		result = -result;
		try
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			stringBuilder.Length = 260;
			int fileMuiPathLength = 260;
			int languageLength = 0;
			long enumerator = 0L;
			if (!UnsafeNativeMethods.GetFileMUIPath(16, filePath, null, ref languageLength, stringBuilder, ref fileMuiPathLength, ref enumerator))
			{
				return string.Empty;
			}
			return TryGetLocalizedNameByNativeResource(stringBuilder.ToString(), result);
		}
		catch (EntryPointNotFoundException)
		{
			return string.Empty;
		}
	}

	[SecurityCritical]
	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource)
	{
		if (!File.Exists(filePath))
		{
			return string.Empty;
		}
		using (SafeLibraryHandle safeLibraryHandle = UnsafeNativeMethods.LoadLibraryEx(filePath, IntPtr.Zero, 2))
		{
			if (!safeLibraryHandle.IsInvalid)
			{
				StringBuilder stringBuilder = new StringBuilder(500);
				stringBuilder.Length = 500;
				if (UnsafeNativeMethods.LoadStringW(safeLibraryHandle, resource, stringBuilder, stringBuilder.Length) != 0)
				{
					return stringBuilder.ToString();
				}
			}
		}
		return string.Empty;
	}

	private static bool TryGetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName)
	{
		displayName = string.Empty;
		standardName = string.Empty;
		daylightName = string.Empty;
		string text = key.GetValue("MUI_Display", string.Empty, RegistryValueOptions.None) as string;
		string text2 = key.GetValue("MUI_Std", string.Empty, RegistryValueOptions.None) as string;
		string text3 = key.GetValue("MUI_Dlt", string.Empty, RegistryValueOptions.None) as string;
		if (!string.IsNullOrEmpty(text))
		{
			displayName = TryGetLocalizedNameByMuiNativeResource(text);
		}
		if (!string.IsNullOrEmpty(text2))
		{
			standardName = TryGetLocalizedNameByMuiNativeResource(text2);
		}
		if (!string.IsNullOrEmpty(text3))
		{
			daylightName = TryGetLocalizedNameByMuiNativeResource(text3);
		}
		if (string.IsNullOrEmpty(displayName))
		{
			displayName = key.GetValue("Display", string.Empty, RegistryValueOptions.None) as string;
		}
		if (string.IsNullOrEmpty(standardName))
		{
			standardName = key.GetValue("Std", string.Empty, RegistryValueOptions.None) as string;
		}
		if (string.IsNullOrEmpty(daylightName))
		{
			daylightName = key.GetValue("Dlt", string.Empty, RegistryValueOptions.None) as string;
		}
		return true;
	}

	[SecurityTreatAsSafe]
	[SecurityCritical]
	private static TimeZoneInfoResult TryGetTimeZoneByRegistryKey(string id, out TimeZoneInfo value, out Exception e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		e = null;
		try
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission((IPermission?)new RegistryPermission((RegistryPermissionAccess)1, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones"));
			permissionSet.Assert();
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", new object[2] { "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", id }), RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey);
			if (registryKey == null)
			{
				value = null;
				return TimeZoneInfoResult.TimeZoneNotFoundException;
			}
			NativeMethods.RegistryTimeZoneInformation defaultTimeZoneInformation;
			try
			{
				defaultTimeZoneInformation = new NativeMethods.RegistryTimeZoneInformation((byte[])registryKey.GetValue("TZI", null, RegistryValueOptions.None));
			}
			catch (InvalidCastException ex)
			{
				value = null;
				e = ex;
				return TimeZoneInfoResult.InvalidTimeZoneException;
			}
			catch (ArgumentException ex2)
			{
				value = null;
				e = ex2;
				return TimeZoneInfoResult.InvalidTimeZoneException;
			}
			if (!TryCreateAdjustmentRules(id, defaultTimeZoneInformation, out var rules, out e))
			{
				value = null;
				return TimeZoneInfoResult.InvalidTimeZoneException;
			}
			if (TryGetLocalizedNamesByRegistryKey(registryKey, out var displayName, out var standardName, out var daylightName))
			{
				try
				{
					value = new TimeZoneInfo(id, new TimeSpan(0, -defaultTimeZoneInformation.Bias, 0), displayName, standardName, daylightName, rules, disableDaylightSavingTime: false);
					return TimeZoneInfoResult.Success;
				}
				catch (ArgumentException ex3)
				{
					value = null;
					e = ex3;
					return TimeZoneInfoResult.InvalidTimeZoneException;
				}
				catch (InvalidTimeZoneException ex4)
				{
					value = null;
					e = ex4;
					return TimeZoneInfoResult.InvalidTimeZoneException;
				}
			}
			value = null;
			return TimeZoneInfoResult.InvalidTimeZoneException;
		}
		finally
		{
			PermissionSet.RevertAssert();
		}
	}

	private static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e)
	{
		TimeZoneInfoResult result = TimeZoneInfoResult.Success;
		e = null;
		TimeZoneInfo value2 = null;
		if (s_systemTimeZones.TryGetValue(id, out value2))
		{
			if (dstDisabled && value2.m_supportsDaylightSavingTime)
			{
				value = CreateCustomTimeZone(value2.m_id, value2.m_baseUtcOffset, value2.m_displayName, value2.m_standardDisplayName);
			}
			else
			{
				value = new TimeZoneInfo(value2.m_id, value2.m_baseUtcOffset, value2.m_displayName, value2.m_standardDisplayName, value2.m_daylightDisplayName, value2.m_adjustmentRules, disableDaylightSavingTime: false);
			}
			return result;
		}
		if (!s_allSystemTimeZonesRead)
		{
			result = TryGetTimeZoneByRegistryKey(id, out value2, out e);
			if (result == TimeZoneInfoResult.Success)
			{
				s_systemTimeZones.Add(id, value2);
				if (dstDisabled && value2.m_supportsDaylightSavingTime)
				{
					value = CreateCustomTimeZone(value2.m_id, value2.m_baseUtcOffset, value2.m_displayName, value2.m_standardDisplayName);
				}
				else
				{
					value = new TimeZoneInfo(value2.m_id, value2.m_baseUtcOffset, value2.m_displayName, value2.m_standardDisplayName, value2.m_daylightDisplayName, value2.m_adjustmentRules, disableDaylightSavingTime: false);
				}
			}
			else
			{
				value = null;
			}
		}
		else
		{
			result = TimeZoneInfoResult.TimeZoneNotFoundException;
			value = null;
		}
		return result;
	}

	internal static bool UtcOffsetOutOfRange(TimeSpan offset)
	{
		if (!(offset.TotalHours < -14.0))
		{
			return offset.TotalHours > 14.0;
		}
		return true;
	}

	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst)
	{
		adjustmentRulesSupportDst = false;
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (id.Length == 0)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidId", id), "id");
		}
		if (UtcOffsetOutOfRange(baseUtcOffset))
		{
			throw new ArgumentOutOfRangeException("baseUtcOffset", SR.GetString("ArgumentOutOfRange_UtcOffset"));
		}
		if (baseUtcOffset.Ticks % 600000000L != 0L)
		{
			throw new ArgumentException(SR.GetString("Argument_TimeSpanHasSeconds"), "baseUtcOffset");
		}
		if (adjustmentRules == null || adjustmentRules.Length == 0)
		{
			return;
		}
		adjustmentRulesSupportDst = true;
		AdjustmentRule adjustmentRule = null;
		AdjustmentRule adjustmentRule2 = null;
		int num = 0;
		while (true)
		{
			if (num < adjustmentRules.Length)
			{
				adjustmentRule = adjustmentRule2;
				adjustmentRule2 = adjustmentRules[num];
				if (adjustmentRule2 != null)
				{
					if (!UtcOffsetOutOfRange(baseUtcOffset + adjustmentRule2.DaylightDelta))
					{
						if (adjustmentRule != null && adjustmentRule2.DateStart <= adjustmentRule.DateEnd)
						{
							break;
						}
						num++;
						continue;
					}
					throw new InvalidTimeZoneException(SR.GetString("ArgumentOutOfRange_UtcOffsetAndDaylightDelta"));
				}
				throw new InvalidTimeZoneException(SR.GetString("Argument_AdjustmentRulesNoNulls"));
			}
			return;
		}
		throw new InvalidTimeZoneException(SR.GetString("Argument_AdjustmentRulesOutOfOrder"));
	}
}
