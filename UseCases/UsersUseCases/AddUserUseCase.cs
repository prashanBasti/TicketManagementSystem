using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using CoreBusiness;

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
