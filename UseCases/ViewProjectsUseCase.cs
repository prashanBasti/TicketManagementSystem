using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class ViewProjectsUseCase : IViewProjectsUseCase
    {
        private readonly IProjectRepository projectRepository;

        public ViewProjectsUseCase(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }
        public IEnumerable<Project> Execute()
        {
            return projectRepository.GetProjects();

        }
    }
}
