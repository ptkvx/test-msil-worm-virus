using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

public interface IOrderedQueryable : IEnumerable, IQueryable
{
}
public interface IOrderedQueryable<T> : IEnumerable<T>, IQueryable<T>, IEnumerable, IQueryable, IOrderedQueryable
{
}
