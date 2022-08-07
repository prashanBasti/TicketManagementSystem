using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using CoreBusiness;
using UseCases.UseCaseInterfaces;

namespace UseCases.UsersUseCases
{
    public class AddUserUseCase : IAddUserUseCase

    {
        private readonly IUserRepository userRepository;

        public AddUserUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }


        public void Execute(User user)
        {
            userRepository.AddUser(user);
        }
    }
}
