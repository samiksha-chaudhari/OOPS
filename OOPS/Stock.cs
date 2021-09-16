using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public class Stock
    {   
        //instance variable declaration
        public int totalshare = 0;
        public int totalPrice = 0;

        public void add() //creating method
        {
            Console.WriteLine("Enter Number Of Stocks:-");
            int NumberOfStocks = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NumberOfStocks; i++) //for loop till number of stocks
            {
                Console.WriteLine("Enter ShareName:-");
                string ShareName = Console.ReadLine();

                Console.WriteLine("Enter Total Number Of Shares:-");
                int NoOfShares = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Price Per Share:-");
                int PricePerEachShare = int.Parse(Console.ReadLine());

                Stockvalue(NoOfShares, PricePerEachShare, ShareName);//calling stockvalue()
            }
        }
        public void Stockvalue(int p, int q, string r)//creating method
        {
            int stockPrice = p * q; //calculating stock price
            Console.WriteLine("The Price for stock " + r + " shares is :  " + stockPrice);
            totalPrice += (p * q);
            Console.WriteLine("the total price of the stock is  " + totalPrice);
        }
    }
}