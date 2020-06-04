using System;
using System.Collections.Generic;
using System.Text;

namespace Sea_Battle.Model
{
    class Player
    {
        public string Name { get; }
        private Board PlayerBoard { get; }

        public Player(string name, Board board)
        {
            this.Name = name;
            this.PlayerBoard = board;
        }

        public bool HasShip()
        {
            if (this.PlayerBoard.IsShip())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
