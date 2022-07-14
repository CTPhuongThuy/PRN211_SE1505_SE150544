using DataAccess.DataAccess;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetMembers();
        Employee GetMemberByID(string MemberID);
        void InsertMember(Employee member);
        void DeleteMember(string MemberID);
        void UpdateMember(Employee member);
    }
}
