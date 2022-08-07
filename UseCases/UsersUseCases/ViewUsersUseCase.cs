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
        private readonly IViewUsersUseCase usersUseCase;

        public ViewUsersUseCase(IViewUsersUseCase usersUseCase)
        {
            this.usersUseCase = usersUseCase;
        }

        public IEnumerable<User> Execute()
        {
            return userRepository.GetUsers();
        }
    }
}
