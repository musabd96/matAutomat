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

        
        public static List<int> automaticMachine= new List<int>();
        public static void wallet()
        {
            int cash;
            Dictionary<int, int> wallet = new Dictionary<int, int>();
            wallet.Add(500, 10);
            wallet.Add(100, 10);
            wallet.Add(50,  10);
            wallet.Add(20,  10);
            wallet.Add(10,  10);
            wallet.Add(5,   10);
            wallet.Add(2,   10);
            wallet.Add(1,   10);


            Console.WriteLine("\n     PLÅNBOK \n" +
                              "------------------\n");

            foreach (var currency in wallet)
            {
                Console.WriteLine("{0} ----------> {1}", currency.Key, currency.Value);

            }

            

            Console.Write("" +
                                    "\nAnge pengar i automaten här: ");

            int customerMoney = Convert.ToInt32(Console.ReadLine());

            cash = customerMoney;

            automaticMachine.Add(cash);
            Console.Clear();
            Program.logo();

            

        }
    }
}
