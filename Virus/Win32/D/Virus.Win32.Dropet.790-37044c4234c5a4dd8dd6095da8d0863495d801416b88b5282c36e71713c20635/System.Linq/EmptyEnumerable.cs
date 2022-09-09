using System.Collections.Generic;

namespace System.Linq;

internal class EmptyEnumerable<TElement>
{
	private static TElement[] instance;

	public static IEnumerable<TElement> Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new TElement[0];
			}
			return instance;
		}
	}
}
