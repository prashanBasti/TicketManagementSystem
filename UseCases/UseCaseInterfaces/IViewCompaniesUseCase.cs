using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewCompaniesUseCase
    {
        IEnumerable<Company> Execute();
    }
}