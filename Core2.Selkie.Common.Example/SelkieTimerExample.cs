using System;
using System.Diagnostics.CodeAnalysis;

namespace Core2.Selkie.Common.Example
{
    [ExcludeFromCodeCoverage]
    public sealed class SelkieTimerExample : IDisposable
    {
        public SelkieTimerExample()
        {
            m_Timer = new SelkieTimer();

            m_Timer.Initialize(OnTimmer,
                               DueTimeInMs,
                               PeriodTimeInMs);
        }

        private const int DueTimeInMs = 5000;
        private const int PeriodTimeInMs = 2000;
        private readonly SelkieTimer m_Timer;
        private int m_Counter;

        public void Dispose()
        {
            m_Timer.Dispose();
        }

        private void OnTimmer(object state)
        {
            m_Counter++;

            Console.WriteLine("OnTimer called {0} x times...",
                              m_Counter);
        }
    }
}