using System;
using System.Diagnostics.CodeAnalysis;

// ReSharper disable UnusedVariable
namespace Selkie.Common.Examples
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    class Program
    {
        static void Main()
        {
            var timerExample = new SelkieTimerExample();
            var randomExample = new SelkieRandomExample();
            var dateTimeExample = new SelkieDateTimeExample();
            var consoleExample = new SelkieConsoleExample();
            var disposerExample = new DisposerExample();
            disposerExample.Dispose();

            Console.ReadLine();
        }
    }
}
