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
    public class EditUserUseCase : IEditUserUseCase
    {
        private readonly IUserRepository userRepository;

        public EditUserUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Execute(User user)
        {
            userRepository.UpdateUser(user);
        }
    }
}
