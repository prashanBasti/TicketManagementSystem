using CoreBusiness;
using System.Collections.Generic;


namespace UseCases.UseCaseInterfaces
{
    public interface IGetCompanyByIdUseCase
    {
        Company Execute(int companyId);
    }
}