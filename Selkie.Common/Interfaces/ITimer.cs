using System.Threading;
using JetBrains.Annotations;

namespace Selkie.Common.Interfaces
{
    public interface ITimer
    {
        void Initialize([NotNull] TimerCallback callback,
                        int dueTimeInMs,
                        int periodInMs);
    }
}