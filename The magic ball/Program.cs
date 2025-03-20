using System;
using System.Text;

namespace The_magic_ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            bool isOpenMenu = true;
            bool importantOpen = true;
            Console.WriteLine("Добро пожаловать в магический шар!\n");
            while (isOpenMenu)
            {
                bool isOpen = true;
                Console.WriteLine("Доступные вам команды: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔ Да - начнем игру\n" +
                                  "╠ Инфо - меню с информацией\n" +
                                  "╚ Нет - не начинать игру");
                Console.ResetColor();
                Console.Write("Ваш выбор: ");

                switch (Console.ReadLine().ToLower())
                {
                    case "да":
                        {
                            while (importantOpen)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(0, 4);
                                Console.WriteLine("Доступные вам команды: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("╔ Да - ознакомимся\n" +
                                                  "╚ Нет - не ознакомимся");
                                Console.ResetColor();
                                Console.SetCursorPosition(0, 0);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Важно!] ");
                                Console.ResetColor();
                                Console.WriteLine("Для начала, рекомендуем ознакомиться с информацией!");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Важно!] ");
                                Console.ResetColor();
                                Console.Write("Ознакомимся? ");
                                switch (Console.ReadLine().ToLower())
                                {
                                    case "да":
                                        MenuInfo();
                                        importantOpen = false;
                                        break;
                                    case "нет":
                                        ErrorGame("У тебя нету выбора.");
                                        break;
                                    default:
                                        ErrorGame("Я вас не понял, вы ввели не допустимое значение!");
                                        break;
                                }
                            }

                            while (isOpen)
                            {
                                Console.Clear();
                                Console.WriteLine("Напишите свой вопрос!");
                                Console.ReadLine();
                                string otvet = GenerateOtvet();
                                Console.Write("Шар дал ответ: ");
                                Console.WriteLine(otvet);
                                Console.WriteLine("\nДоступные вам команды: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("╔ Вопрос - задать еще вопрос\n" +
                                                  "╠ Меню - меню с информацией\n" +
                                                  "╚ Выход - выйти с игры");
                                Console.ResetColor();
                                Console.Write("Ваш выбор: ");
                                switch (Console.ReadLine().ToLower())
                                {
                                    case "вопрос":
                                        Console.Clear();
                                        break;

                                    case "меню":
                                        Console.Clear();
                                        isOpen = false;
                                        break;

                                    case "выход":
                                        Console.Clear();
                                        ExitGame("Всего доброго!\nРады были вас видеть!\nНадеюсь, вы к нам вернетесь!");
                                        isOpen = false;
                                        isOpenMenu = false;
                                        break;

                                    default:
                                        ErrorGame("Я вас не понял, вы ввели не допустимое значение!");
                                        break;
                                }
                            }
                        }
                        break;
                    case "нет":
                        {
                            ExitGame("Всего доброго!\nРады были вас видеть!\nНадеюсь, вы к нам вернетесь!");
                            isOpen = false;
                            isOpenMenu = false;
                        }
                        break;
                    case "инфо":
                        {
                            MenuInfo();
                            importantOpen = false;
                        }
                        break;
                    default:
                        {
                            ErrorGame("Я вас не понял, вы ввели не допустимое значение!");
                        }
                        break;
                }
            }
        }
        static void ExitGame(string text)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        static void ErrorGame(string text)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Ошибка] ");
            Console.ResetColor();
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[Информация] ");
            Console.ResetColor();
            Console.WriteLine("Нажмите для того что бы вернуться в начало.");
            Console.ReadKey();
            Console.Clear();
        }
        static void MenuInfo()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в меню с информацией!");
            Console.WriteLine("Магический шар — это программа, которая отвечает на ваши вопросы.");
            Console.WriteLine("Он может помочь вам принять решение или просто развлечь вас.");
            Console.WriteLine();
            Console.WriteLine("Как пользоваться магическим шаром:");
            Console.WriteLine("1. Напишите свой вопрос, связанный с событием или действием.");
            Console.WriteLine("2. Магический шар даст вам ответ: 'Да' или 'Нет'.");
            Console.WriteLine("3. Вы можете продолжать задавать вопросы или завершить игру.");
            Console.WriteLine();
            Console.WriteLine("Помните, что магический шар не является источником абсолютной истины.");
            Console.WriteLine("Его ответы носят случайный характер и предназначены для развлечения.");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить.");
            Console.ReadKey();
            Console.Clear();
        }
        static string GenerateOtvet()
        {
            Random rand = new Random();
            int value = rand.Next(0, 2);
            switch (value)
            {
                case 0:
                    return "Нет!";
                case 1:
                    return "Да!";
                default:
                    return "Ошибка, неверное значение!"; // ошибки такой не будет.
            }
        }
    }
}