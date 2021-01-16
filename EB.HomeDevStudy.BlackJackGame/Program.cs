using System;
using EB.HomeDevStudy.Main.View;
using EB.HomeDevStudy.Main.Domain;
using System.Linq;

namespace EB.HomeDevStudy.Main
{
    class Program
    {
        static void Main(string[] args)
        {

            StartGame startGame = new StartGame();

            startGame.Start();

            string playerStartGame = Console.ReadLine();

            Constants constants = new Constants();
            
            string[] playerLetter = constants.letterForStartGame;

            if (playerLetter.Contains(playerStartGame))
            {
                //Начало игры
            }
            else
            {
                Console.WriteLine("Ну как хочешь. Надумаешь поиграть ты знаешь где меня искать");
            }



        }
    }
}
