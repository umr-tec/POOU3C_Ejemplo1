﻿using System;

namespace POOU3C_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones objeto1 = new Operaciones();
          

            ////Instranciar la clase
            //Cuentas cuenta1 = new Cuentas();
            //cuenta1.PersonalizarConsola();

            ////Instancia 2
            //Cuentas cuenta2 = new Cuentas();            

            //// Mandar llamar los mienbros
            ///*
            //int resultado = cuenta1.CalcularCosto();
            //double resultado1 = cuenta1.CalcularCosto1(10, 14.5);
            //string resultado2 = cuenta1.CalcularCosto2("Goicochea", 20, 200);
            //Console.WriteLine(resultado);
            //Console.WriteLine(resultado1 );
            //Console.WriteLine(resultado2);
            //*/
            ////Mandar llamar el metodo de tipó void
            ////cuenta1.CalcularCosto3("Marcador TOP", 3, 20.99);
            ////Mandar llamar el metodo AgregarCuenta           
            //if (cuenta1.LogIn())
            //{
            //    cuenta1.Opciones();              
            //}
            //else
            //{
            //    Console.WriteLine("ERROR de inicio de sesión.");
            //}                                        
            Console.ReadKey();
        }
    }
}
