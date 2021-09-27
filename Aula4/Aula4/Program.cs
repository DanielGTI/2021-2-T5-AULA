using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            short idade = 20;
            int valores = 10;
            float velocidade = 32767;
            String dados = "15";

            idade = Convert.ToInt16( valores );
            //valores = idade;
            //valores = Convert.ToInt32( velocidade );

            // ERROR (Cuidado)
            idade = Convert.ToInt16(velocidade);
            valores = Convert.ToInt32(dados);

            Console.WriteLine("Valores = " + valores);
            Console.WriteLine("Idade = "+ idade);
        }
    }
}
