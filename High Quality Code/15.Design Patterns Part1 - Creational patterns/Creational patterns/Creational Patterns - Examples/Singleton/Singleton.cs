namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class God
    {
        private static God buda;

        // Note: Constructor is 'protected' or 'private'
        protected God() 
        {
        }

        public static God Instance()
        { // Can be property
            // Use 'Lazy initialization'
            if (buda == null)
            {
                buda = new God();
            }

            return buda;
        }
    } // This implementation is not thread-safe!
}
