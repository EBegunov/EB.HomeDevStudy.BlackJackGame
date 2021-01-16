using System;
using System.Collections.Generic;
using System.Text;

namespace EB.HomeDevStudy.Main.Domain
{
    class GameLogic
    {
        int turnCounter = 0;
        int playerCounter = 0;
        int artificialIntelligenceCounter = 0;





        //Генерируем карту которая выпала.
        //Надо бы как то их записывать и проверять на повтор. Это маловероятно, но всё таки учиться же надо
        //Генерировать буду по частям сначало масть, потом номинал. Подсчет очков потом легче будет сделать

        Random random = new Random();

        public string CardSuit()
        {
            int randomNumber; 
            string _value = "";

            randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    _value = "Червей";
                    break;

                case 2:
                    _value = "Бубен";
                    break;

                case 3:
                    _value = "Пик";
                    break;

                case 4:
                    _value = "Крест";
                     break;                

            }

            return _value;
        }






    }
}
