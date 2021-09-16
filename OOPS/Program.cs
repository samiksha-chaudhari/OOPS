using System;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)    //main method
        {

            int defcount = 0;//counter to break the while loop

            while (defcount == 0)
            {

                Console.WriteLine("------------------------Welcome to OOPS-----------------------");
                Console.WriteLine("1.Inventory Management  2.Deck of Cards  3.Stock Management  4.Exit");
                Console.WriteLine("Choose Option :");
                int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user

                switch (choice)  //switch case
                {
                    case 1:
                        Console.WriteLine("Welcome to Inventory Management");
                        Inventory_Manager inventoryData = new Inventory_Manager(); //create object to call InventoryData() 
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        Console.WriteLine("Welcome to Deck Of Cards");
                        Console.WriteLine("\n");
                        Cards cards = new Cards(); //creating object to call cards()
                        cards.CardsCreator();  //calling cards()
                        break;
                    case 3:
                        Stock stock = new Stock();
                        Console.WriteLine("Welcome to Stock Account Management!");
                        Console.WriteLine("************************************");
                        Console.WriteLine("Enter Number Of Stocks:-");
                        int NumberOfStocks = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= NumberOfStocks; i++)
                        {
                            Console.WriteLine("Enter ShareName:-");
                            string ShareName = Console.ReadLine();

                            Console.WriteLine("Enter Total Number Of Shares:-");
                            int NoOfShares = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Price Per Share:-");
                            int PricePerEachShare = int.Parse(Console.ReadLine());

                            stock.Stockvalue(NoOfShares, PricePerEachShare, ShareName);
                        }
                        break;

                    default:
                        Console.WriteLine("End");//default condition
                        defcount++;
                        break;

                }



            }
        }
    }
}
