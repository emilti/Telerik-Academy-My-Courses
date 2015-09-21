namespace Memento
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Memento class
    /// </summary>
    public class Memento
    {
        public Memento(int posX, int posY) 
        {
            this.PosX = posX;
            this.PosY = posY;
        }
        
        public int PosX { get; set; }

        public int PosY { get; set; }        
    }
}