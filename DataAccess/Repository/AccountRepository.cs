using DataAccess.DataAccess;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public IEnumerable<AccountDb> GetUsers() => UserDAO.Instance.GetUserList();
        public AccountDb GetUserByID(string UserID) => UserDAO.Instance.GetUserByID(UserID);
        //public void InsertUser(AccountDb user) => UserDAO.Instance.AddNew(user);
        //public void DeleteUser(string UserID) => UserDAO.Instance.Remove(UserID);
        //public void UpdateUser(AccountDb user) => UserDAO.Instance.Update(user);
    }

}
