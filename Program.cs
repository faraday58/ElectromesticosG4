using System;

namespace ElectromesticosG4
{
    class Program
    {
        static void Main()
        {
            IApagar iapagar = new Refrigerador();
            iapagar.Apagar();

            Estufa miEstufa = new Estufa();
            miEstufa.Apagar();


        }
    }
}
