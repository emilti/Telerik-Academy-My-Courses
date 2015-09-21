namespace Memento
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var newPlayer = new Player(10, 10);

            // Store internal state
            var memory = new PositionMemory();
            Console.WriteLine("\nSaving position:");
            memory.Memento = newPlayer.SaveMemento();
            Console.WriteLine(newPlayer.ToString());

            // Continue changing originator
            newPlayer.PosX = 1000;
            newPlayer.PosY = 2000;
            Console.WriteLine("\nChanging position of the player:");
            Console.WriteLine(newPlayer.ToString());

            // Restore saved state
            Console.WriteLine("\nRestoring position:");
            newPlayer.RestoreMemento(memory.Memento);
            Console.WriteLine(newPlayer.ToString());
        }
    }
}
