using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class EditCompanyUseCase : IEditCompanyUseCase
    {
        private readonly ICompanyRepository companyRepository;

        public EditCompanyUseCase(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }
        public void Execute(Company company)
        {
            companyRepository.UpdateCompany(company);
        }
    }
}
