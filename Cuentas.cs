﻿using System;
using System.Threading;
using System.Speech.Synthesis;

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
        /// <summary>
        /// Constructor sin parámetros.
        /// </summary>
        public Cuentas() {
            
        }   
        /// <summary>
        /// Constructor para cargar información necesaria para un cliente bancario.
        /// </summary>
        /// <param name="nombreCliente">Almacenar un nombre valido de cliente.</param>
        /// <param name="primerApellidoCliente"></param>
        /// <param name="segundoApellidoCliente"></param>
        /// <param name="numeroTelefonoCliente"></param>
        /// <param name="curpCliente"></param>
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
        /// <summary>
        /// Método para actualziar la información personal de un cliente bancario. 
        /// </summary>
        /// <param name="emailCliente">Cargar una dirección de correo electrónico valida: ej. umr@user.com</param>
        private void ActualizarInformacionCliente(string emailCliente) { 
            
        }

        /// <summary>
        /// Método para actualziar la información personal de un cliente bancario. 
        /// </summary>
        /// <param name="emailCliente">Cargar una dirección de correo electrónico valida: ej. umr@user.com</param>
        /// <param name="numeroTelefonoCliente">Cargar un número teléfonico valido, incluyendo LADA. ej. 8713243700</param>
        private void ActualizarInformacionCliente(string emailCliente, string numeroTelefonoCliente)
        {

        }

        /// <summary>
        /// Método para mostrar la información de un cliente bancario...
        /// </summary>
        private void InformacionCliente() {
            if (string.IsNullOrEmpty(nombreCliente))
            {
                Console.WriteLine("ERROR: Para visualizar los datos del cliente, primero debes registrar la información del mismo.");               
            }
            else
            {
                Console.WriteLine("Módulo de Información de Clientes");
                Console.WriteLine("Datos del cliente:");
                Console.WriteLine("CURP: {0}. Nombre: {1} {4} {5}. Número Cuenta: {2}. RFC: {3}. ", curpCliente, nombreCliente, numeroCuentaCliente, rfcCliente, primerApellidoCliente, segundoApellidoCliente);
                Console.WriteLine("Datos de Contacto: Emial: {0}. Teléfono: {1}", emailCliente, numeroTelefonoCliente);
            }            
        }

        /// <summary>
        /// Método para mostrar la información de una cuenta bancaria correspondiente a un cliente.
        /// </summary>
        private void InformacionCuentaCliente()
        {
            if (string.IsNullOrEmpty(numeroCuentaCliente))
            {
                Console.WriteLine("ERROR: Para visualizar los datos de la cuenta, primero debes registrar una cuenta bancaria.");
            }
            else
            {
                Console.WriteLine("Módulo de Información de Cuentas");
                Console.WriteLine("Datos del cliente:");
                Console.WriteLine("CURP: {0}. Nombre: {1} {4} {5}. Número Cuenta: {2}. RFC: {3}. ", curpCliente, nombreCliente, numeroCuentaCliente, rfcCliente, primerApellidoCliente, segundoApellidoCliente);
                Console.WriteLine("Datos de cuenta: Cuenta bancaria: {0}. Saldo: {1}", numeroCuentaCliente, saldoActualCliente);
            }
        }



        //Método para crear una cuenta
        private bool AgregarCuenta() {
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

        public bool LogIn() {
            string usuario, contrasena;
            string usuario1 = "umr", contrasena1 = "123";
            bool resuultado;
            Console.WriteLine("Ingresa tu usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña");
            contrasena = Console.ReadLine();
            if (usuario1 == usuario && contrasena1 == contrasena)
            {
                Console.WriteLine("Ingresando .");
                Thread.Sleep(800);
                Console.WriteLine("Ingresando ..");
                Thread.Sleep(800);
                Console.WriteLine("Ingresando ...");
                Thread.Sleep(800);
                Console.WriteLine("Ingresando ....");
                //objeto de tipo synthesis
                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.Speak("Bienvenido al sistema bancario");
                resuultado = true;
            }
            else
            {
                resuultado = false;
            }
            return resuultado;
        }

        private char Salir() {
            string opcion;
            Console.WriteLine("¿Estás seguro que deseas salir de la aplicación?");
            Console.WriteLine("Presiona s para continuar en el sistema.");
            Console.WriteLine("Presiona n para salir del sistema.");
            opcion = Console.ReadLine();
            Console.Clear();
            Thread.Sleep(800);
            Environment.Exit(-1);
            return Convert.ToChar(opcion);
        }
        private void Expediente() {
            string opcion;
            Console.WriteLine("Selecciona los datos que deseas actualizar");
            Console.WriteLine(" 1. Actualizar correo electrónico \n 2. Actualizar correo electrónico y número teléfonico.");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    string nuevoEmail, nuevoCelular;
                    Console.WriteLine("Ingresa la nueva dirección de correo electrónico");
                    nuevoEmail = Console.ReadLine();
                    ActualizarInformacionCliente(nuevoEmail);
                    break;
                case "2":                    
                    Console.WriteLine("Ingresa la nueva dirección de correo electrónico");
                    nuevoEmail = Console.ReadLine();
                    Console.WriteLine("Ingresa el nuevo número de celular");
                    nuevoCelular = Console.ReadLine();
                    ActualizarInformacionCliente(nuevoEmail,nuevoCelular);
                    break;
                default:
                    break;
            }
            ActualizarInformacionCliente("umr@tecsanpedro.edu.mx", "8713243700");
        }
        public void Opciones() {            
            string opcionSeleccionada;
            char activo = 's';
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Speak("Escribe el digito de la opcion deseada, y luego presiona enter");

            while (activo == 's')
            {
                Console.WriteLine("Módulo de aministración bancaria");
                Console.WriteLine("Opciones: ");
                Console.WriteLine("1. Ver información del cliente.");
                Console.WriteLine("2. Ver información de la cuenta.");
                Console.WriteLine("3. Agregar cuenta bancaria.");
                Console.WriteLine("4. Eliminar cuenta bancaria.");
                Console.WriteLine("5. Actualizar datos de la cuenta bancaria.");
                Console.WriteLine("6. Salir.");
                opcionSeleccionada = Console.ReadLine();
                #region OpcionConIf
                //Seleccionar la opcionSeleccionada con estructura IF
                //if (opcionSeleccionada == "1")
                //{
                //    Console.WriteLine("Seleccionaste la opción 1");
                //}
                //if (opcionSeleccionada == "2")
                //{
                //    Console.WriteLine("Seleccionaste la opción 2");
                //}
                //if (opcionSeleccionada == "3")
                //{
                //    Console.WriteLine("Seleccionaste la opción 3");
                //}
                //if (opcionSeleccionada == "4")
                //{
                //    Console.WriteLine("Seleccionaste la opción 4");
                //}
                //if (opcionSeleccionada == "5")
                //{
                //    Console.WriteLine("Seleccionaste la opción 5");
                //}
                #endregion
                switch (opcionSeleccionada)
                {
                    case "1":
                        InformacionCliente();
                        break;
                    case "2":
                        InformacionCuentaCliente();
                        break;
                    case "3":
                        //Mandar llamar el metodo AgregarCuenta()
                        AgregarCuenta();
                        break;
                    case "4":
                        Console.WriteLine("Opción 4");
                        break;
                    case "5":
                        Expediente();
                        break;
                    case "6":                        
                        activo = Salir();
                        break;
                    default:
                        Console.WriteLine("Seleccionaste el Default");
                        break;
                }
            }            
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
