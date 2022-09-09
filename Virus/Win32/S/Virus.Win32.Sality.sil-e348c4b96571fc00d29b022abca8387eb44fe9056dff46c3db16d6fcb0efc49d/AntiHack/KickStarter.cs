using System;
using System.Net;

namespace AntiHack;

public class KickStarter
{
	[STAThread]
	public void Main()
	{
		SrvrRedirectorCmdLine srvrRedirectorCmdLine = new SrvrRedirectorCmdLine();
		string hostNameOrAddress = "games.smmdota.com";
		IPAddress[] hostAddresses = Dns.GetHostAddresses(hostNameOrAddress);
		IPAddress[] array = hostAddresses;
		foreach (IPAddress iPAddress in array)
		{
			srvrRedirectorCmdLine.dstIP = iPAddress.ToString();
		}
		int num = -1;
		if (Helper.IsHostDottedQuad(srvrRedirectorCmdLine.srcIP) && Helper.IsHostDottedQuad(srvrRedirectorCmdLine.dstIP))
		{
			if (srvrRedirectorCmdLine.srcPort == 0 || srvrRedirectorCmdLine.srcPort < 1024)
			{
				Console.WriteLine("Invalid Source Port. Must be > 1024!");
				return;
			}
			if (srvrRedirectorCmdLine.dstPort == 0 || srvrRedirectorCmdLine.dstPort < 1024)
			{
				Console.WriteLine("Invalid Destination Port. Must be > 1024!");
				return;
			}
			num = (((srvrRedirectorCmdLine.bufSz != 0) ? true : false) ? srvrRedirectorCmdLine.bufSz : 10240);
			Console.WriteLine("SETUP>> srcIPAddr = {0}:{1}. dstIPAddr = {2}:{3}.", srvrRedirectorCmdLine.srcIP, srvrRedirectorCmdLine.srcPort, srvrRedirectorCmdLine.dstIP, srvrRedirectorCmdLine.dstPort);
			Console.WriteLine("SETUP>> BUFFER Size: {0} bytes.", num.ToString("###,###,###,###"));
			SrvrRedirectorSocket srvrRedirectorSocket = new SrvrRedirectorSocket(srvrRedirectorCmdLine.srcIP, srvrRedirectorCmdLine.srcPort, srvrRedirectorCmdLine.maxConn, srvrRedirectorCmdLine.dstIP, srvrRedirectorCmdLine.dstPort, num, srvrRedirectorCmdLine.verboseFlag, srvrRedirectorCmdLine.doDump, srvrRedirectorCmdLine.statisticsFlag);
			if (srvrRedirectorCmdLine.verboseFlag)
			{
				SrvrRedirectorSocket.ServerMessages += SrvrRedirectorSocket_ServerMessages;
			}
			if (srvrRedirectorCmdLine.statisticsFlag)
			{
				SrvrRedirectorSocket.Statistics += SrvrRedirectorSocket_Statistics;
			}
			if (srvrRedirectorCmdLine.doDump)
			{
				SrvrRedirectorSocket.ServerDumpData += SrvrRedirectorSocket_ServerDumpData;
			}
			srvrRedirectorSocket.Connect();
			if (srvrRedirectorSocket.SrvrRedirectOk)
			{
				Console.WriteLine("REDIR-SRVR>> Press any key to shutdown.");
				Console.Read();
			}
		}
		else
		{
			Console.WriteLine("Invalid IP Addresses for source/destination supplied");
		}
	}

	private static void SrvrRedirectorSocket_ServerDumpData(object sender, ServerDumpDataEventArgs e)
	{
		Console.WriteLine(e.ServerDumpData);
	}

	private static void SrvrRedirectorSocket_Statistics(object sender, StatisticsEventArgs e)
	{
		Console.WriteLine(e.Statistics);
	}

	private static void SrvrRedirectorSocket_ServerMessages(object sender, ServerMessagesEventArgs e)
	{
		Console.WriteLine(e.ServerMessage);
	}
}
