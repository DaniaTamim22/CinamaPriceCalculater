using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinamaPriceCalculater.Helpers
{
    public static class MenuHelpers
    {
        public const int singelPrice = 1;
        public const int groupPrice = 2;
        public const int repeateTenTimes = 3;
        public const int thirdWord = 4;
        public const int Quit = 0;



        public static void ShowMainMenu()
        {
            Console.WriteLine($"Welcome to Cinama Price Calculator ... \n" +
                $"Please enter your choice to proceed ..\n" +
                $"{singelPrice} Enter your age to show the price \n" +
                $"{groupPrice} Calculate tickets Price for a group .\n"+
                 $"{repeateTenTimes} Enter some text and you get it ten times !! .\n" +
                  $"{thirdWord} Enter text and get the third word ! .\n" +
                $"{Quit } Close the program .\n");
        }


        public static void ShowSingleMenu()
        {
            Console.WriteLine("Welcome to Price Calculator for a Person... \n" +
                "Please enter your age to get your ticket price ..\n");
               
        }

        public static void ShowGroupMenu()
        {
            Console.WriteLine("Welcome to Price Calculator for Groups... \n" +
                "Please enter the number of persons in your group :\n");

        }
        public static void ShowRepeatTenTimesMenu()
        {
            Console.WriteLine("Enter a text to play and get it ten times ! \n");

        }

        public static void ShowGetThirdWordMenu()
        {
            Console.WriteLine("Enter a text to play and get the third word in it !\n"); 
                

        }
    }
}
