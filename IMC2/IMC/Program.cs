using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o peso");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com a altura");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seu peso: " + peso);
            Console.WriteLine($"Sua altura: " + altura);

            float imc = peso / (altura * altura);

            if (imc <= 18.5)
            {
                Console.WriteLine("Seu IMC é: " + imc + " Abaixo do peso");
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Seu IMC é: " + imc + " Peso normal");
            }
            else if (imc > 24.9 && imc <= 29.9)
            {
                Console.WriteLine("Seu IMC é: " + imc + " Sobrepeso");
            }
            else if (imc > 29.9 && imc <= 34.9)
            {
                Console.WriteLine("Seu IMC é: " + imc + " Obesidade grau I");
            }
            else if (imc > 35 && imc <= 39.9)
            {
                Console.WriteLine("Seu IMC é: " + imc + " Obesidade grau II");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Seu IMC é: " + imc + " Obesidade grau III ou mórbida");
            }

            Console.ReadKey();
        }
    }
}

