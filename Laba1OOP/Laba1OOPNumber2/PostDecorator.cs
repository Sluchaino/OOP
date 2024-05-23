using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1OOPNumber2
{
    public class PostDecorator : DateTimeDecorator
    {
        string post;
        public PostDecorator(IDateTimePrinter innerDateTimePrinter, string _post) : base(innerDateTimePrinter) { post = _post; }

        public override string PrintDateTime()
        {
            StringBuilder sb = new();
            sb.Append(_innerDateTimePrinter.PrintDateTime());
            sb.Append(post);
            return sb.ToString();
        }
    }
}
