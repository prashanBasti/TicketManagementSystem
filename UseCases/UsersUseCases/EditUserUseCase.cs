using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class EditUserUseCase
    {
        private readonly IUserRepository userRepository;

        public EditUserUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Execute(Project user)
        {
            userRepository.UpdateUser(user);
        }
    }
}
