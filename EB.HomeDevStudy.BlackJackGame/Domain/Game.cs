using System;

namespace EB.HomeDevStudy.Main.Domain
{
    public class Game
    {
        public void Start()
        {
            User player = new Player();
            User comp = new ArtificialIntelligence();

            Console.WriteLine(player.GetScoreInfo());
            Console.WriteLine(comp.GetScoreInfo());

            player.Name = "A";
            comp.Name = "Elite";

            Console.WriteLine(player.GetName());
            Console.WriteLine(comp.GetName());

        }


    }
}
