namespace Minesweeper
{
    using System;

    public class Player
    {
        private string name;
        private int pointsCount;

        public Player() 
        {
        }

        public Player(string name, int pointsCount)
        {
            this.Name = name;
            this.PointsCount = pointsCount;
        }

        public string Name
        {
            get 
            {
                return this.name; 
            }

            set 
            {
                this.name = value; 
            }
        }

        public int PointsCount
        {
            get { return this.pointsCount; }
            set { this.pointsCount = value; }
        }       
    }
}