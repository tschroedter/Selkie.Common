using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Selkie.Windsor;

namespace Selkie.Common
{
    [ProjectComponent(Lifestyle.Transient)]
    public sealed class SelkieTimer : ITimer,
                                      IDisposable
    {
        private readonly Disposer m_Disposer;
        private Timer m_Timer;

        public SelkieTimer()
        {
            m_Disposer = new Disposer();
        }

        [SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "m_Timer")]
        public void Dispose()
        {
            m_Disposer.Dispose();
        }

        public void Initialize(TimerCallback callback,
                               int dueTime,
                               int period)

        {
            AutoResetEvent autoEvent = new AutoResetEvent(false);

            m_Timer = new Timer(callback,
                                autoEvent,
                                dueTime,
                                period);
            m_Disposer.AddResource(() => m_Timer.Dispose());
        }
    }
}