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
                new Company{CompanyId = 1, Name = "NTB", Description = "Bank" },
                new Company{CompanyId = 2, Name = "HNB", Description = "Bank" },
                new Company{CompanyId = 3, Name = "AFC", Description = "Finance" }
            };
        }
        public IEnumerable<Company> GetCompanies()
        {
            return companies;
        }

    }

}