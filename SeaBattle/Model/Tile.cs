namespace Sea_Battle
{
    /// <summary>
    /// Class for representing a Tile of a Board in a game of Battleship
    /// </summary>
    class Tile
    {
        /// <value>Ship found on the Tile</value>
        public Ship Ship { get; set; }

        /// Logical value showing if the tile hase been hit or not
        public bool Hit { get; set; }

        /// <summary>
        /// Initializes a new instance of the <c>Tile</c> Class whitout a ship and no hit on it
        /// </summary>
        public Tile()
        {
            this.Ship = null;
            this.Hit = false;
        }

        /// <summary>
        /// Returns if there is a Ship on the Tile or not
        /// </summary>
        /// <returns>True if there is a ship on this Tile False if there is not</returns>
        public bool IsShip()
        {
            if(this.Ship == null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Records a shot on the Tile
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Thrown when the Tile is already shot</exception>
        public void Shoot()
        {
            if (this.Hit == true)
            {
                throw new System.InvalidOperationException();
            }
            if (this.IsShip())
            {
                try
                {
                    this.Ship.Hit();
                }
                catch (System.InvalidOperationException)
                {
                    throw;
                }
            }
            this.Hit = true;
        }

        /// <summary>
        /// Places a <c>Ship</c> on the tile
        /// </summary>
        /// <param name="ship">The <c>Ship</c> to be placed</param>
        /// <exception cref="System.InvalidOperationException">Thrown when the Tile is already occupied by a Ship</exception>
        public void PlaceShipOnTile(Ship ship)
        {
            if (this.IsShip())
            {
                throw new System.InvalidOperationException();
            }
            else
            {
                this.Ship = ship;
            }
        }
    }
}