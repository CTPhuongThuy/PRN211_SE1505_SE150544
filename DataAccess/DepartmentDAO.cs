using DataAccess.DataAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace DataAccess
{
    public class DepartmentDAO
    {
        public string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:SE1505_EmployeeDepartment"];
            return strConn;
        }
        private static DepartmentDAO instance = null;
        private static readonly object instanceLock = new object();
        private DepartmentDAO() { }
        public static DepartmentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DepartmentDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Department> GetTourList()
        {
            string cs = GetConnectionString();
            var tours = new List<Department>();
            try
            {
                using var context = new SE1505_EmployeeDepartmentContext(cs);
                tours = context.Departments.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return tours;

        }
        public Department GetTourByID(string TourID)
        {
            string cs = GetConnectionString();
            Department tour = null;
            try
            {
                using var context = new SE1505_EmployeeDepartmentContext(cs);
                tour = context.Departments.SingleOrDefault(c => c.DepartmentId.Equals(TourID));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return tour;
        }
    }

}
