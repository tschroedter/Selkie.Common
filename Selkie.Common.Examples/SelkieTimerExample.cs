using System;
using System.Diagnostics.CodeAnalysis;

namespace Selkie.Common.Examples
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public sealed class SelkieTimerExample : IDisposable
    {
        private readonly int m_DueTimeInMs = 5000;
        private readonly int m_PeriodTimeInMs = 2000;
        private readonly SelkieTimer m_Timer;
        private int m_Counter;

        public SelkieTimerExample()
        {
            m_Timer = new SelkieTimer();

            m_Timer.Initialize(OnTimmer,
                               m_DueTimeInMs,
                               m_PeriodTimeInMs);
        }

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