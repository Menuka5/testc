using System;
using System.Collections.Generic;
using System.Linq;

namespace Ombi
{
    class Narrator
    {
        List<string> pack = new List<string>();
        static int playerOneScore = 0;
        static int playerTwoScore = 0;
        PlayerOne player1;
        PlayerTwo player2;
        public void initiate()
        {
            char[] cards = {'A', 'B', 'C', 'D'};

            foreach (char ltr in cards)
            {
                for (int i = 1; i < 14; i++)
                {
                    pack.Add(string.Concat(ltr, i));
                }
            }



        }

        public List<string> sendCards()
        {
            List<string> sendCards = new List<string>();

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int cardNum = rand.Next(0, pack.Count);
                sendCards.Add(pack[cardNum]);
                pack.RemoveAt(cardNum);
            }
            
            return sendCards;
        }

        public void NextTurn()
        {
            Console.WriteLine("Test");
            player1.currentPack();
        }

        public void gameBegin(PlayerOne playerOne, PlayerTwo playerTwo)
        {
            List<string> pOne = new List<string>();
            List<string> pTwo = new List<string>();
            pOne.Add("one");
            pOne.Add(playerOne.sendRandomCard());
            pTwo.Add("two");
            this.player1 = playerOne;
            this.player2 = playerTwo;

            //Console.WriteLine(" random" + pOne[1]);


            IEnumerable<string> pTwoSendCards = playerTwo.sendSimilarCards(pOne[1]);
            //Console.WriteLine(pTwoSendCards.Any() + " "+pTwoSendCards.Count());
            //if (true)
            if (!pTwoSendCards.Any())
            {
                pTwo.Add(playerTwo.sendRandomCard());
                playerOneScore++;
                playerOne.removeCard(pOne[1]);
                playerTwo.removeCard(pTwo[1]);

            }
            else
            {

            }

            Console.WriteLine(playerOneScore);
            
        }


        public void printCurrentPack()
        {
            foreach (string item in pack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
