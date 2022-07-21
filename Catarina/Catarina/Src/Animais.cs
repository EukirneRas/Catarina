using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catarina.Src
{
    internal class Animais
    {
        public Carnivoro Carnivoro { get; set; }
        public Herbivoro Herbivoro { get; set; }
        public Onivoro Onivoro { get; set; }


        public Animais()
        {

        }

        public Animais(Carnivoro carnivoro, Herbivoro herbivoro, Onivoro onivoro)
        {
            Carnivoro = carnivoro;
            Herbivoro = herbivoro;
            Onivoro = onivoro;
        }
    }


    public enum Carnivoro
    {
        Tigre, Tubarao, Carcara, Joaninha
    }
    public enum Herbivoro
    {
        Alce, Piapara, Colerinho, Lagarta
    }
    public enum Onivoro
    {
        Suricato, Avestruz, Tilapia, Grilo
    }


}
