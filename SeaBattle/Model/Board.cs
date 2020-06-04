using System;
using System.Collections.Generic;
using System.Text;

namespace Sea_Battle
{
    /// <summary>
    /// Class for representing a Board in a game of Battleship
    /// </summary>
    class Board
    {
        /// <value>A Two-dimensional array, representing the grid of the board</value>
        public Tile[,] Grid{ get; }

        ///<value>The number of rows and columns on the <c>Board</c></value> 
        public int Size { get; }

        /// <value>The list of the ships on the <c>Board</c></value>
        public List<Ship> Ships { get; }

        /// <summary>
        /// Initializes a new instance of the <c>Board</c> class
        /// </summary>
        /// <param name="size">The length of the sides of the Board</param>
        public Board(int size)
        {
            this.Size = size;
            this.Grid = new Tile[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    this.Grid.SetValue(new Tile(), i, j);
                }
            }
        }

        /// <summary>
        /// Places a new Ship on the board.
        /// </summary>
        /// <param name="points">The points occupied by the ship</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when at one of the points is not on the Board</exception>
        /// <exception cref="InvalidOperationException">Thrown when one of the points is already occupied by a Ship</exception>
        public void PlaceShipOnBoard(List<Point> points)
        {
            Ship ship = new Ship(points.Count);

            for (int i = 0; i < points.Count; i++)
            {
                try
                {
                    this.GetTile(points[i]).PlaceShipOnTile(ship);
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw;
                }
                catch (InvalidOperationException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Returns the Tile of the Board in a given location 
        /// </summary>
        /// <param name="p">Location of the requested Tile</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the point is not on the Board</exception>
        public Tile GetTile(Point p)
        {
            if (p.X >= this.Size || p.Y >= this.Size || p.Y < 0 || p.X < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else
            {
                return this.Grid[p.X, p.Y];
            }
        }

        /// <summary>
        /// Registers a Hit on a Tile
        /// </summary>
        /// <param name="p">The coordinates of the Tile being shot</param>
        /// <exception cref="InvalidOperationException">Thrown when the Tile is already shot</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the tile does not exist</exception>
        public void ShootTile(Point p)
        {
            try
            {
                this.GetTile(p).Shoot();
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }

        public bool IsShip()
        {
            if(this.Ships.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
