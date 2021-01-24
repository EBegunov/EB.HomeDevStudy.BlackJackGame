using EB.HomeDevStudy.Main.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EB.HomeDevStudy.Main.View
{
    class PlayerTurn
    {
        
        public void PlayerTurnStart()
        {
            Console.WriteLine("Ну что ж, я здаю. Вот твои две карты");

            PlayingCard playingCard = new PlayingCard();

            Console.WriteLine($"{playingCard.PlayingCardView()}");
            
            Console.WriteLine($"{playingCard.PlayingCardView()}");



            Console.WriteLine($"Итого у тебя  очков ");

            //Console.WriteLine($"");





            //Console.WriteLine($"Итого у тебя очков");
            //Console.WriteLine($"Еще карту или хватит");




        }





    }
}
