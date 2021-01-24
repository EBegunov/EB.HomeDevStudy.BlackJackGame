using System;
using EB.HomeDevStudy.Main.Domain;


namespace EB.HomeDevStudy.Main.View
{
    class PlayingCard
    {
        GameLogic gameLogic = new GameLogic();
        
        
        
        
        
        public string PlayingCardView()
        {                                    
            string cardSuit = gameLogic.CardsSuit[gameLogic.getSuit()];                       
            
            string cardValue = gameLogic.CardsValue[gameLogic.getValue()];

            return $"{cardSuit}{cardValue}";
        }
    }
}
