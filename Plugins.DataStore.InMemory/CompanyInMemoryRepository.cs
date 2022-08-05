using CoreBusiness;
using UseCases.DataStorePluginInterfaces;
using System.Linq;

namespace Plugins.DataStore.InMemory
{
    public class CompanyInMemoryRepository : ICompanyRepository
    {
        private List<Company> companies;

        public CompanyInMemoryRepository()
        {
            //Adding some companies for testing
            companies = new List<Company>()
            {
                new Company{CompanyId = 1, Name = "NTB", Description = "Bank" },
                new Company{CompanyId = 2, Name = "HNB", Description = "Bank" },
                new Company{CompanyId = 3, Name = "AFC", Description = "Finance" }
            };
        }

        public void AddCompany(Company company)
        {
            if (companies.Any(x => x.Name.Equals(company.Name, StringComparison.OrdinalIgnoreCase))) return;
            var maxId = companies.Max(x => x.CompanyId);
            company.CompanyId = maxId + 1;
            companies.Add(company);
        }

        public IEnumerable<Company> GetCompanies()
        {
            return companies;
        }

    }

}