using System;
using System.Diagnostics.CodeAnalysis;
using Core2.Selkie.Common.Interfaces;
using Core2.Selkie.Windsor;

namespace Core2.Selkie.Common
{
    [ProjectComponent(Lifestyle.Transient)]
    [ExcludeFromCodeCoverage]
    public class SelkieConsole : ISelkieConsole
    {
        public void WriteLine(string format,
                              params object[] args)
        {
            string text = string.Format(format,
                                        args);

            WriteLine(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public string ReadLine()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            return Console.ReadLine();
        }
    }
}