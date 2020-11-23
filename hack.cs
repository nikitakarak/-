using System;
using System.IO;

namespace hack1
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Нажмите клавишу Enter чтобы запутисть рандом!");
            Console.ReadLine();
            int random = 0, ochki = 0;
            string answer;
            string[] readInput = File.ReadAllLines("questions.txt");
            string[] readAnswer = File.ReadAllLines("answers.txt");
            while (true)
            {
                random = Convert.ToInt32(rnd.Next(0, readInput.Length));
                Console.WriteLine();
                Console.WriteLine("Ваш вопрос: " + (random + 1));
                Console.WriteLine(readInput[random]);
                
                Console.Write("Ваш ответ: ");
                answer = Console.ReadLine();
                Console.WriteLine();
                if (answer == readAnswer[random])
                {
                    Console.WriteLine("Вы ввели правильный ответ!");
                    ochki++;
                    Console.WriteLine("Количество очков: " + ochki);
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный ответ!");
                    Console.WriteLine("Количество очков: " + ochki);
                }
            }

            Console.ReadLine();
        }
    }
}