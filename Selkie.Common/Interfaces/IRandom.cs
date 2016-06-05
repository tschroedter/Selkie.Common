namespace Selkie.Common.Interfaces
{
    public interface IRandom
    {
        int Next(int minValue,
                 int maxValue);

        double NextDouble();
    }
}