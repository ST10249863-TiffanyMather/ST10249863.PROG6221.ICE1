using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class ElectronicsProduct : Product
    {
        //fields
        private readonly string brand;
        private readonly string model;

        //properties
        public string Brand { get { return brand; } }
        public string Model { get { return model; } }

        //constructor 
        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model) : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        //method 
        // override - child
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Brand of product: " + brand);
            Console.WriteLine("Model of product: " + model);
        }
    }
}