using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinKlase
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceduralni x = new Proceduralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();
            Console.WriteLine("Upiši te postotak za Proceduralni tip");
            x.Postotak = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upiši te postotak za Objektni tip");
            y.Postotak = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upiši te postotak za Funkcionalni tip");
            z.Postotak = Convert.ToDouble(Console.ReadLine());
            double zbroj = x.Postotak + y.Postotak + z.Postotak;
            if(zbroj!=100)
            {
                Console.WriteLine("Neispravni unos podataka");
            }
            else
            {
                if(x.Postotak>y.Postotak && x.Postotak>z.Postotak)
                {
                    Console.WriteLine("Proceduralni tip je najzastupljeniji");
                }
                if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Objektni tip je najzastupljeniji");
                }
                if (z.Postotak > x.Postotak && z.Postotak > y.Postotak)
                {
                    Console.WriteLine("OFunkcionalnii tip je najzastupljeniji");
                }
            }
            Console.ReadKey();
        }
    }
}
