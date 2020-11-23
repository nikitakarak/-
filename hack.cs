using System;
using System.IO;

namespace hackaton1
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Нажмите клавишу Enter чтобы запутисть рандом!");
            Console.ReadLine();
            int random = 0, points = 0;
            string answer;
            string[] readInput = File.ReadAllLines("questions.txt");
            string[] readAnswer = File.ReadAllLines("answers.txt");
            while (true)
            {
                random += Convert.ToInt32(rnd.Next(1, 7));
                if (random > readInput.Length)
                    break;
                Console.WriteLine();
                Console.WriteLine("Клетка поля = " + (random));
                Console.WriteLine(readInput[random]);
                
                Console.Write("Ваш ответ: ");
                answer = Console.ReadLine();
                Console.WriteLine();
                if (answer == readAnswer[random])
                {
                    Console.WriteLine("Вы ввели правильный ответ!");
                    points++;
                    Console.WriteLine("Количество очков: " + points);
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный ответ!");
                    Console.WriteLine("Количество очков: " + points);
                }
            }
            Console.WriteLine("Вы выиграли! Количество очков: " + points);
            Console.ReadLine();
        }
    }
}