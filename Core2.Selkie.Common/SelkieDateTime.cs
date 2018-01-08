using System;
using Core2.Selkie.Common.Interfaces;
using Core2.Selkie.Windsor;

namespace Core2.Selkie.Common
{
    [ProjectComponent(Lifestyle.Transient)]
    public class SelkieDateTime : IDateTime
    {
        public static Func <DateTime> DateProvider = () => DateTime.Now;

        public DateTime Now
        {
            get
            {
                return DateProvider();
            }
        }
    }
}