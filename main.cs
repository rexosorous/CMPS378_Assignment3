using System;

/*
Author: J-Zach Loke
Class: CMPS-378
Due Date: 10/07/2021
Description:
    This program uses switch statements to give some information based on the user's birthday
*/

namespace Assignment3
{
    class MainClass
    {
        /* The root / driver of the program */
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Birthday Date Meaning Generator!");
            while (true) {
                // collect inputs of the user
                Console.Write("Please enter the month of your birthday: ");
                string month = Console.ReadLine();
                Console.Write("Please enter the day of your birthday: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the year of your birthday: ");
                int year = Convert.ToInt32(Console.ReadLine());

                // display info about the month
                Console.Write($"\nThe month of {month} means ");
                switch (month) {
                    case "January":
                        Console.WriteLine("Janus");
                        break;
                    case "February":
                        Console.WriteLine("februalia");
                        break;
                    case "March":
                        Console.WriteLine("Mars");
                        break;
                    case "April":
                        Console.WriteLine("aperire");
                        break;
                    case "May":
                        Console.WriteLine("Maia");
                        break;
                    case "June":
                        Console.WriteLine("youth");
                        break;
                    case "July":
                        Console.WriteLine("Julius Caesar");
                        break;
                    case "August":
                        Console.WriteLine("Augustus Caesar");
                        break;
                    case "September":
                        Console.WriteLine("seven");
                        break;
                    case "October":
                        Console.WriteLine("eight");
                        break;
                    case "November":
                        Console.WriteLine("nine");
                        break;
                    case "December":
                        Console.WriteLine("ten");
                        break;
                }

                // display info about the day
                switch (day) {
                    case 1:
                        Console.WriteLine($"The 1st of {month} means Self-Started");
                        break;
                    case 2:
                        Console.WriteLine($"The 2nd of {month} means Solution Finder");
                        break;
                    case 3:
                        Console.WriteLine($"The 3rd of {month} means Communicator");
                        break;
                    case 4:
                        Console.WriteLine($"The 4th of {month} means Stability & Rationality");
                        break;
                    case 5:
                        Console.WriteLine($"The 5th of {month} means Flexibility");
                        break;
                    case 6:
                        Console.WriteLine($"The 6th of {month} means Heart");
                        break;
                    case 7:
                        Console.WriteLine($"The 7th of {month} means Mind");
                        break;
                    case 8:
                        Console.WriteLine($"The 8th of {month} means Success");
                        break;
                    case 9:
                        Console.WriteLine($"The 9th of {month} means Compassion");
                        break;
                    case 10:
                        Console.WriteLine($"The 10th of {month} means Leadership");
                        break;
                    case 11:
                        Console.WriteLine($"The 11th of {month} means Awareness");
                        break;
                    case 12:
                        Console.WriteLine($"The 12th of {month} means Creativity");
                        break;
                    case 13:
                        Console.WriteLine($"The 13th of {month} means Conscientious");
                        break;
                    case 14:
                        Console.WriteLine($"The 14th of {month} means Open-Minded");
                        break;
                    case 15:
                        Console.WriteLine($"The 15th of {month} means Love");
                        break;
                    case 16:
                        Console.WriteLine($"The 16th of {month} means Inquisitive");
                        break;
                    case 17:
                        Console.WriteLine($"The 17th of {month} means Quality");
                        break;
                    case 18:
                        Console.WriteLine($"The 18th of {month} means Ambition");
                        break;
                    case 19:
                        Console.WriteLine($"The 19th of {month} means Independence");
                        break;
                    case 20:
                        Console.WriteLine($"The 20th of {month} means Cooperative");
                        break;
                    case 21:
                        Console.WriteLine($"The 21st of {month} means Socially Active");
                        break;
                    case 22:
                        Console.WriteLine($"The 22nd of {month} means Creator");
                        break;
                    case 23:
                        Console.WriteLine($"The 23rd of {month} means Experience");
                        break;
                    case 24:
                        Console.WriteLine($"The 24th of {month} means Stable Relationship");
                        break;
                    case 25:
                        Console.WriteLine($"The 25th of {month} means Curiosity");
                        break;
                    case 26:
                        Console.WriteLine($"The 26th of {month} means Success");
                        break;
                    case 27:
                        Console.WriteLine($"The 27th of {month} means Compassion");
                        break;
                    case 28:
                        Console.WriteLine($"The 28th of {month} means Compassionate Leader");
                        break;
                    case 29:
                        Console.WriteLine($"The 29th of {month} means Insight");
                        break;
                    case 30:
                        Console.WriteLine($"The 30th of {month} means Original");
                        break;
                    case 31:
                        Console.WriteLine($"The 31st of {month} means Practical & Immaginative");
                        break;
                }

                Console.WriteLine($"The year of {year} means that you are a millenial");

                Console.Write("Would you like to try another one? ");
                var cont = Console.ReadLine();
                Console.WriteLine("\n\n");
                if (cont == "N") {
                    Console.WriteLine("Thanks for paying!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}