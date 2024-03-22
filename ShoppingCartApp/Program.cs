using static ShoppingCartApp.ShoppingCart;

namespace ShoppingCartApp
{

    class main
    {
        static void Main(string[] args)
        {
            //shopping cart object initialised
            ShoppingCart cart = new ShoppingCart(10);

            do
            {
                //prompt user
                Console.WriteLine("Choose the type of product:");
                Console.WriteLine("1. Clothing");
                Console.WriteLine("2. Electronics");
                Console.WriteLine("\nEnter the number below:");
                int choice = int.Parse(Console.ReadLine());

                //decalre variables
                string name, brand, model, size, color;
                double price;
                ProductCategory category;

                //store details in variables
                Console.WriteLine("\n");
                Console.WriteLine("Enter product name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter product price:");
                price = double.Parse(Console.ReadLine());

                //ask for details accoriding to the type of product
                switch (choice)
                {
                    //clothing
                    case 1:
                        category = ProductCategory.Clothing;
                        Console.WriteLine("Enter size:");
                        size = Console.ReadLine();
                        Console.WriteLine("Enter color:");
                        color = Console.ReadLine();
                        Console.WriteLine("\n");

                        //create ClothingProduct object
                        ClothingProduct clothingProduct = new ClothingProduct(name, price, category, size, color);

                        //add product to shopping cart
                        cart.AddProduct(clothingProduct);
                        break;

                    //electronics
                    case 2:
                        category = ProductCategory.Electronics;
                        Console.WriteLine("Enter brand:");
                        brand = Console.ReadLine();
                        Console.WriteLine("Enter model:");
                        model = Console.ReadLine();
                        Console.WriteLine("\n");

                        //create ElectronicsProduct object
                        ElectronicsProduct electronicsProduct = new ElectronicsProduct(name, price, category, brand, model);

                        //add product to shopping cart
                        cart.AddProduct(electronicsProduct);
                        break;

                    //error handling
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                //ask the user if they want to add another item
                Console.WriteLine("Do you want to add another item? (yes/no)");
            } while (Console.ReadLine().ToLower() == "yes");

            // Ask user if they want to remove an item
            Console.WriteLine("\nDo you want to remove an item? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.WriteLine("Enter the index of the item you want to remove:");
                int index = int.Parse(Console.ReadLine()) - 1; // Adjust for zero-based indexing
                cart.RemoveProduct(index);
            }

            Console.WriteLine("\nDo you want to display the items? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                //display contents of the cart
                Console.WriteLine("\nContents of the shopping cart:");
                cart.DisplayCart();
            }
        }
    }
}