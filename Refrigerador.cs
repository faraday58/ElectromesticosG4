using System;
using System.Threading;
namespace ElectromesticosG4
{
    class Refrigerador : IApagar
    {

        public Refrigerador()
        {
            Console.WriteLine("Hola, buen día");
        }
        void IApagar.Apagar()
        {
            Console.WriteLine("Suspendiendo compresor");
            Thread.Sleep(2000);
            Console.WriteLine("Hasta luego....");
        }
    }
}
