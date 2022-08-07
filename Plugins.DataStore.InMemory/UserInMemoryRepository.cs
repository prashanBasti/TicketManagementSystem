using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class UserInMemoryRepository : IUserRepository
    {
        private List<User> users;
        public UserInMemoryRepository()
        {
            //Init with some default values
            users = new List<User>()
           {
               new User {UserId = 1, ProjectId = 1, Name = "Prashan Bastiansz"},
               new User {UserId = 2, ProjectId = 2, Name = "Anushi Wilson"}
           };
        }

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {
            if (users.Any(x => x.Name.Equals(user.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (users != null && users.Count > 0)
            {
                var maxId = users.Max(x => x.UserId);
                user.UserId = maxId + 1;
            }
            else
            {
                user.UserId = 1;
            }

            users.Add(user);
        }

        public User GetUserById(int userId)
        {
            return users.FirstOrDefault(x => x.UserId == userId);
        }

        public void UpdateUser(User user)
        {
            var userToUpdate = GetUserById(user.UserId);
            if (userToUpdate != null) //projectToUpdate = company;
            {
                userToUpdate.Name = user.Name;
                userToUpdate.UserId = user.UserId;
            }
        }

        public void DeleteUser(int userId)
        {
            var userToDelete = GetUserById(userId);
            if (userId != null) users.Remove(userToDelete);
        }
    }
}
