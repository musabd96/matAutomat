using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace butik
{
    internal class Order
    {
        public static List<Fruit> fruitlist = new List<Fruit>();
        public static List<Candy> candylist = new List<Candy>();
        public static List<Drink> drinklist = new List<Drink>();

        
        
        public static void fruitList()
        {


            foreach (Fruit fruit in fruitlist)
            {

                Console.WriteLine("{0,-20} {1,2}kr/kg * {2}kg {3,15};- ",
                    fruit.Name, fruit.Price,
                    fruit.Quantity, fruit.TotalPrice);

            }

        }
      
        public static void candyList()
        {
            foreach (Candy godis in Order.candylist)
            {

                Console.WriteLine("{0,-20} {1,2}kr/st * {2}st {3,15};- ",
                    godis.Name, godis.Price,
                    godis.Quantity, godis.TotalPrice);

            }
        }
        public static void drinkList()
        {
            foreach (Drink drink in Order.drinklist)
            {

                Console.WriteLine("{0,-20} {1,2}kr/st * {2}st {3,15};- ",
                    drink.Name, drink.Price,
                    drink.Quantity, drink.TotalPrice);

            }
        }

        

        public static void total()
        {
            double total = fruitlist.Sum(item => item.TotalPrice);

            Console.WriteLine(total);
        }

        
    }
}
