using JetBrains.Annotations;

namespace Core2.Selkie.Common.Interfaces
{
    public interface ITimerFactory
    {
        [NotNull]
        ITimer Create();

        void Release([NotNull] ITimer timer);
    }
}