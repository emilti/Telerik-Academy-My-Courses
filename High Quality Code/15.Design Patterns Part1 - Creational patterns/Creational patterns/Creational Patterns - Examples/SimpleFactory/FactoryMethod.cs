namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FactoryMethod
    {
        public Mountain GetMountain(MountainName mountainName)
        {
            switch (mountainName)
            {
                case MountainName.Vitosha: return new Mountain(2290);                  
                case MountainName.Rila: return new Mountain(2925);                    
                case MountainName.Pirin: return new Mountain(2914);                    
                default: return new Mountain(0);
            }
        }
    }
}
