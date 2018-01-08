namespace Core2.Selkie.Common.Interfaces
{
    public interface ISelkieEnvironment
    {
        string CurrentDirectory { get; }
        void Exit(int exitCode);
    }
}