using System;

namespace CalculadoraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora2 calc = new Calculadora2();
            Console.WriteLine("Digite uma operação no formato de ex: 12 x 3");
            calc.EfetuarCalculos(Console.ReadLine());
            Console.WriteLine("Resultado:" + calc.resultado);            
            
            Console.WriteLine("Digite números separados por ponto e vírgula para calcularmos a média");
            calc.CalculoMedia(Console.ReadLine());
            Console.WriteLine("Média:" + calc.resultado);
            
        }
    }
}
