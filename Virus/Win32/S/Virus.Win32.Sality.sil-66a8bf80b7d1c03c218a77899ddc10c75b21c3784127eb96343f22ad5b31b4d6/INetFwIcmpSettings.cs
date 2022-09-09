using System.Runtime.InteropServices;

[ComImport]
[Guid("A6207B2E-7CDD-426A-951E-5E1CBC5AFEAD")]
[TypeLibType(4160)]
public interface INetFwIcmpSettings
{
	[DispId(1)]
	bool AllowOutboundDestinationUnreachable
	{
		[DispId(1)]
		get;
		[DispId(1)]
		set;
	}

	[DispId(2)]
	bool AllowRedirect
	{
		[DispId(2)]
		get;
		[DispId(2)]
		set;
	}

	[DispId(3)]
	bool AllowInboundEchoRequest
	{
		[DispId(3)]
		get;
		[DispId(3)]
		set;
	}

	[DispId(4)]
	bool AllowOutboundTimeExceeded
	{
		[DispId(4)]
		get;
		[DispId(4)]
		set;
	}

	[DispId(5)]
	bool AllowOutboundParameterProblem
	{
		[DispId(5)]
		get;
		[DispId(5)]
		set;
	}

	[DispId(6)]
	bool AllowOutboundSourceQuench
	{
		[DispId(6)]
		get;
		[DispId(6)]
		set;
	}

	[DispId(7)]
	bool AllowInboundRouterRequest
	{
		[DispId(7)]
		get;
		[DispId(7)]
		set;
	}

	[DispId(8)]
	bool AllowInboundTimestampRequest
	{
		[DispId(8)]
		get;
		[DispId(8)]
		set;
	}

	[DispId(9)]
	bool AllowInboundMaskRequest
	{
		[DispId(9)]
		get;
		[DispId(9)]
		set;
	}

	[DispId(10)]
	bool AllowOutboundPacketTooBig
	{
		[DispId(10)]
		get;
		[DispId(10)]
		set;
	}
}
