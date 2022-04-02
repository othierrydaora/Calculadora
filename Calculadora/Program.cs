using System;

namespace Teste
{
    class Program
    {
        public static void Rep()
        {
            Console.WriteLine("Deseja calcular novamente?\n0- Não\n1 - Sim");
            int cf = Convert.ToInt32(Console.ReadLine());

            if (cf > 1 || cf < 0)
            {
                Console.WriteLine("Os números aceitos são apenas 0 e 1\n");
                Rep();
            }

            if (cf == 1)
            {
                Console.WriteLine("\n\n");
                Main();
            }
            else if (cf == 0)
                Console.WriteLine("Até mais");
                Console.ReadKey();
        }

        public static string Calc(double num, double num1, int opr)
        {
            if (opr > 5 || opr < 1)
                throw new Exception("As opções aceitas são apenas de 1 a 5");

            double rst = opr == 1 ? num + num1 : opr == 2 ? num - num1 : opr == 3 ? num * num1 : opr == 4 ? num / num1 : opr == 5 ? Math.Pow(num, num1) : 0;
            return "O resultado é: " + rst;
        }

        public static void Main()
        {
            Console.Title = "Calcular";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 20;
            try
            {
                Console.Write("Insira a operação:\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Potenciação\n");
                int op = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insira o primeiro valor: ");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.Write("Insira o segundo valor: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n" + Calc(n, n1, op));
                Rep();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro ocorreu\n" + ex.Message + "\n\n");
                Main();
            }
        }

    }
}