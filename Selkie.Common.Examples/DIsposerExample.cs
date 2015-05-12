using System;
using System.Diagnostics.CodeAnalysis;

namespace Selkie.Common.Examples
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public sealed class DisposerExample : IDisposable
    {
        private readonly Disposer m_Disposer;

        public DisposerExample()
        {
            m_Disposer = new Disposer();

            var test = new TestEvent();
            test.SomeEvent += SomeEventHandler;
            m_Disposer.AddResource(() => test.SomeEvent -= SomeEventHandler);
            m_Disposer.AddResource(ShowMessage);
        }

        public void Dispose()
        {
            m_Disposer.Dispose();
        }

        public void ShowMessage()
        {
            Console.WriteLine("Disposer called me!");
        }

        private void SomeEventHandler(object sender,
                                      EventArgs e)
        {
        }
    }
}