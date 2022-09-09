using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.MediaCenter.TV.Tuners;

public interface ITunerCollection : IDisposable, ICollection<Tuner>, ICollection, ICloneable
{
}
