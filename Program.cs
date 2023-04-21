using System;

namespace POOU3C_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instranciar la clase
            Cuentas cuenta1 = new Cuentas();
            cuenta1.PersonalizarConsola();
            // Mandar llamar los mienbros
            int resultado = cuenta1.CalcularCosto();
            double resultado1 = cuenta1.CalcularCosto1(10, 14.5);
            string resultado2 = cuenta1.CalcularCosto2("Goicochea", 20, 200);
            Console.WriteLine(resultado);
            Console.WriteLine(resultado1 );
            Console.WriteLine(resultado2);
            //Mandar llamar el metodo de tipó void
            cuenta1.CalcularCosto3("Marcador TOP", 3, 20.99);

            
            Console.ReadKey();
        }
    }
}
