using System;
using System.Diagnostics.CodeAnalysis;

namespace Core2.Selkie.Common.Example
{
    [ExcludeFromCodeCoverage]
    public sealed class SelkieEnvironmentExample
    {
        public SelkieEnvironmentExample()
        {
            var environment = new SelkieEnvironment();

            Console.WriteLine("SelkieEnvironment.CurrentDirectory = {0}",
                              environment.CurrentDirectory);
        }
    }
}