using System;
namespace Projeto_Dio_Jogo_RPG.src.Entities
{
    public class Wizards : SuperHeros 
    {
        public Wizards(string Name, string HeroType, int Level, int Poder)
        {
          this.Name = Name;
          this.HeroType = HeroType;
          this.Level = Level;
          this.Poder = Poder;
        }
        public override void Attack()
        {
            if (Poder > 0)
            {
            Console.WriteLine(this.Name + " ataca com poder da mente nivel " + this.Poder);
            Poder = Poder - 5;
            Level++;
            Console.WriteLine(this.Name + " perdeu poder depois do ataque e esta com nivel de poder " + this.Poder);
            Console.WriteLine("Depois do ataque " + this.Name + " evoluiu para o nivel " + this.Level); 
            }
            else
            {
            Console.WriteLine($"{this.Name} esta sem poder.");
            }
        }
        public override void Meditar()
      {
        int newPower = this.Poder + 3;
        Console.WriteLine($"{this.Name} meditou e adicionou 2 unidades de poder a sua forca.");
        Console.WriteLine($"{this.Name} agora tem poder {newPower} e esta no nivel " + Level);
      }

    }
}