using JetBrains.Annotations;

namespace Selkie.Common.Interfaces
{
    public interface ITimerFactory
    {
        [NotNull]
        ITimer Create();

        void Release([NotNull] ITimer timer);
    }
}