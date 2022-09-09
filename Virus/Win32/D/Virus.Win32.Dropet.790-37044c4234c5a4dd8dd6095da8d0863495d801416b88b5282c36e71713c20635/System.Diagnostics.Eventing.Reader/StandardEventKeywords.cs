namespace System.Diagnostics.Eventing.Reader;

[Flags]
public enum StandardEventKeywords : long
{
	None = 0L,
	WdiContext = 0x2000000000000L,
	WdiDiagnostic = 0x4000000000000L,
	Sqm = 0x8000000000000L,
	AuditFailure = 0x10000000000000L,
	AuditSuccess = 0x20000000000000L,
	CorrelationHint = 0x10000000000000L,
	EventLogClassic = 0x80000000000000L
}
