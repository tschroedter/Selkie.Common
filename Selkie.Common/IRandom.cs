namespace Selkie.Common
{
    public interface IRandom
    {
        double NextDouble();

        int Next(int minValue,
                 int maxValue);
    }
}