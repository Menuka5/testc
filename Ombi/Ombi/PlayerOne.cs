using System;
using System.Collections.Generic;
using System.Linq;


namespace Ombi
{
    class PlayerOne
    {
        private List<string> firstSet;

        public PlayerOne(List<string> cards)
        {
            firstSet = new List<string>(cards);
        }

        public string intialStep()
        {
            Random rand = new Random();
            int frstcrd = rand.Next(0, firstSet.Count);
            string send = firstSet[frstcrd];
            return send;
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
            firstSet.RemoveAt(frstcrd);
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
