using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    //enum (ProductCategory) - data type that represents a set of named constants
    enum ProductCategory
    {
        Clothing,
        Electronics,
        Home,
        Beauty,
        Groceries
    }

    //Parent class
    class Product
    {
        //declare fields
        private string name;
        private double price;
        private ProductCategory category;

        //properties - get set
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductCategory Category { get; set; }

        //constructor 
        // capital get set (L)
        // lowercase fields (R)
        public Product(string name, double price, ProductCategory category) {
            Name = name;
            Price = price;
            Category = category;            
        
        }

        //method 
        // virtual - parent 
        public virtual void GetInfo()
        {
            Console.WriteLine("Name of the product: " + Name);
            Console.WriteLine("Price of the product: " +  Price);
            Console.WriteLine("Category of the product: " + Category);
        }
    }
}
