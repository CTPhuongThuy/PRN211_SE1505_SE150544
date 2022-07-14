using DataAccess.DataAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace DataAccess
{
    public class UserDAO
    {
        public string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:SE1505_EmployeeDepartment"];
            return strConn;
        }
        //Using Singleton Pattern
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<AccountDb> GetUserList()
        {
            string cs = GetConnectionString();
            var users = new List<AccountDb>();
            try
            {
                using var context = new SE1505_EmployeeDepartmentContext(cs);
                users = context.AccountDbs.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return users;

        }

        public AccountDb GetUserByID(string UserID)
        {
            AccountDb user = null;
            try
            {
                using var context = new SE1505_EmployeeDepartmentContext();
                user = context.AccountDbs.SingleOrDefault(c => c.UserId.Equals(UserID));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return user;
        }

        //-----------------------------------------------------------------
        //Add a new user
        public void AddNew(AccountDb user)
        {
            try
            {
                AccountDb use = GetUserByID(user.UserId);
                if (use == null)
                {
                    using var context = new SE1505_EmployeeDepartmentContext();
                    context.AccountDbs.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //-----------------------------------------------------------------
        //Add a new user
        public void Update(AccountDb user)
        {
            try
            {
                AccountDb mem = GetUserByID(user.UserId);
                if (mem != null)
                {
                    using var context = new SE1505_EmployeeDepartmentContext();
                    context.AccountDbs.Update(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------------------------------------------------
        //Add a new user
        public void Remove(string UserID)
        {
            try
            {
                AccountDb mem = GetUserByID(UserID);
                if (mem != null)
                {
                    using var context = new SE1505_EmployeeDepartmentContext();
                    context.AccountDbs.Remove(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
