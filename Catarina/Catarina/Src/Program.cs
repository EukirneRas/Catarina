using System;
using Catarina.Src;

namespace Catarina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animais _insetos = new Animais(Carnivoro.Joaninha, Herbivoro.Lagarta, Onivoro.Grilo);
            Animais _mamiferos = new Animais(Carnivoro.Tigre, Herbivoro.Alce, Onivoro.Suricato);
            Animais _passaros = new Animais(Carnivoro.Carcara, Herbivoro.Colerinho, Onivoro.Avestruz);
            Animais _peixes = new Animais(Carnivoro.Tubarao, Herbivoro.Piapara, Onivoro.Tilapia);

            Console.WriteLine(_insetos.ToString());
            Console.WriteLine(_mamiferos.ToString());
            Console.WriteLine(_passaros.ToString());
            Console.WriteLine(_peixes.ToString());
        }
    }
}
