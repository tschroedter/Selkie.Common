using System.Threading;
using JetBrains.Annotations;

namespace Selkie.Common
{
    public interface ITimer
    {
        void Initialize([NotNull] TimerCallback callback,
                        int dueTimeInMs,
                        int periodInMs);
    }
}