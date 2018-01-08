using JetBrains.Annotations;

namespace Core2.Selkie.Common.Interfaces
{
    public interface ISelkieConsole
    {
        [CanBeNull]
        string ReadLine();

        void WriteLine([NotNull] string text);

        void WriteLine(string format,
                       params object[] args);
    }
}