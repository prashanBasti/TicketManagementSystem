using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IUserRepository
    {

        IEnumerable<User> GetUsers();
        void AddUser(User user);
        User GetUserById(int userId);

        void UpdateUser(User user);

        void DeleteUser(int userId);
    }
}
