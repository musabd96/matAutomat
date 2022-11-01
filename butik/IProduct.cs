using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butik
{
    internal interface IProduct
    {
        string Name { get; set; }

        int Price { get; set; }

        int Quantity { get; set; }

        int TotalPrice { get; set; }

        string ToString();

        


    }
}
