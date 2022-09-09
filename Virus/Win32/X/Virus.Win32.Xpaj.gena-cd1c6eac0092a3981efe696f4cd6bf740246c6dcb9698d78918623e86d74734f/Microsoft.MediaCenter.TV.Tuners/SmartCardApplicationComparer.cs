using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.MediaCenter.TV.Tuners;

public class SmartCardApplicationComparer : IComparer<SmartCardApplication>, IComparer
{
	public virtual int Compare_Generic(SmartCardApplication lhs, SmartCardApplication rhs)
	{
		if (lhs != null && rhs != null)
		{
			return string.Compare(lhs.Name, rhs.Name, StringComparison.CurrentCultureIgnoreCase);
		}
		if (lhs == rhs)
		{
			return 0;
		}
		int num = -1;
		if (lhs != null)
		{
			num = -num;
		}
		return num;
	}

	int IComparer<SmartCardApplication>.Compare(SmartCardApplication lhs, SmartCardApplication rhs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Compare_Generic
		return this.Compare_Generic(lhs, rhs);
	}

	public virtual int Compare_Collections(object lhs, object rhs)
	{
		return Compare_Generic((SmartCardApplication)lhs, (SmartCardApplication)rhs);
	}

	int IComparer.Compare(object lhs, object rhs)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Compare_Collections
		return this.Compare_Collections(lhs, rhs);
	}
}
