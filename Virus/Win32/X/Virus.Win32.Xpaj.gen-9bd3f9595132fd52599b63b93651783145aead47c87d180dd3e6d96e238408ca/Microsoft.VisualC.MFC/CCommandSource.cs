using System;
using System.Collections;

namespace Microsoft.VisualC.MFC;

public class CCommandSource : ICommandSource
{
	private class Range
	{
		public uint m_min;

		public uint m_max;

		public MulticastDelegate m_pHandler;

		public Range(uint min, uint max, MulticastDelegate pHandler)
		{
			m_min = min;
			m_max = max;
			m_pHandler = pHandler;
			base._002Ector();
		}
	}

	private ArrayList m_alCmd;

	private ArrayList m_alCmdUI;

	private static MulticastDelegate FindHandler(ArrayList al, uint nID)
	{
		int num = 0;
		IEnumerator enumerator = al.GetEnumerator();
		if (enumerator.MoveNext())
		{
			do
			{
				Range range = (Range)enumerator.Current;
				if (range.m_min > nID || range.m_max < nID)
				{
					num++;
					continue;
				}
				return ((Range)al[num]).m_pHandler;
			}
			while (enumerator.MoveNext());
		}
		return null;
	}

	public CCommandSource()
	{
		m_alCmd = new ArrayList();
		m_alCmdUI = new ArrayList();
	}

	public virtual void AddCommandHandler(uint cmdID, CommandHandler cmdHandler)
	{
		if (!((MulticastDelegate?)(object)cmdHandler != null))
		{
			_003CModule_003E.AfxThrowInvalidArgException();
		}
		m_alCmd.Add(new Range(cmdID, cmdID, (MulticastDelegate)(object)cmdHandler));
	}

	public virtual void AddCommandRangeHandler(uint cmdIDMin, uint cmdIDMax, CommandHandler cmdHandler)
	{
		if (!((MulticastDelegate?)(object)cmdHandler != null))
		{
			_003CModule_003E.AfxThrowInvalidArgException();
		}
		m_alCmd.Add(new Range(cmdIDMin, cmdIDMax, (MulticastDelegate)(object)cmdHandler));
	}

	public virtual void RemoveCommandHandler(uint cmdID)
	{
		int num = 0;
		IEnumerator enumerator = m_alCmd.GetEnumerator();
		if (enumerator.MoveNext())
		{
			while (((Range)enumerator.Current).m_min != cmdID)
			{
				num++;
				if (!enumerator.MoveNext())
				{
					break;
				}
			}
		}
		m_alCmd.RemoveAt(num);
	}

	public virtual void RemoveCommandRangeHandler(uint cmdIDMin, uint cmdIDMax)
	{
		int num = 0;
		IEnumerator enumerator = m_alCmd.GetEnumerator();
		if (enumerator.MoveNext())
		{
			do
			{
				Range range = (Range)enumerator.Current;
				if (range.m_min == cmdIDMin && range.m_max == cmdIDMax)
				{
					break;
				}
				num++;
			}
			while (enumerator.MoveNext());
		}
		m_alCmd.RemoveAt(num);
	}

	public CommandHandler FindCommandHandler(uint nID)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (CommandHandler)FindHandler(m_alCmd, nID);
	}

	public virtual void AddCommandUIHandler(uint cmdID, CommandUIHandler cmdUIHandler)
	{
		if (!((MulticastDelegate?)(object)cmdUIHandler != null))
		{
			_003CModule_003E.AfxThrowInvalidArgException();
		}
		m_alCmdUI.Add(new Range(cmdID, cmdID, (MulticastDelegate)(object)cmdUIHandler));
	}

	public virtual void AddCommandRangeUIHandler(uint cmdIDMin, uint cmdIDMax, CommandUIHandler cmdUIHandler)
	{
		if (!((MulticastDelegate?)(object)cmdUIHandler != null))
		{
			_003CModule_003E.AfxThrowInvalidArgException();
		}
		m_alCmdUI.Add(new Range(cmdIDMin, cmdIDMax, (MulticastDelegate)(object)cmdUIHandler));
	}

	public virtual void RemoveCommandUIHandler(uint cmdID)
	{
		int num = 0;
		IEnumerator enumerator = m_alCmdUI.GetEnumerator();
		if (enumerator.MoveNext())
		{
			while (((Range)enumerator.Current).m_min != cmdID)
			{
				num++;
				if (!enumerator.MoveNext())
				{
					break;
				}
			}
		}
		m_alCmdUI.RemoveAt(num);
	}

	public virtual void RemoveCommandRangeUIHandler(uint cmdIDMin, uint cmdIDMax)
	{
		int num = 0;
		IEnumerator enumerator = m_alCmdUI.GetEnumerator();
		if (enumerator.MoveNext())
		{
			do
			{
				Range range = (Range)enumerator.Current;
				if (range.m_min == cmdIDMin && range.m_max == cmdIDMax)
				{
					break;
				}
				num++;
			}
			while (enumerator.MoveNext());
		}
		m_alCmdUI.RemoveAt(num);
	}

	public CommandUIHandler FindCommandUIHandler(uint nID)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return (CommandUIHandler)FindHandler(m_alCmdUI, nID);
	}

	public unsafe virtual void PostCommand(uint command)
	{
		_003CModule_003E.PostMessageW((HWND__*)(int)(*(uint*)((byte*)_003CModule_003E.AfxGetMainWnd() + 32)), 273u, command, 0);
	}

	public unsafe virtual void SendCommand(uint command)
	{
		_003CModule_003E.SendMessageW((HWND__*)(int)(*(uint*)((byte*)_003CModule_003E.AfxGetMainWnd() + 32)), 273u, command, 0);
	}
}
