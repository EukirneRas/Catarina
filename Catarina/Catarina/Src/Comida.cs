using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catarina.Src
{
    internal class Comida
    {
        public Salada Salada { get; set; }

        public Carboidrato Carboidrato { get; set; }

        public Proteina Proteina { get; set; }

        public Comida()
        {

        }

        public Comida (Salada salada, Carboidrato carboidrato, Proteina proteina)
        {
            Salada = salada;
            Carboidrato = carboidrato;
            Proteina = proteina;
        }
    }
    

    public enum Salada
    {
        Tomate, Alface, Pepino, Acelga, Cenoura
    }
    public enum Carboidrato
    {
        Arroz, Macarrão, Batata
    }
    public enum Proteina
    {
        Feijao, Soja, Grao_de_bico, Lentilha
    }

}
