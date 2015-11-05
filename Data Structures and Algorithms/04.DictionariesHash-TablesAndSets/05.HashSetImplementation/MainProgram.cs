using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetImplementation
{
    public class Program
    {
        public static void Main()
        {
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            firstSet.Add(1);
            firstSet.Add(2);
            firstSet.Add(7);
            secondSet.Add(7);
            secondSet.Add(13);
            secondSet.Add(19);
            firstSet.Remove(2);

            var unionSet = firstSet.Union(secondSet);
            Console.WriteLine("Union set = {0}", unionSet);

            var intersectSet = firstSet.Intersect(secondSet);
            Console.WriteLine("Intersect set = {0}", intersectSet);
        }
    }
}
