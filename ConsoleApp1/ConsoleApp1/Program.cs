using System;

namespace Primeraaplicacion
{

    class Program
    {
        static void Main(string[] args)
        {

            mensajePantalla();

            sumaNumero(2.4, 3);

            int respuestaDeSuma = sumaNumero(11, 3);

            Console.WriteLine(respuestaDeSuma);

            int promedio = Promedio1(4, 5);
        }

        private static int Promedio1(int v1 = 0, int v2) => (v1 + v2) / 2;


        static void mensajePantalla() {

            Console.WriteLine("Este es mi primer metodo");

        }

        static void sumaNumero(double num1, int num2) {

            double resultado = num1 + num2;
            Console.WriteLine(" La suma de los numeros es = " + resultado);
        
        }

        static int sumaNumero(int num1, int num2)
        {

            int resultado = num1 + num2;
           return resultado;

        }

    }
}

