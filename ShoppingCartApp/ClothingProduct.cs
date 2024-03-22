using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class ClothingProduct : Product
    {
        //fields
        private readonly string size;
        private readonly string color;

        //properties 
        public string Size { get { return size; } }
        public string Color { get { return color; } }

        //constructor 
        public ClothingProduct(string name, double price, ProductCategory category, string size, string color) : base(name, price, category)
        {
            this.size = size;
            this.color = color;
        }

        //method
        // override - child
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Size of product: " + size);
            Console.WriteLine("Colour of product: " + color);
        }

    }
}