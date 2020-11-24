using System;
using System.IO;
namespace hackaton2
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            int fieldCell = 0, userPoints = 200, number4Class, number5Class;
            string answer;
            string[] readQuestions4Class = File.ReadAllLines("questions4class.txt");
            string[] readAnswer4Class = File.ReadAllLines("answers4class.txt");
            string[] readQuestions5Class = File.ReadAllLines("questions5class.txt");
            string[] readAnswer5Class = File.ReadAllLines("answers5class.txt");
            number4Class = Convert.ToInt32(rnd.Next(0, readAnswer4Class.Length));
            number5Class = Convert.ToInt32(rnd.Next(0, readAnswer5Class.Length));
            while (userPoints < 1000)
            {
                fieldCell += Convert.ToInt32(rnd.Next(1, 7)); // бросаем кубик
                if (fieldCell >= 40)
                {
                    fieldCell -= 40;
                    userPoints += 100;
                    Console.WriteLine("\n Вы прошли круг и получили 100 очков!");
                }


                if (fieldCell == 2 || fieldCell == 4 || fieldCell == 7 || fieldCell == 12 || fieldCell == 17 ||
                    fieldCell == 22 || fieldCell == 28 || fieldCell == 33 || fieldCell == 36 || fieldCell == 38)
                { //рандом от -50 до 50
                    userPoints += Convert.ToInt32(rnd.Next(-50, 51));
                    Console.WriteLine();
                    Console.WriteLine("Клетка поля = " + (fieldCell));
                    Console.WriteLine("Количество очков: " + userPoints);
                }


                else if (fieldCell == 10 || fieldCell == 20 || fieldCell == 30)
                    Console.WriteLine("Поздравляем! Вам выпала пустая клетка");


                else if (fieldCell == 5 || fieldCell == 15 || fieldCell == 25 || fieldCell == 35)
                { // Вопросы за 5 класс
                    Console.WriteLine("Клетка поля = " + (fieldCell));
                    Console.WriteLine(readQuestions5Class[number5Class]);
                    Console.Write("Ваш ответ: ");
                    answer = Console.ReadLine();
                    Console.WriteLine();
                    number5Class++;
                    
                    if (answer == readAnswer5Class[number5Class-1])
                    {
                        Console.WriteLine("Вы ввели правильный ответ!");
                        userPoints += 40;
                        Console.WriteLine("Количество очков: " + userPoints);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверный ответ!");
                        userPoints -= 20;
                        Console.WriteLine("Количество очков: " + userPoints);
                    }
                    if (number5Class == readQuestions5Class.Length)
                        number5Class = number5Class + 1 - readQuestions5Class.Length;
                }


                else // Вопросы за 4 класс
                {
                    Console.WriteLine();
                    Console.WriteLine("Клетка поля = " + (fieldCell));
                    Console.WriteLine(readQuestions4Class[number4Class]);
                    Console.Write("Ваш ответ: ");
                    answer = Console.ReadLine();
                    Console.WriteLine();
                    number4Class++;
                    
                    if (answer == readAnswer4Class[number4Class-1])
                    {
                        Console.WriteLine("Вы ввели правильный ответ!");
                        userPoints += 20;
                        Console.WriteLine("Количество очков: " + userPoints);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверный ответ!");
                        userPoints -= 10;
                        Console.WriteLine("Количество очков: " + userPoints);
                    }
                    if (number4Class == readQuestions4Class.Length)
                        number4Class = number4Class + 1 - readQuestions4Class.Length;
                }


                if (userPoints <= 0)
                {
                    Console.WriteLine("\nВы проиграли!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
                Console.WriteLine("Вы выиграли! Количество очков: " + userPoints);
                Console.ReadLine();
        }
    }
}