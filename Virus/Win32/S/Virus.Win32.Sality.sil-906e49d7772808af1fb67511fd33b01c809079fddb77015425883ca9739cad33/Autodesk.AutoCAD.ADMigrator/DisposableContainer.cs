using System;
using System.Collections.Generic;

namespace Autodesk.AutoCAD.ADMigrator;

internal class DisposableContainer : IDisposable
{
	private IList<IDisposable> m_objectList = new List<IDisposable>();

	internal void AddDisposableObject(IDisposable disposable)
	{
		if (disposable != null && !m_objectList.Contains(disposable))
		{
			m_objectList.Add(disposable);
		}
	}

	public void Dispose()
	{
		foreach (IDisposable @object in m_objectList)
		{
			@object.Dispose();
		}
		m_objectList.Clear();
	}
}
