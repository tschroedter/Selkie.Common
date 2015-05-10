using System;
using Selkie.Windsor;

namespace Selkie.Common
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