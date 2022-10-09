using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso6
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ejercicio VI
            //Crear una aplicación que, cuando el usuario ingrese dos números, realice la operación
            //aritmética(a + b) * (a - b) e indique por pantalla el resultado. 

            int num1;
            int num2;
            int resultado;

            Console.WriteLine("Ingrese un número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            num2 = int.Parse(Console.ReadLine());
            resultado = OpAritmetica(num1, num2);
            Console.WriteLine("El resultado de la operación aritmética(a + b) * (a - b) es " + resultado);
            Console.ReadKey();
        }

        public static int OpAritmetica(int num1, int num2)
        {

            int resultado = (num1 + num2) * (num1 - num2);
            return resultado;
        }
    }
}
