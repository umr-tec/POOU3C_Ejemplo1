using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU3C_Ejemplo1
{
    class Operaciones
    {
        /// <summary>
        /// Método para sumar dos valores enteros.
        /// </summary>
        /// <param name="a">Primer número entero a sumar.</param>
        /// <param name="b">Segundo número entero a sumar.</param>
        public void Suma(int a, int b) {
            Console.WriteLine(a + b);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void Suma(int a, int b, int c)
        {
            Console.WriteLine(a + b+c);
        }
        public void Suma(int a, int b, int c,int d)
        {
            Console.WriteLine(a + b + c+d);
        }
    }
}
