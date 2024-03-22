using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class ShoppingCart
    {
        //fields
        private Product[] Products;
        private int itemCount;

        //properties
        private readonly Product[] products;
        private readonly int ItemCount;

        //constructor 
        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
        }

        //method 
        public void AddProduct(Product product)
        {
            if (product.Category.Equals(ProductCategory.Clothing))
            {
                products[itemCount] = product;
                itemCount++;
                Console.WriteLine("The item number " + itemCount + " has been added to your cart");
            }

            if (product.Category.Equals(ProductCategory.Electronics))
            {
                products[itemCount] = product;
                itemCount++;
                Console.WriteLine("The item number " + itemCount + " has been added to your cart");
            }

        }

        public void RemoveProduct(int index)
        {
            if (index >= 0 && index < itemCount)
            {
                for (int i = index; i < itemCount - 1; i++)
                {
                    products[i] = products[i + 1];
                }
                products[itemCount - 1] = null;
                itemCount--;
                Console.WriteLine("Product has been removed from your cart");
            }
            else
            {
                Console.WriteLine("Invalid index. Product not found in your cart");
            }
        }

        public void DisplayCart()
        {
            Console.WriteLine("Items in your cart:" + itemCount + "\n");
            for (int i = 0; i < itemCount; i++)
            {
                products[i].GetInfo();
                Console.WriteLine();
            }
        }

    }
}
