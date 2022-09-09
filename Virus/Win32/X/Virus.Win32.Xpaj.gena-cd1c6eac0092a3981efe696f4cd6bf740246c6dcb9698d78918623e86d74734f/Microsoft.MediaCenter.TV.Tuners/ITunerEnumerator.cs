using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.MediaCenter.TV.Tuners;

public interface ITunerEnumerator : IDisposable, IEnumerator<Tuner>, IEnumerator
{
}
