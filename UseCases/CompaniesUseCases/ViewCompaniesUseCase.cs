using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.CompaniesUseCases
{
    public class ViewCompaniesUseCase : IViewCompaniesUseCase
    {
        private readonly ICompanyRepository companyRepository;

        public ViewCompaniesUseCase(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public IEnumerable<Company> Execute()
        {
            return companyRepository.GetCompanies();

        }

    }
}
