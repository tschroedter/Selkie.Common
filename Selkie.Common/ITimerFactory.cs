using JetBrains.Annotations;

namespace Selkie.Common
{
    public interface ITimerFactory
    {
        [NotNull]
        ITimer Create();

        void Release([NotNull] ITimer timer);
    }
}