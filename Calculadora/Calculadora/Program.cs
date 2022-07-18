using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ope;
            do
            {
                Console.WriteLine("Aperte desligar no lugar da operação para desligar");
                Console.WriteLine("Primeiro número:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a operação: (so - Soma, su - Subtração, m - Multiplicação, d - Divisão)");
                ope = Console.ReadLine();
                if (ope == "desligar")
                {
                    continue;
                }
                Console.WriteLine("Segundo número:");
                int b = int.Parse(Console.ReadLine());

                if (ope == "so" || ope == "So")
                {
                    Somar(a, b);
                    Console.WriteLine("Resultado da soma: " + Somar(a, b));
                }

                if (ope == "su" || ope == "Su")
                {
                    Subtrair(a, b);
                    Console.WriteLine("Resultado da subtração: " + Subtrair(a, b));
                }

                if (ope == "m" || ope == "M")
                {
                    Multiplicar(a, b);
                    Console.WriteLine("Resultado da multiplicação: " + Multiplicar(a, b));
                }

                if (ope == "d" || ope == "D")
                {

                    Dividir(a, b);
                    Console.WriteLine("Resultado da divisão: " + Dividir(a, b));
                }

                static int Somar(int a, int b)
                {
                     return (a + b);
                }
                static int Subtrair(int a, int b)
                {
                    return a - b;
                }
                static int Multiplicar(int a, int b)
                {
                    return a * b;
                }
                static string Dividir(int a, int b)
                {
                    if (eDividendoIgualZero(b))
                    {
                        return "Dividendo igual a zero";
                    }
                    return string.Format($"{a} / {b} = {a / b}");
                 
                    bool eDividendoIgualZero(int b)
                    {
                        if (b == 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }

            }
            while (ope != "desligar");
        }
    }
}
