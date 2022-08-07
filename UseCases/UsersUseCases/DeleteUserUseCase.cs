using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class DeleteUserUseCase : IDeleteUserUseCase
    {
        private readonly IUserRepository userRepository;

        public DeleteUserUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Execute(int userId)
        {
            userRepository.DeleteUser(userId);
        }
    }
}
