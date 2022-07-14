using DataAccess.DataAccess;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public IEnumerable<Department> GetTours() => DepartmentDAO.Instance.GetTourList();
        public Department GetTourByID(string TourID) => DepartmentDAO.Instance.GetTourByID(TourID);
    }
}
