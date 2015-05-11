using System.Diagnostics.CodeAnalysis;

namespace Selkie.Common.Examples
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public sealed class SelkieConsoleExample
    {
        public SelkieConsoleExample()
        {
            var console = new SelkieConsole();

            console.WriteLine("Hello World!");
            console.WriteLine("Hello {0} {1}",
                              "World!",
                              "(second time)");
        }
    }
}