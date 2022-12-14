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

            if(companies != null && companies.Count > 0)
            {
                var maxId = companies.Max(x => x.CompanyId);
                company.CompanyId = maxId + 1;
            }
            else
            {
                company.CompanyId = 1;
            }
            
            companies.Add(company);
        }

        public void UpdateCompany(Company company)
        {
            var companyToUpdate = companies?.FirstOrDefault(x => x.CompanyId == company.CompanyId);
            if (companyToUpdate != null) //companyToUpdate = company;
            {
                companyToUpdate.Name = company.Name;
                companyToUpdate.Description = company.Description;
            }
        }

        public IEnumerable<Company> GetCompanies()
        {
            return companies;
        }

        public Company GetCompanyById(int companyId)
        {
            return companies?.FirstOrDefault(x => x.CompanyId == companyId);
        }
        public void DeleteCompany(int companyId)
        {
            companies?.Remove(GetCompanyById(companyId));
        }
    }

}