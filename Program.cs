using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13_consoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommanExit = "Exit";
            const string CommandRed = "Red";
            const string CommandGreen = "Green";
            const string CommandYellow = "Yellow";
            const string CommandMagenta = "Magenta";
            const string CommandSetName = "SetName";
            const string CommandShowName = "ShowName";
            const string CommandShowWeather = "ShowWeather";
            const string CommandResetUserColors = "ResetUserColors";
            const string CommandChangeConsoleColor = "ChangeConsoleColor";
            const string CommandChangeBackgroundColor = "ChangeBackgroundColor";

            bool isOpen = true;
            ConsoleColor defaultBackgroundColor = Console.BackgroundColor;
            ConsoleColor defaultForegroudColor = Console.ForegroundColor;
            string currentWeather = "Солнечно. +15 градусов. Ветер восточный 3 м/с";
            string userName = null;
            string userInput;


            while (isOpen)
            {
                Console.WriteLine($"\tМеню.\n{CommandSetName} - установить имя.\n{CommandShowName} - показать имя.\n{CommandShowWeather} - показать текущую погоду.\n" +
                                  $"{CommandChangeConsoleColor} - выбрать цвет шрифта консоли.\n{CommandChangeBackgroundColor} - выбрать цвет фона консоли.\n" +
                                  $"{CommandResetUserColors} - сбросить выбранные пользователем настройки цветов.\n{CommanExit} - выйти из программы.") ;
                Console.Write("\nВыберите действие: ");
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case CommandSetName:
                        Console.Write("Введите ваше имя: ");
                        userName = Console.ReadLine();
                        break;
                    case CommandShowName:
                        Console.WriteLine($"Вас зовут {userName}.");
                        break;
                    case CommandChangeConsoleColor:
                        Console.WriteLine("Какой цвет шрифта вы хотите?\nMagenta - Фиолетово-Крассный\tGreen - Зеленый");
                        Console.Write("Выберите цвет: ");
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case CommandMagenta:
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                break;
                            case CommandGreen:
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                        }
                        break;
                    case CommandChangeBackgroundColor:
                        Console.WriteLine($"Какой цвет фона вы хотите?\n{CommandRed} - Крассный\t{CommandYellow} - Желтый");
                        Console.Write("Выберите цвет: ");
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case CommandRed:
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case CommandYellow:
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                        }
                        break;
                    case CommandResetUserColors:
                        Console.BackgroundColor = defaultBackgroundColor;
                        Console.ForegroundColor = defaultForegroudColor;
                        break;
                    case CommandShowWeather:
                        Console.WriteLine($"Прогноз погоды: {currentWeather}");
                        break;
                    case CommanExit:
                        isOpen = false;
                        continue;
                    default:
                        Console.WriteLine("Вы ввели неизвестную команду. Пожалуйста повторите ввод.\n");
                        break;
                }
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
