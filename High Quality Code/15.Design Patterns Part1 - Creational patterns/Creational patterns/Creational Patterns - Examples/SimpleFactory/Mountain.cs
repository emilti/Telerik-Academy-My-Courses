namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mountain
    {
        public Mountain(int peak)
        {
            this.Peak = peak;
        }

        public int Peak { get; set; }
    }
}
