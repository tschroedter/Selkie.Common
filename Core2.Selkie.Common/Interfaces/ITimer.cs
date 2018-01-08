using System.Threading;
using JetBrains.Annotations;

namespace Core2.Selkie.Common.Interfaces
{
    public interface ITimer
    {
        void Initialize([NotNull] TimerCallback callback,
                        int dueTimeInMs,
                        int periodInMs);
    }
}