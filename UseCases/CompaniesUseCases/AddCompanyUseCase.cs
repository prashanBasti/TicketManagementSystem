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
    public class AddCompanyUseCase : IAddCompanyUseCase
    {
        private readonly ICompanyRepository companyRepository;

        public AddCompanyUseCase(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }


        public void Execute(Company company)
        {
            companyRepository.AddCompany(company);
        }
    }
}
