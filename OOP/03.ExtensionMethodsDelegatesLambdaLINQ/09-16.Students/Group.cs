namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int inputGroupNumber, string inputDepartmentName)
        {
            this.GroupNumber = inputGroupNumber;
            this.DepartmentName = inputDepartmentName;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }

            set
            {
                this.departmentName = value;
            }
        }
    }
}