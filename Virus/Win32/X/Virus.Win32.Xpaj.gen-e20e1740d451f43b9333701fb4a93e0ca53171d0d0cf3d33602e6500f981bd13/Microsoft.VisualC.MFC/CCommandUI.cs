using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ATL;

namespace Microsoft.VisualC.MFC;

public class CCommandUI : ICommandUI
{
	private unsafe CCmdUI* m_CmdUI;

	public unsafe virtual uint Index => *(uint*)((byte*)m_CmdUI + 8);

	public unsafe virtual uint ID => *(uint*)((byte*)m_CmdUI + 4);

	public unsafe virtual string Text
	{
		set
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Struct1 @struct);
			Struct1* pStruct5_ = _003CModule_003E.smethod_15(&@struct, value);
			try
			{
				int num = *(int*)m_CmdUI + 12;
				CCmdUI* cmdUI = m_CmdUI;
				char* intPtr = _003CModule_003E.smethod_43((Struct5*)pStruct5_);
				((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, char*, void>)(int)(*(uint*)num))((nint)cmdUI, intPtr);
			}
			catch
			{
				//try-fault
				_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Struct1*, void>)(&_003CModule_003E.smethod_42), &@struct);
				throw;
			}
			_003CModule_003E.smethod_42(&@struct);
		}
	}

	public unsafe virtual bool Radio
	{
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			CCmdUI* cmdUI = m_CmdUI;
			((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, int, void>)(int)(*(uint*)(*(int*)cmdUI + 8)))((nint)cmdUI, value ? 1 : 0);
		}
	}

	public unsafe virtual UICheckState Check
	{
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected I4, but got Unknown
			CCmdUI* cmdUI = m_CmdUI;
			((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, int, void>)(int)(*(uint*)(*(int*)cmdUI + 4)))((nint)cmdUI, (int)value);
		}
	}

	public unsafe virtual bool Enabled
	{
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			CCmdUI* cmdUI = m_CmdUI;
			((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, int, void>)(int)(*(uint*)(int)(*(uint*)cmdUI)))((nint)cmdUI, value ? 1 : 0);
		}
	}

	public unsafe CCommandUI(CCmdUI* CmdUI)
	{
		m_CmdUI = CmdUI;
		base._002Ector();
	}

	public unsafe virtual void ContinueRouting()
	{
		*(int*)((byte*)m_CmdUI + 28) = 1;
	}
}
