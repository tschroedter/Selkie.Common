using System;
using System.Diagnostics.CodeAnalysis;

namespace Core2.Selkie.Common.Example
{
    [ExcludeFromCodeCoverage]
    public sealed class DisposerExample : IDisposable
    {
        public DisposerExample()
        {
            m_Disposer = new Disposer();

            var test = new TestEvent();
            test.SomeEvent += SomeEventHandler;
            m_Disposer.AddResource(() => test.SomeEvent -= SomeEventHandler);
            m_Disposer.AddResource(ShowMessage);
        }

        private readonly Disposer m_Disposer;

        public void Dispose()
        {
            m_Disposer.Dispose();
        }

        private void ShowMessage()
        {
            Console.WriteLine("Disposer called me!");
        }

        private void SomeEventHandler(object sender,
                                      EventArgs e)
        {
        }
    }
}