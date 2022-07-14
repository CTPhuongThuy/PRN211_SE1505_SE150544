using System.Collections.Generic;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
