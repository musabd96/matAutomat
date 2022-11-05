using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace butik
{
    internal class Wallet
    {
        public int costomerMoney { get; set; }

        //List till automaten för att mata in pengar användare
        public static List<int> automaticMachine = new List<int>();
        public static void wallet()
        {
           while (true)
            {
                //Kund plånboken
                int cash;
                int totalCash = 6880;
                Dictionary<int, int> wallet = new Dictionary<int, int>();
                wallet.Add(500, 10);
                wallet.Add(100, 10);
                wallet.Add(50, 10);
                wallet.Add(20, 10);
                wallet.Add(10, 10);
                wallet.Add(5, 10);
                wallet.Add(2, 10);
                wallet.Add(1, 10);



                Console.WriteLine("\n     PLÅNBOK \n" +
                                  "------------------\n");
                //skriva ut plånboken
                foreach (var currency in wallet)
                {
                    Console.WriteLine("{0,5} ----------> {1}", currency.Value, currency.Key);

                }
                Console.WriteLine("----------------------\n" +
                                  "Totalt:           " + totalCash + " SEK");

                //Anvandare ska mata in pengar 

                Console.Write("" +
                                        "\nAnge pengar i automaten här: ");

                int customerMoney = Convert.ToInt32(Console.ReadLine());

                if (customerMoney <= 6880)
                {
                    cash = customerMoney;

                    automaticMachine.Add(cash);
                    Console.Clear();
                    Program.logo();
                    break;

                }
                else
                {
                    Console.Clear();
                    Program.logo();
                    Console.WriteLine("\nPlånboken finns inte tillräckligt med pengar." +
                                                  "\nSaldo är: " + customerMoney + " SEK");
                }

            }
            


        }
       public static void remove()
        {
            Wallet.automaticMachine.Clear();
        }
    }
}
