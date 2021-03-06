﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Selkie.Common.Examples
{
    [ExcludeFromCodeCoverage]
    public sealed class SelkieRandomExample
    {
        public SelkieRandomExample()
        {
            var random = new SelkieRandom();

            for ( var i = 0 ; i < 10 ; i++ )
            {
                int number = random.Next(1,
                                         10);

                Console.WriteLine("Random numer {0}...",
                                  number);
            }
        }
    }
}