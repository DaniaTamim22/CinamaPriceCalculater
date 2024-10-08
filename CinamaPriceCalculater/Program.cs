﻿using CinamaPriceCalculater.Helpers;
using System.Diagnostics;

namespace CinamaPriceCalculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = true;

            do
            {

                MenuHelpers.ShowMainMenu();
                uint input = Util.AskForUInt("Enter your choice");
                int ticketPrice = 0;
                switch (input)
                {
                    case MenuHelpers.Quit:
                        {
                            isAlive = false;
                            break;
                        }
                    case MenuHelpers.singelPrice:
                        {
                            MenuHelpers.ShowSingleMenu();
                            ticketPrice = getPersonPrice();
                            Console.WriteLine($"Your Ticket price is : {ticketPrice} KR");
                            break;
                        }
                    case MenuHelpers.groupPrice:
                        {
                            MenuHelpers.ShowGroupMenu();
                            getGroupPrice();
                            break;
                        }
                    case MenuHelpers.repeateTenTimes:
                        {
                            MenuHelpers.ShowRepeatTenTimesMenu();
                            getTenTimes();
                            break;
                        }
                    case MenuHelpers.thirdWord:
                        {
                            MenuHelpers.ShowGetThirdWordMenu();
                            getThirdWord();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You Entered Unvalid Number!! Please Enter a number from the menu below :\n");
                            break;
                        }

                }


            } while (isAlive);

        }



        private static int getPersonPrice()
        {
            int personPrice = 0;
            uint age = 0;
            age = Util.AskForUInt("Age");
            if (age < 5 || age > 100)
            {
                personPrice = 0;
            }
            else if (age > 64)
            {
                personPrice = 90;
            }
            else if (age < 20)
            {
                personPrice = 80;
            }
            else
            {
                personPrice = 120;
            }
            return personPrice;
        }

        private static void getGroupPrice()
        {
            uint numOfPersons = 0;
            int groupPrice = 0;
            numOfPersons = Util.AskForUInt("Num of Persons");

            for (int i = 0; i < numOfPersons; i++)
            {
                Console.WriteLine("Enter person age :\n");
                groupPrice += getPersonPrice();

            }
            Console.WriteLine($"Your Group have {numOfPersons} persons \n Total Price is : {groupPrice} KR \n");

        }
        private static void getTenTimes()
        {
            string text = Util.AskForString("Text");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}.{text}");
            }
            Console.WriteLine();

        }


        private static void getThirdWord()
        {
            string text = Util.AskForString("Text");
            var textParts = text.Split(' ');
            //if (textParts.Contains(" ") {   }
            if (textParts.Length < 3)
            {
                Console.WriteLine("Please enter a text with minimun 3 words ");
                getThirdWord();
            }
            else
            {
                Console.WriteLine($" The third word you entered is :{textParts[2]}\n");

            }

        }
    }
}
