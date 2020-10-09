using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double ladoA;
            double ladoB;
            double ladoC;
            double perimetro;
            double area;

            Console.Write("Digite o nome da figura a ser trabalhada: ");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite o Valor do ladoA!");
            ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor do ladoB!");
            ladoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor do ladoC!");
            ladoC = double.Parse(Console.ReadLine());

            perimetro = (ladoA + ladoB + ladoC) / 2;
            area = Math.Sqrt(perimetro * (perimetro - ladoA) * (perimetro) - ladoB) *(perimetro - ladoC);

            Console.WriteLine("Semiperímetro = {0}", perimetro);
            Console.WriteLine("Area = {0}(cm²)", area);
            Console.WriteLine($"nome:  {nome}");
            Console.WriteLine("");
            
            
            

        






            
        }
    }
}
