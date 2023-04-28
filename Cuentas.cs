using System;

namespace POOU3C_Ejemplo1
{
    class Cuentas
    {
        // ¿Qué contiene una clase?
        // Miembros: Campos, Métodos, Contructores, Propiedades, Destrctores

        //Miembros de tipo de Campo
        #region Campos
        string numeroCuentaCliente, nombreCliente,
            primerApellidoCliente, segundoApellidoCliente;
        string nipCliente, curpCliente = "sdfgh", rfcCliente, descripcionAccion;
        double saldoActualCliente, saldoAneriorCliente;
        string direccionFiscalBanco, numeroTelefonoCliente, emailCliente;
        string tipoDivisaCuenta;
        DateTime fechaNaciminetoCliente;
        #endregion

        #region Constrcutores
        public Cuentas() { }
        public Cuentas(string nombreCliente,
            string primerApellidoCliente,
            string segundoApellidoCliente,
            string numeroTelefonoCliente,
            string curpCliente)
        {
            this.nombreCliente = nombreCliente;
            this.primerApellidoCliente = primerApellidoCliente;
            this.segundoApellidoCliente = segundoApellidoCliente;
            this.numeroTelefonoCliente = numeroTelefonoCliente;
            this.curpCliente = curpCliente;
        }
        #endregion

        #region Metodos

        //Método para crear una cuenta
        public bool AgregarCuenta() {
            bool valorRetorno;
            string opcionElegida;
            ConsoleKeyInfo keyInfo;
            Console.WriteLine("Módulo de administración de cuentas bancarias \n");            
            if (string.IsNullOrEmpty(curpCliente))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No se a asignado un cliente.");
                valorRetorno = false;
            }
            else
            {
                Console.WriteLine("Elije una de las siguientes opciones: \n");
                Console.WriteLine("\t 1. Agregar una cuenta. \n");
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("\n Da de alta la cuenta del cliente con CURP: {0}", curpCliente);
                    numeroCuentaCliente = Console.ReadLine();
                    valorRetorno = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Selecciona una opcion valida");
                    valorRetorno = false;
                }
            }
            return valorRetorno;
        }




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
            Console.WindowHeight = 20;
            Console.WindowWidth = 100;
            Console.Clear();
        }

        #endregion
    }
    /*
        Participaciones:
          + Aldo, Sergio, Juan Ángel, MArijose
          - ALexis, UMR, UMR, Fernando
     */
}
