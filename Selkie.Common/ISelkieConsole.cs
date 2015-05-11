using JetBrains.Annotations;

namespace Selkie.Common
{
    public interface ISelkieConsole
    {
        void WriteLine([NotNull] string text);

        [CanBeNull]
        string ReadLine();

        void WriteLine(string format, params object[] args);
    }
}