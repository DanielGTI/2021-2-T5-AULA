using System;

namespace Aula5
{
    class Program
    {

        public static void p1001()
        {
            int a, b, x;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            x = a + b;
            Console.Write("X = {0}\n", x);
        }
        public static void p1002()
        {
            double area, raio;
            raio = Convert.ToDouble(Console.ReadLine());
            area = 3.14159 * Math.Pow(raio,2);

            Console.Write("A={0}\n", area.ToString("0.0000") );
        }
        public static void p1003()

        {
            Console.Write("1003");
        }

        public static void p1010()
        {
            Console.Write("1010");
        }
        static void Main(string[] args)
        {
            int prog;
            do
            {

                Console.Write("\n\t| 0 para Sair |\nDigite o programa desejado: ");
                prog = Convert.ToInt32(Console.ReadLine());

                //  SIMPLES
                if (prog == 0)
                {
                    Console.Write("\nSaindo...\n\n\n");
                    break;
                }

                switch (prog)
                {
                    case 1001:
                        Program.p1001();
                        break;
                    case 1002:
                        Program.p1002();
                        break;
                    case 1003:
                        Program.p1003(); ;
                        break;
                    case 1010:
                        Program.p1010();
                        break;

                    default:
                        Console.Write("\nValor invalido!\n");
                        break;
                }

            } while (prog != 0);

        }
    }
}
