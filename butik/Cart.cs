﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butik
{
    internal class Cart
    {
        

        //summan till alla priser i produkter
        public static double totalFruit = Order.fruitlist.Sum(item => item.TotalPrice);
        public static double totalCandy = Order.candylist.Sum(item => item.TotalPrice);
        public static double totalDrink = Order.drinklist.Sum(item => item.TotalPrice);

        
        

        public static int total = (int)((Cart.totalFruit + Cart.totalCandy )+ Cart.totalDrink);
        
        //Kundvang skriva ut 
        public static void printCart(string[]? args)
        {
            Console.Clear();
           
            //Anroppa logo 
            Program.logo();
            Console.WriteLine("                    VARUKORGEN\n" +
                              "-------------------------------------------------------" +
                              "\nProduker           koster * Antal       Totalkosnad" + 
                              "\n-----------------------------------------------------");
            Order.fruitList();
            Order.candyList();
            Order.drinkList();

            Console.WriteLine("-----------------------------------------------------\n" +
                "\nTotalt SEK                                     " + total + ";-");


            //användare ska få alternativ 
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

        
    }


   
}
