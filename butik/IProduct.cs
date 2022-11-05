using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace butik
{
    //Interface klass till produkt klasses
    internal interface IProduct
    {
        

        string Name { get; }
        int Price { get; }
        int Quantity { get; }
        int TotalPrice { get; }
        
        void description();
        void use();
        void buy();

        
        

    }
}
