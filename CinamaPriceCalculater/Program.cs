using CinamaPriceCalculater.Helpers;
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
                int input = int.Parse(Console.ReadLine());
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
            int age = 0;
            age = int.Parse(Console.ReadLine());
            if (age > 64)
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
        }


        private static int calculateGroupPrice(int numOfPersons)
        {
            int groupPrice = 0;
            for (int i = 0; i < numOfPersons; i++)
            {

            }
            return groupPrice;
        }
    }
}
