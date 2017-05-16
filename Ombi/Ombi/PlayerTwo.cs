using System;
using System.Collections.Generic;
using System.Linq;

namespace Ombi
{
    class PlayerTwo
    {
        private List<string> firstSet;
        public PlayerTwo(List<string> cards)
        {
            //string myString = "A";
            firstSet = new List<string>(cards);
            //IEnumerable<string> matchingvalues = firstSet.Where(stringToCheck => stringToCheck.Contains(myString));
            //foreach (string item in matchingvalues)
            //{
            //    Console.WriteLine(item + "IENum");
            //}
        }

        public IEnumerable<string> sendSimilarCards(string card)
        {
            IEnumerable<string> matchingvalues = firstSet.Where(stringToCheck => stringToCheck.Contains(card[0]));
            return matchingvalues;
        }

        public string sendRandomCard()
        {
            Random rand = new Random();
            int frstcrd = rand.Next(0, firstSet.Count);
            string send = firstSet[frstcrd];
            //firstSet.RemoveAt(frstcrd);
            return send;
        }

        public void removeCard(string crd)
        {
            firstSet.Remove(firstSet[1]);
        }

        public void currentPack()
        {
            foreach (string item in firstSet)
            {
                Console.Write(item);
            }
        }
    }
}
