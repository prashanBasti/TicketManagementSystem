using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetUserByIdUseCase
    {
        User Execute(int userId);
    }
}