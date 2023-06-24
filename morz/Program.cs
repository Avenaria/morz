using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace Morzein
{

    // Программа перевода слов в морзянку.


    class Program
    {
        public static int ch { get; set; }

        public static int to { get; set; }

        public static int ti { get; set; }

        public static int inp { get; set; }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.WriteLine("\t\t\t\t\t\t░░░░██▄");
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.WriteLine("\t\t\t\t\t\t░░░██▀░░░░▐");
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.WriteLine("\t\t\t\t\t\t▌░███▄░░░░▐");
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.WriteLine("\t\t\t\t\t\t▌▐███░▀▄███▄▄▄██▄▄");
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.WriteLine("\t\t\t\t\t\t▌█████▌░░▌░░░░░░▌");
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.WriteLine("\t\t\t\t\t\t▌▀▀▀▌▐█░░▌░░░░░░▌");
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.WriteLine("\t\t\t\t\t\t▌▀▀▀▌▐█░░▌░░░░░░▌");
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.WriteLine("\t\t\t\t\t\t▌░░░▌░█▄▌░░░░░░░▌");
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" \t\t\t\t\t Программа перевода слов в морзянку.\t");
            Console.Beep(784, 150);
            //**********************************************************************************

            Console.WriteLine("\n Введите целыми числом частоту сигнала от 37 до 32767 Гц.");
            Console.ForegroundColor = ConsoleColor.Red;
            ch = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Введите целыми числом Длительность сигнала (ТОЧКИ) в миллисекундах. (ТИРЕ) по умолчанию в два раза длиннее (СКОРОСТЬ Быстрая: 150-200; Средняя: 210-300; Медленная: 300 и более...) ");
            Console.ForegroundColor = ConsoleColor.Red;
            to = Convert.ToInt32(Console.ReadLine()); //Это точка
            ti = to * 3; // Это тире
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Введите Длительность паузы между символами в миллисекундах.(СКОРОСТЬ Быстрая: 10-20;  Медленная: 50-100) "); // время паузы
            Console.ForegroundColor = ConsoleColor.Red;
            inp = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Введите текст строковыми кирилическими символами для перевода в Морзянку:");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string words = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;

                /* 
                
                
                
                */


                //Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Введенное слово:" + words);
                int i = words.Length;
                Console.WriteLine(" Слово состоит из :" + i + " символов");
                for (i = 0; i < words.Length; i++)
                {
                    string simvol = Convert.ToString(words[i]);
                    Interpreter(simvol);

                }//for

                if (words == null)
                    break;
            }//while


            Console.ReadKey();

        }//Main

        private static void Interpreter(string simvol)
        {
            switch (simvol)
            {
                case "а":
                    Console.WriteLine(" Вы нажали букву а" + " . -");
                    //• —
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "б":
                    Console.WriteLine(" Вы нажали букву б" + " - . . .");
                    // — • • •
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "в":
                    Console.WriteLine(" Вы нажали букву в" + " . - -");
                    // • — —
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "г":
                    Console.WriteLine(" Вы нажали букву г" + "  - - .");
                    // — — •
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;
                case "д":
                    Console.WriteLine(" Вы нажали букву д" + " - . .");
                    // — • •
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "е":
                    Console.WriteLine(" Вы нажали букву е" + " .");
                    // •
                    dot(); // dot "."
                    break;
                case "ё":
                    Console.WriteLine(" Вы нажали букву ё" + " .");
                    // •
                    dot(); // dot "."
                    break;
                case "ж":
                    Console.WriteLine(" Вы нажали букву ж" + " . . . -");
                    // • • • —
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "з":
                    Console.WriteLine(" Вы нажали букву з" + " - - . .");
                    // — — • •
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "и":
                    Console.WriteLine(" Вы нажали букву и" + " . .");
                    // • •
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "й":
                    Console.WriteLine(" Вы нажали букву й" + " . - - -");
                    // • — — —
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "к":
                    Console.WriteLine(" Вы нажали букву к" + " - . - ");
                    // — • —
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "л":
                    Console.WriteLine(" Вы нажали букву л" + " . - . .");
                    // • — • •
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "м":
                    Console.WriteLine(" Вы нажали букву м" + " - -");
                    // — —
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "н":
                    Console.WriteLine(" Вы нажали букву н" + " - .");
                    // — •
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;
                case "о":
                    Console.WriteLine(" Вы нажали букву о" + " - - -");
                    // — — —
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "п":
                    Console.WriteLine(" Вы нажали букву п" + " . - - . ");
                    // • — — •
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;
                case "р":
                    Console.WriteLine(" Вы нажали букву р" + "  . - .");
                    // • — •
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;
                case "с":
                    Console.WriteLine(" Вы нажали букву с" + " . . .");
                    // • • •
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "т":
                    Console.WriteLine(" Вы нажали букву т" + " -");
                    // —
                    dash(); // dash "-"
                    break;
                case "у":
                    Console.WriteLine(" Вы нажали букву у" + " . . -");
                    //• • —
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "ф":
                    Console.WriteLine(" Вы нажали букву ф" + " . . - .");
                    // • • — •
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;
                case "х":
                    Console.WriteLine(" Вы нажали букву х" + " . . . .");
                    // • • • •
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "ц":
                    Console.WriteLine(" Вы нажали букву ц" + " - . - .");
                    // — • — •
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "ч":
                    Console.WriteLine(" Вы нажали букву ч" + " - - - .");
                    // — — — •
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;
                case "ш":
                    Console.WriteLine(" Вы нажали букву щ" + " - - - -");
                    // — — — —
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "щ":
                    Console.WriteLine(" Вы нажали букву щ" + " - - . -");
                    // — — • —
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "ъ":
                    Console.WriteLine(" Вы нажали букву ъ" + " - - . - -");
                    // — — • — —
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "ы":
                    Console.WriteLine(" Вы нажали букву ы" + " - . - - ");
                    // — • — —
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "ь":
                    Console.WriteLine(" Вы нажали букву ь" + " - . . -");
                    // — • • —
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-" 
                    break;
                case "э":
                    Console.WriteLine(" Вы нажали букву э" + " . . - . .");
                    // • • — • •
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "ю":
                    Console.WriteLine(" Вы нажали букву ю" + " . . - -");
                    // • • — —
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "я":
                    Console.WriteLine(" Вы нажали букву я " + " . - . -");
                    // • — • —
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "0":
                    Console.WriteLine(" Вы нажали цифру 0" + "  - - . .");
                    // — — • •
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "1":
                    Console.WriteLine(" Вы нажали цифру 1" + " . - - - -");
                    // • — — — —
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "2":
                    Console.WriteLine(" Вы нажали цифру 2" + " . . - - -");
                    // • • — — —
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "3":
                    Console.WriteLine(" Вы нажали цифру 3" + " . . . - -");
                    // • • • — —
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;
                case "4":
                    Console.WriteLine(" Вы нажали цифру 4" + " . . . . - ");
                    // • • • • —
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "5":
                    Console.WriteLine(" Вы нажали цифру 5" + " . . . . . ");
                    // • • • • •
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "6":
                    Console.WriteLine(" Вы нажали цифру 6" + " - . . . . ");
                    // — • • • •
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "7":
                    Console.WriteLine(" Вы нажали цифру 7" + " - - . . .");
                    // — — • • •
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "8":
                    Console.WriteLine(" Вы нажали цифру 8" + " - - - . .");
                    // — — — • •
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case "9":
                    Console.WriteLine(" Вы нажали цифру 9" + " - - - - .");
                    // — — — — •
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;
                case " ":
                    Console.WriteLine(" Вы нажали пробел " + " - . . . -");

                    // пробелы в задании. − · · · −
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case ".":
                    Console.WriteLine(" Вы нажали точку" + " . . . . . .");
                    // • • • • • •
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    break;
                case ",":
                    Console.WriteLine(" Вы нажали запятую" + " . - . - . -");
                    // • — • — • —
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case ":":
                    Console.WriteLine(" Вы нажали двоеточие" + " - - - . . .");
                    // — — — • • •
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."

                    break;
                case ";":
                    Console.WriteLine(" Вы нажали точку с запятой" + " - . - . -");
                    // — • — • —
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "(":
                    Console.WriteLine(" Вы нажали (" + " - . - - . -");
                    // — • — — • —
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case ")":
                    Console.WriteLine(" Вы нажали )" + " - . - - . -");
                    // — • — — • —
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "'":
                    Console.WriteLine(" Вы нажали '" + " . - - - - .");
                    // • — — — — •
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;
                //case """:
                //         Console.WriteLine("Вы нажали кавычки" );
                // • — • • — •
                //       break;

                case "-":
                    Console.WriteLine(" Вы нажали -" + " - . . . . -");
                    // — • • • • —
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;
                case "/":
                    Console.WriteLine(" Вы нажали /" + " - . . - .");
                    // — • • — •
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;

                case "?":
                    Console.WriteLine(" Вы нажали ?" + " . . - - . .");
                    // • • — — • •
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    break;

                case "!":
                    Console.WriteLine(" Вы нажали !" + " - - . . - -");
                    // — — • • — —
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    break;


                case "+":
                    Console.WriteLine(" Вы нажали +" + " . - . - . ");
                    // • − • − •
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;

                case "@":
                    Console.WriteLine(" Вы нажали @" + " . - - . - .");
                    //• — — • — •
                    dot(); // dot "."
                    dash(); // dash "-"
                    dash(); // dash "-"
                    dot(); // dot "."
                    dash(); // dash "-"
                    dot(); // dot "."
                    break;

                case "=":
                    Console.WriteLine(" Вы нажали =" + " - . . . -");
                    //− • • • −
                    dash(); // dash "-"
                    dot(); // dot "."
                    dot(); // dot "."
                    dot(); // dot "."
                    dash(); // dash "-"
                    break;


                default:
                    Console.WriteLine(" Вы нажали неизвестный программе символ(ы) " + simvol);
                    break;

            }// switch
        }

        private static void dash()
        {
            Console.Beep(ch, ti); Thread.Sleep(inp); // dash "-"  ИЗМЕНЕНИЕ ДЛИТЕЛЬНОСТИ "-"
        }

        private static void dot()
        {
            Console.Beep(ch, to); Thread.Sleep(inp);  // dot "."  ИЗМЕНЕНИЕ ДЛИТЕЛЬНОСТИ "."
        }

    }//Programm

}//name