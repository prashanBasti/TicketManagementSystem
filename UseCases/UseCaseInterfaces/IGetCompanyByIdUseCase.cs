using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetCompanyByIdUseCase
    {
        Company Execute(int companyId);
    }
}