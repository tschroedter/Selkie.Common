namespace Core2.Selkie.Common.Interfaces
{
    public interface IRandom
    {
        int Next(int minValue,
                 int maxValue);

        double NextDouble();
    }
}