using Genius.Common;
using System;

namespace Genius_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начнем игру! Введите своё имя:");
            string userName = (Console.ReadLine());
            var user = new User(userName);
            var game = new Game(user);

            while (!game.IsEnd)
            {
                Console.WriteLine(game.GetCurrentQuestionTitle());
                Console.WriteLine(game.PopCurrentQuestion());
                var userAnswer = Console.ReadLine();
                game.AcceptUserAnswer(userAnswer);
            }

            var diagnose = game.GetUserDiagnose();
            Console.WriteLine();
            Console.WriteLine(diagnose);
            Console.WriteLine();
            Console.WriteLine("Для выхода из игры нажмите любую клавишу");

            Console.ReadKey();
        }
    }
}
