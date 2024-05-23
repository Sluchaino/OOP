using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1OOPNumber2
{
    public class PrefDecorator : DateTimeDecorator
    {
        string pref;
        public PrefDecorator(IDateTimePrinter innerDateTimePrinter, string _pref) : base(innerDateTimePrinter) { pref = _pref; }

        public override string PrintDateTime()
        {
            StringBuilder sb = new();
            sb.Append(_innerDateTimePrinter.PrintDateTime());
            sb.Insert(0, pref);
            return sb.ToString();
        }
    }
}
