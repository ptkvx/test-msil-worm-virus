namespace System.Threading;

internal class ReaderWriterCount
{
	public int threadid;

	public int readercount;

	public ReaderWriterCount next;

	public RecursiveCounts rc;

	public ReaderWriterCount(bool fIsReentrant)
	{
		threadid = -1;
		if (fIsReentrant)
		{
			rc = new RecursiveCounts();
		}
	}
}
