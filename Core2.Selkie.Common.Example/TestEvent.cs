using System;
using System.Diagnostics.CodeAnalysis;

namespace Core2.Selkie.Common.Example
{
    [ExcludeFromCodeCoverage]
    internal class TestEvent
    {
#pragma warning disable 67
        public event EventHandler SomeEvent;
#pragma warning restore 67
    }
}