namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntityChild : Employee
    {
        public override ICollection<Territory> Territories
        {
            get
            {
                var teritory = new List<Territory>();
                teritory.AddRange(base.Territories);
                return teritory;
            }
            set
            {
                base.Territories = value;
            }
        }
    }
}

