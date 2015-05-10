using System;
using Selkie.Windsor;

namespace Selkie.Common
{
    [ProjectComponent(Lifestyle.Transient)]
    public class SelkieRandom : IRandom
    {
        private readonly Random m_Random = new Random(0);

        public double NextDouble()
        {
            return m_Random.NextDouble();
        }

        public int Next(int minValue,
                        int maxValue)
        {
            return m_Random.Next(minValue,
                                 maxValue);
        }
    }
}