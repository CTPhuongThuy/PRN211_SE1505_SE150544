using DataAccess.DataAccess;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetMembers() => EmployeeDAO.Instance.GetMemberList();

        public Employee GetMemberByID(string EmployeeId) => EmployeeDAO.Instance.GetMemberByID(EmployeeId);
        public void InsertMember(Employee employee) => EmployeeDAO.Instance.AddNew(employee);
        public void DeleteMember(string EmployeeId) => EmployeeDAO.Instance.Remove(EmployeeId);
        public void UpdateMember(Employee employee) => EmployeeDAO.Instance.Update(employee);
    }
}
