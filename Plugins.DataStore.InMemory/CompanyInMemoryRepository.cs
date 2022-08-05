using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

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
                new Company{CompanyId = 1, Name = "NationsTrustBank", Description = "Bank" },
                new Company{CompanyId = 2, Name = "HattonNationalBank", Description = "Bank" },
                new Company{CompanyId = 3, Name = "AllianceFinance", Description = "FinanceCompany" }
            };
        }
        public IEnumerable<Company> GetCompanies()
        {
            return companies;
        }

    }

}