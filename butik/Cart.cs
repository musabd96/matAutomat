using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butik
{
    internal class Cart
    {
        private static string[]? args;

        public static void printCart(string[]? args)
        {

            double totalFruit = Order.fruitlist.Sum(item => item.fruitTotalPrice);
            double totalGodis = Order.godislist.Sum(item => item.godisTotalPrice);
            double totalDrink = Order.drinklist.Sum(item => item.drinkTotalPrice);


            int total = (int)(totalFruit + totalGodis + totalDrink);

            Console.Clear();
            //Anroppa logo 
            Program.logo();
            Console.WriteLine("                    VARUKORGEN\n" +
                "-------------------------------------------------------" +
                "\nProduker              koster * Antal            Totalkosnad" + 
                "\n-----------------------------------------------------");
            Order.fruitList();
            Order.godisList();
            Order.drinkList();

            Console.WriteLine("-----------------------------------------------------\n" +
                "\nTotalt SEK                                     " + total + ";-");

            Console.WriteLine("\n\n\n\n\n1. Beställa mer.\n" +
                        "2. Betaling.\n" +
                        "\nVälj en alternativ mellam 1 till 2");
            int output = Convert.ToInt32(Console.ReadLine());

            if (output == 1)
            {
                Console.Clear();
                Program.productMenu(args);

            }
            else if (output == 2)
            {
                Purchase.Cost();
            }
            else
            {
                Console.Clear();
                //Anroppa logo 
                Program.logo();

                Console.WriteLine("                    OBS!!!\n" +
                                  "----------------------------------------------\n" +
                                  "Var snäll välja em alternativ mellan 1 till 5!");

            }





        }
        public static void remove()
        {
            Order.fruitlist.Clear();
            Order.godislist.Clear();
            Order.drinklist.Clear();

            Order.fruitList();
            Order.godisList();
            Order.drinkList();

        }
    }


   
}
