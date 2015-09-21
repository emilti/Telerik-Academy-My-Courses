namespace Memento
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The originator class
    /// </summary>
    internal class Player
    {       
        public Player(int posX, int posY) 
        {
            this.PosX = posX;
            this.PosY = posY;
        }

        public int PosX { get; set; }

        public int PosY { get; set; }

        public Memento SaveMemento()
        {
            return new Memento(this.PosX, this.PosY);
        }

        public void RestoreMemento(Memento memento)
        {
            this.PosX = memento.PosX;
            this.PosY = memento.PosY;        
        }

        public override string ToString()
        {
            return "Player position is:" + this.PosX + " " + this.PosY;
        }
    }
}
