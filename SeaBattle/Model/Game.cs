using System;
using System.Collections.Generic;
using System.Text;

namespace Sea_Battle.Model
{
    class Game
    {
        Player[] Players { get; }
        int Round { get; }

        public Game(int boardSize, string name1, string name2 = "AI")
        {
            this.Players = new Player[] { new Player(name1, new Board(boardSize)), new Player(name2, new Board(boardSize)) };
            this.Round = 0;
        }

        private bool EndOfMatch()
        {
            if (this.Players[0].HasShip() && this.Players[1].HasShip())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Play()
        {
            while (!EndOfMatch())
            {
                // not to forget removing ship from board if gets destroyed
            }
            
        }
    }
}
