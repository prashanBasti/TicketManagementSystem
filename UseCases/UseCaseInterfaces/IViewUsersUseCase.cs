using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewUsersUseCase
    {
        IEnumerable<User> Execute();
    }
}