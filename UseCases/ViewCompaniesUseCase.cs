using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class ViewCompaniesUseCase
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
