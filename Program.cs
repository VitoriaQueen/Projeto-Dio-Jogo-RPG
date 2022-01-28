using System;
using Projeto_Dio_Jogo_RPG.src;
using Projeto_Dio_Jogo_RPG.src.Entities;

namespace Projeto_Dio_Jogo_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutants hero1 = new Mutants("Trickster", "Psychic", 7, 17);
            Extraterrestres hero2 = new Extraterrestres("BellaDonna", "PlantsControl", 20, 14);
            Wizards hero3 = new Wizards("Morgana", "AirMagic", 15, 12);
            
            hero1.Attack();
            hero2.Attack();
            hero3.Attack();
            
            hero1.Meditar();
            hero2.Meditar();
            hero3.Meditar();



        }
    }
}
