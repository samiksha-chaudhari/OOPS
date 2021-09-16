using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public class stockData  //created class contact
    {
        //by using encapsulation
        public string ShareName { get; set; } //property
        public int NoOfShares { get; set; }
        public int PricePerEachShare { get; set; }

    }
    public class Stock
    {
        //list declaration to store the personal details
        List<stockData> liststock = new List<stockData>();
        public void add() //creating method to add data
        {                     
            Console.WriteLine("Enter Number Of Stocks:-");
            int NumberOfStocks = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NumberOfStocks; i++) //for loop till number of stocks
            {
                Console.WriteLine("Enter ShareName:-");
                string ShareName = Console.ReadLine();

                Console.WriteLine("Enter Total Number Of Shares:-");
                int NoOfShares = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Price Per Share:-");
                int PricePerEachShare = Convert.ToInt32(Console.ReadLine());

                //adding the details in list
                liststock.Add(new stockData()
                 {
                     ShareName = ShareName,
                     NoOfShares = NoOfShares,
                     PricePerEachShare = PricePerEachShare,
                 });

                Stockvalue(NoOfShares, PricePerEachShare, ShareName);//calling stockvalue()
            }
        }

        public void show() //creating method to view data
        {
            foreach (var i in liststock)
            {
                Console.WriteLine("Share Name :" + i.ShareName);
                Console.WriteLine("No. of Shares :" + i.NoOfShares);
                Console.WriteLine("Price for Each Share :" + i.PricePerEachShare);
            }

        }

        public void Stockvalue(int p, int q, string r)//creating method
        {
            // variable declaration
            int totalPrice = 0;

            int stockPrice = p * q; //calculating stock price
            Console.WriteLine("The Price for stock " + r + " shares is :  " + stockPrice);
            totalPrice += (p * q);
            Console.WriteLine("the total price of the stock is  " + totalPrice);
        }

        public void option()
        {
            Console.WriteLine("Welcome to Stock Account Management!");
            Console.WriteLine("1.Add stock  2.View Stock  3.Exit");
            Console.WriteLine("Choose Option :");
            int ch = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user
            int def = 0;//counter to break the while loop

            while (def == 0)
            {
                switch (ch)  //switch case
                {
                    case 1:
                        add();//calling add() from stock.cs
                        break;

                    case 2:
                        show();
                        break;

                    default:
                        Console.WriteLine("Exit");//default condition
                        def++;
                        break;
                }
            }
        }
    }
}