using DataAccess.DataAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class EmployeeDAO
    {
        public string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:SE1505_EmployeeDepartment"];
            return strConn;
        }
        private static EmployeeDAO instance = null;
        private static readonly object instanceLock = new object();
        private EmployeeDAO() { }
        public static EmployeeDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new EmployeeDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Employee> GetMemberList()
        {
            string cs = GetConnectionString();

            var members = new List<Employee>();
            List<Employee> FList = new List<Employee>();
            try
            {
                using var context = new SE1505_EmployeeDepartmentContext(cs);
                members = context.Employees.ToList();
                for (int i = 1; i <= members.Count; i++)
                {
                    FList.Add(members[i - 1]);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return FList;
        }

        public Employee GetMemberByID(string MemberID)
        {
            string cs = GetConnectionString();
            Employee mem = null;
            try
            {
                using var context = new SE1505_EmployeeDepartmentContext(cs);

                mem = context.Employees.SingleOrDefault(m => m.EmployeeId.Equals(MemberID));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return mem;
        }


        public void AddNew(Employee member)
        {
            string cs = GetConnectionString();
            try
            {
                Employee mem = GetMemberByID(member.EmployeeId);
                if (mem == null)
                {
                    using var context = new SE1505_EmployeeDepartmentContext(cs);
                    context.Employees.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public void Update(Employee member)
        {

            string cs = GetConnectionString();
            try
            {
                Employee mem = GetMemberByID(member.EmployeeId);
                if (mem != null)
                {
                    using var context = new SE1505_EmployeeDepartmentContext(cs);
                    context.Employees.Update(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        public void Remove(string EmployeeId)
        {
            string cs = GetConnectionString();
            try
            {
                Employee mem = GetMemberByID(EmployeeId);
                if (mem != null)
                {
                    using (SE1505_EmployeeDepartmentContext db = new SE1505_EmployeeDepartmentContext(cs))
                    {
                        Employee member = db.Employees.Where(d => d.EmployeeId.Equals(EmployeeId)).First();
                        db.Employees.Remove(member);
                        db.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
