using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.CompaniesUseCases
{
    public class DeleteCompanyUseCase : IDeleteCompanyUseCase
    {
        private readonly ICompanyRepository companyRepository;

        public DeleteCompanyUseCase(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public void Delete(int companyId)
        {
            companyRepository.DeleteCompany(companyId);
        }
    }
}
