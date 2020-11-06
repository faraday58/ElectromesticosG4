using System;

namespace ElectromesticosG4
{
    class Program
    {
        static void Main()
        {
            IApagar iapagar = new Refrigerador();
            iapagar.Apagar();
            Refrigerador miRefrigerador = new Refrigerador();
            miRefrigerador.Encender();


            Estufa miEstufa = new Estufa();
            miEstufa.Apagar();
            IEncender iencender = (IEncender)miEstufa;
            iencender.Encender();

        }
    }
}
