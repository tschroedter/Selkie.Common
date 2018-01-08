using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Core2.Selkie.Common.Interfaces;
using Core2.Selkie.Windsor;

namespace Core2.Selkie.Common
{
    [ProjectComponent(Lifestyle.Transient)]
    public sealed class SelkieTimer
        : ITimer,
          IDisposable
    {
        public SelkieTimer()
        {
            m_Disposer = new Disposer();
        }

        private readonly Disposer m_Disposer;
        private Timer m_Timer;

        [SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "m_Timer")]
        public void Dispose()
        {
            m_Disposer.Dispose();
        }

        public void Initialize(TimerCallback callback,
                               int dueTimeInMs,
                               int periodInMs)

        {
            var autoEvent = new AutoResetEvent(false);

            m_Timer = new Timer(callback,
                                autoEvent,
                                dueTimeInMs,
                                periodInMs);

            m_Disposer.AddResource(() => m_Timer.Dispose());
        }
    }
}