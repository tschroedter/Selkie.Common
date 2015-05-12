using System;
using System.Diagnostics.CodeAnalysis;

namespace Selkie.Common.Examples
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    internal class TestEvent
    {
#pragma warning disable 67
        public event EventHandler SomeEvent;
#pragma warning restore 67
    }
}