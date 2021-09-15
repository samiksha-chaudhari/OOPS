using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class Cards
    {
        int PlayerCards = 9; //variable to destibute 9 cards
        public string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" }; //for cards type
        public string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };//for rank
        public string[] players = { "1", "2", "3", "4" }; // for 4 players


        public void CardsCreator() //creating method
        {
            int index = 0;

            string[,] Cards = new string[suits.Length, rank.Length];
            string[] newCards = new string[52];
            string[,] playersCards = new string[players.Length, PlayerCards];

            for (int i = 0; i < suits.Length; i++) //for suits, length 4
            {
                for (int j = 0; j < rank.Length; j++)//for rank, length 13
                {
                    Cards[i, j] = String.Concat(suits[i] + "-" + rank[j]); //for concat suits & rank
                    newCards[index] = Cards[i, j];
                    index++;
                }
            }
            Random random = new Random();
            int randomCard;
            for (int i = 0; i < newCards.Length; i++)
            {
                randomCard = random.Next(0, newCards.Length); //for choosing random card
                //Swap the selected item  with the last "unselected" card in the collection 
                //to avoid repetation
                string temp = newCards[i]; //temporary store i value to temp
                newCards[i] = newCards[randomCard];//store randam card at ith position
                newCards[randomCard] = temp;//store temp to random card position for shuffle
            }
            int counter = 0;
            // to destribute cards between 4 players
            for (int i = 0; i < players.Length; i++)
            {
                for (int j = 0; j < PlayerCards; j++)
                {
                    playersCards[i, j] = newCards[counter];
                    counter++;
                }
            }
            Display(playersCards); //calling disply()
        }
        public void Display(string[,] playersCards) //method for cards display
        {
            for (int i = 0; i < players.Length; i++) //for players
            {
                Console.WriteLine("Player {0} cards:", i + 1);
                for (int j = 0; j < 9; j++) //for printing cards
                {
                    Console.WriteLine(playersCards[i, j]); //print cards
                }
                Console.WriteLine("\n");

            }
        }


    }
}