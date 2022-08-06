using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.CompaniesUseCases
{
    public class GetCompanyByIdUseCase : IGetCompanyByIdUseCase
    {
        private readonly ICompanyRepository companyRepository;

        public GetCompanyByIdUseCase(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }
        public Company Execute(int companyId)
        {
            return companyRepository.GetCompanyById(companyId);
        }
    }
}
