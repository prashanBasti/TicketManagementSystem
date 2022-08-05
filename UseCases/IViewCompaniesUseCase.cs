using CoreBusiness;

namespace UseCases
{
    public interface IViewCompaniesUseCase
    {
        IEnumerable<Company> Execute();
    }
}