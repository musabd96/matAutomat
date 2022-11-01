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

                Console.WriteLine("{0}             {1}kr/kg * {2}st               {3};- ",
                    fruit.Name, fruit.Price,
                    fruit.Quantity, fruit.TotalPrice);

            }

        }
      
        public static void godisList()
        {
            foreach (Candy godis in Order.candylist)
            {

                Console.WriteLine("{0}             {1}kr/kg * {2}st               {3};- ",
                    godis.Name, godis.Price,
                    godis.Quantity, godis.TotalPrice);

            }
        }
        public static void drinkList()
        {
            foreach (Drink drink in Order.drinklist)
            {

                Console.WriteLine("{0}             {1}kr/kg * {2}st               {3};- ",
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
