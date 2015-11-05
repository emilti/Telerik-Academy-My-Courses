namespace JediMeditation
{
    using System;
    using System.Collections;
    using System.Text;

    public class MainProgram
    {
        public static void Main()
        {
            string length = Console.ReadLine();
            string input = Console.ReadLine();
            var jedis = input.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);
            Queue masters = new Queue();
            Queue knights = new Queue();
            Queue padawans = new Queue();

            for (int i = 0; i < jedis.Length; i++)
            {
                if (jedis[i][0] == 'm')
                {
                    masters.Enqueue(jedis[i]);
                }
                else if(jedis[i][0] == 'k')
                {
                    knights.Enqueue(jedis[i]);                    
                }
                else if (jedis[i][0] == 'p')
                {
                    padawans.Enqueue(jedis[i]);
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < masters.Count; i++)
            {
                sb.Append(masters.Dequeue() + " ");
                i--;
            }

            for (int i = 0; i < knights.Count; i++)
            {
                sb.Append(knights.Dequeue() + " ");
                i--;
            }

            for (int i = 0; i < padawans.Count; i++)
            {
                sb.Append(padawans.Dequeue() + " ");
                i--;
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
