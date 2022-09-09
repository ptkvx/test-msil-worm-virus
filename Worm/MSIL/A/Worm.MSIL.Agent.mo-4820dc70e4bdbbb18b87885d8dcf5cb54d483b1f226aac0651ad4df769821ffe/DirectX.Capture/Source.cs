using System;

namespace DirectX.Capture;

public class Source : IDisposable
{
	protected string name;

	public string Name => name;

	public virtual bool Enabled
	{
		get
		{
			throw new NotSupportedException("This method should be overriden in derrived classes.");
		}
		set
		{
			throw new NotSupportedException("This method should be overriden in derrived classes.");
		}
	}

	public override string ToString()
	{
		return Name;
	}

	~Source()
	{
		Dispose();
	}

	public virtual void Dispose()
	{
		name = null;
	}
}
