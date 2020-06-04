namespace Sea_Battle
{
    /// <summary>
    /// Class for representing a Ship in a game of Battleship
    /// </summary>
    class Ship
    {
        /// <value>Length of the ship</value>
        public int Size { get; }

        public int SinkCount { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Ship class with the given size
        /// </summary>
        /// <param name="size">The size of the ship</param>
        public Ship(int size)
        {
            this.Size = size;
            this.SinkCount = size;
        }

        /// <summary>
        /// Returns if the ship is already sunk or not
        /// </summary>
        /// <returns>True if it is sunk False is it is not</returns>
        public bool IsSunk()
        {
            if(this.SinkCount == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Registers a Hit on the Ship
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Thrown when the ship is already sunk</exception>
        public void Hit()
        {
            if (this.SinkCount > 0)
            {
                this.SinkCount--;
            }
            else
            {
                throw new System.InvalidOperationException();
            }
        }
    }
}