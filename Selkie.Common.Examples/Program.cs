﻿using System;
using System.Diagnostics.CodeAnalysis;

// ReSharper disable UnusedVariable

namespace Selkie.Common.Examples
{
    [ExcludeFromCodeCoverage]
    internal class Program
    {
        private static void Main()
        {
            var timerExample = new SelkieTimerExample();
            var randomExample = new SelkieRandomExample();
            var dateTimeExample = new SelkieDateTimeExample();
            var consoleExample = new SelkieConsoleExample();
            var disposerExample = new DisposerExample();
            var environmentExample = new SelkieEnvironmentExample();
            disposerExample.Dispose();

            Console.ReadLine();
        }
    }
}