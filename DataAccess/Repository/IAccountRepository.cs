using DataAccess.DataAccess;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IAccountRepository
    {
        IEnumerable<AccountDb> GetUsers();
        AccountDb GetUserByID(string UserID);
        //void InsertUser(AccounDb user);
        //void DeleteUser(string UserID);
        //void UpdateUser(AccounDb user);
    }
}
