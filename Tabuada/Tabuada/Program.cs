using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número que deseja saber a tabuada");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < 11; i++)
            {
                int z = x * i;

                Console.WriteLine(x + " x " + i + " = " + z);
            }
        }
    }
}
