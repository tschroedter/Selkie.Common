using System;
using System.Diagnostics.CodeAnalysis;

namespace Selkie.Common.Examples
{
    [ExcludeFromCodeCoverage]
    public sealed class SelkieDateTimeExample
    {
        public SelkieDateTimeExample()
        {
            var dateTime = new SelkieDateTime();

            Console.WriteLine("DateTime.Now = {0}",
                              dateTime.Now);
        }
    }
}