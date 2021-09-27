using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            double av1 = 0; 
            double av2 = 0;
            double media = 0;

            Console.Write("Digite a nota da AV1: ");
            av1 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Digite a nota da AV2: ");
            av2 = Convert.ToDouble( Console.ReadLine() );

            media = (av1 + av2) / 2;

            Console.WriteLine("Média do aluno: " + media);
        }
    }
}
