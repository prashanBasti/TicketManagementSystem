using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProjectInMemoryRepository : IProjectRepository
    {
        private List<Project> projects;
        public ProjectInMemoryRepository()
        {
            projects = new List<Project>()
           {
               new Project {ProjectId = 1, CompanyId = 1, Name = "Excess Management", Description = "System for managing overdrawn cheques"},
               new Project {ProjectId = 2, CompanyId = 1, Name = "Loan Origination", Description = "System for loans"},
               new Project {ProjectId = 2, CompanyId = 2, Name = "FEBA", Description = "Front end for digital banking"}


           };
        }

        public void AddProject(Project project)
        {
            if (projects.Any(x => x.Name.Equals(project.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (projects != null && projects.Count > 0)
            {
                var maxId = projects.Max(x => x.ProjectId);
                project.ProjectId = maxId + 1;
            }
            else
            {
                project.ProjectId = 1;
            }

            projects.Add(project);
        }

        public IEnumerable<Project> GetProjects()
        {
            return projects;
        }
    }
}
