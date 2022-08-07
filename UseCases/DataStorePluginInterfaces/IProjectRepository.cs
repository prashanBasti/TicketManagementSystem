using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public  interface IProjectRepository
    {
        IEnumerable<Project> GetProjects();
        void AddProject(Project project);

        void UpdateProject(Project project);
        Project GetProjectById(int projectId);

        void DeleteProject(int projectId);
    }
}
