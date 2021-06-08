using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasprinterr
{
    public class PrinterWindows
    {
        public virtual void  Show()
        {
            Console.WriteLine(" pilih printer untuk menampilkan display dimensi ...");
        }
        public virtual void Print()
        {
            Console.WriteLine(" pilih printer untuk print...");
        }
    }
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Tampilan dimensi Canon : 10*11");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }

    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Tampilan dimensi Epson : 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }

    }

    public class LasetJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Tampilan dimensi LasetJet : 20*20");
        }

        public override void Print()
        {
            Console.WriteLine("LasetJet printer printing....");
        }
    }
}
