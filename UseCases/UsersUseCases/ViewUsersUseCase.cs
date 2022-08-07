using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.UsersUseCases
{
    public class ViewUsersUseCase : IViewUsersUseCase
    {

        private readonly IUserRepository userRepository;

        public ViewUsersUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<User> Execute()
        {
            return userRepository.GetUsers();
        }
    }
}
