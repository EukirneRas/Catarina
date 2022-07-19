using System;
using Catarina.Src;

namespace Catarina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comida _alguemcomfome = new Comida(Salada.Tomate, Carboidrato.Arroz, Proteina.Feijao);
            Comida _minha = new Comida(Salada.Tomate, Carboidrato.Macarrão, Proteina.Soja);
            Console.WriteLine(_alguemcomfome.ToString());
            Console.WriteLine(_minha.ToString());
        }
    }
}
