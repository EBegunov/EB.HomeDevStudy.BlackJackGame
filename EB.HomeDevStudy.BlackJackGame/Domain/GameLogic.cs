using System;
using System.Collections.Generic;
using System.Text;

namespace EB.HomeDevStudy.Main.Domain
{
    class GameLogic
    {
        public int Ddddd { get; set; }

        //Генерируем карту которая выпала.
        //Надо бы как то их записывать и проверять на повтор. Это маловероятно, но всё-таки учиться же надо
        //Генерировать буду по частям сначало масть, потом номинал. Подсчет очков потом легче будет сделать

        Random random = new Random();

        #region

        //public string CardSuit()
        //{
        //    int randomNumber; 
        //    string _value = "";

        //    randomNumber = random.Next(1, 4);

        //    switch (randomNumber)
        //    {
        //        case 1:
        //            _value = "Червей";
        //            break;

        //        case 2:
        //            _value = "Бубен";
        //            break;

        //        case 3:
        //            _value = "Пик";
        //            break;

        //        case 4:
        //            _value = "Крест";
        //             break;                

        //    }

        //    return _value;
        //}
        #endregion

        #region Генерируем карту


        public int getSuit()
        {
            int resultGetSuit = random.Next(1, 4);
            
            return resultGetSuit;
        }

        public int getValue()
        {
            int resultGetValue = random.Next(1, CardsValue.Length);
            
            return resultGetValue;
        }

        int GetSuitCounterStorage()
        {
            int storageValue = 0;

            return storageValue;
        }

        int GetSuitCounter(int resultGetSuit, int storageValue)
        {
            int counter = 0;

            switch (resultGetSuit)
            {
                case 1:
                    break;

                case 2:                    
                case 3:
                case 4:
                case 5:
                    counter += 10;
                    break;
                
                case 6:
                    break;
                
                case 7:
                    break;
                
                case 8:
                    break;
                
                case 9:
                    break;
                
                case 10:
                    break;
                
                case 11:
                    break;
                
                case 12:
                    break;

                case 13:
                    break;
            }
            return counter;
        }

        public string[] CardsSuit = new string[]
        {
            Constants.clubsUnicode,
            Constants.spadesUnicode,
            Constants.heartsUnicode,
            Constants.diamondsUnicode,
        };

        public string[] CardsValue = new string[]
        {
            "Ace",
            "King",
            "Queen",
            "Jack",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
        };







        #endregion

        #region Генерируем карту 



        #endregion







        #region Подсчет очков игрока 



        #endregion

        #region Подсчет очков компьютера 



        #endregion



    }
}
