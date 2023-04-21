using System;

namespace POOU3C_Ejemplo1
{
    class Cuentas
    {
        // ¿Qué contiene una clase?
        // Miembros: Campos, Métodos, Contructores, Propiedades, Destrctores

        //Métodos
        public int CalcularCosto() {
            return 10+10;
        }
        public double CalcularCosto1( int cantidad, double precio ) {
            return cantidad * precio;
        }

        public string CalcularCosto2(string nombreArticulo, int cantidad, double precio) {
            double total = cantidad * precio;
            return "Producto: " + nombreArticulo + " Total de venta: $" + total ;
        }        
        public void CalcularCosto3(string nombreArticulo, int cantidad, double precio)
        {
            double total = cantidad * precio;
            string resultado = "Producto: " + nombreArticulo + " Total de venta: $" + total;
            Console.WriteLine(resultado);
        }

        public void PersonalizarConsola() {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "BancoTec";
            Console.WindowHeight = 40;
            Console.WindowWidth = 100;
            Console.Clear();
        }

    }
    /*
        Participaciones:
          + Aldo, Sergio, Juan Ángel, MArijose
          - ALexis, UMR, UMR,
     */
}
