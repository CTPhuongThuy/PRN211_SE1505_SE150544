using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataAccess
{
    public partial class SE1505_EmployeeDepartmentContext : DbContext
    {
        public SE1505_EmployeeDepartmentContext(string conn)
        {
            this.Database.SetConnectionString(conn);
        }
    }
}
