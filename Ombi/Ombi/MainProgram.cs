using System;
using System.Collections.Generic;
using System.Text;

namespace Ombi
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Narrator narrator = new Narrator();
            narrator.initiate();
            //narrator.sendCards();

            PlayerOne playerOne = new PlayerOne(narrator.sendCards());
            PlayerTwo playerTwo = new PlayerTwo(narrator.sendCards());

            narrator.gameBegin(playerOne, playerTwo);
            narrator.NextTurn();
            //narrator.printCurrentPack();

            //playerOne.currentPack();
            //playerTwo.currentPack();
            Console.Read();
        }
    }
}
