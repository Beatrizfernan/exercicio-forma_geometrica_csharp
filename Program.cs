using System;
using System.Globalization;

namespace exercicio6_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor flutuante A:");
            double A = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite o valor flutuante B:");
            double B = double.Parse(Console.ReadLine());



            Console.WriteLine("Digite o valor flutuante C:");
            double C = double.Parse(Console.ReadLine());


            double triangulo = A * C / 2.0;
            double circulo = 3.14159 * C * C;
            double trapezio = (A + B) / 2.0 * C;
            double quadrado = B * B;
            double retangulo = A * B;


            Console.WriteLine("TRIANGULO:" + triangulo);
            Console.WriteLine("CIRCULO: " + circulo);
            Console.WriteLine("TRAPEZIO: " + trapezio);
            Console.WriteLine("QUADRADO:  " + quadrado);
            Console.WriteLine("RETANGULO: " + retangulo);
          



        }
    }
}
