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
    public class GetUserByIdUseCase : IGetUserByIdUseCase
    {
        private readonly IUserRepository userRepository;

        public GetUserByIdUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public User Execute(int userId)
        {
            return userRepository.GetUserById(userId);

        }
    }
}
