namespace Selkie.Common.Interfaces
{
    public interface ISelkieEnvironment
    {
        string CurrentDirectory { get; }
        void Exit(int exitCode);
    }
}