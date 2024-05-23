using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1OOPNumber2
{
    public abstract class DateTimeDecorator : IDateTimePrinter
    {
        protected IDateTimePrinter _innerDateTimePrinter;
        
        public DateTimeDecorator(IDateTimePrinter innerDateTimePrinter)
        {
            _innerDateTimePrinter = innerDateTimePrinter;
        }

        public abstract string PrintDateTime();
    }

}
