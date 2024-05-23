using Laba1OOPNumber2;
using System.Text;


IDateTimePrinter printer1, printer2;

printer1 = new PostDecorator(new EuropeanDateTimePrinter(), " dfgdsfg ");
printer2 = new PostDecorator(printer1, " 111111111 ");
Console.WriteLine(printer1.PrintDateTime());
Console.WriteLine(printer2.PrintDateTime());


printer1 = new PrefDecorator(new AmericanDateTimePrinter(), " dfgdsfg ");
printer2 = new PrefDecorator(printer1, " 111111111 ");
Console.WriteLine(printer1.PrintDateTime());
Console.WriteLine(printer2.PrintDateTime());
