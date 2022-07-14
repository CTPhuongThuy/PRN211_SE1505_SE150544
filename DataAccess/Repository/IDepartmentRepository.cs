using DataAccess.DataAccess;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetTours();
        Department GetTourByID(string TourID);

    }
}
