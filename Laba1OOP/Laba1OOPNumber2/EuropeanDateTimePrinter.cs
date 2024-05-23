using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1OOPNumber2
{
    public class EuropeanDateTimePrinter : IDateTimePrinter
    {
        public string PrintDateTime()
        {
            DateTime now = DateTime.Now;
            return now.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR"));
        }
    }
}
