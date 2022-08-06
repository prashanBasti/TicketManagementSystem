using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetCompanies();

        void AddCompany(Company company);
        void UpdateCompany(Company company);
        Company GetCompanyById(int companyId);
        void DeleteCompany(int companyId);
    }
}
