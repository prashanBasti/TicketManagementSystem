using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class DeleteProjectUseCase : IDeleteProjectUseCase
    {
        private readonly IProjectRepository projectRepository;

        public DeleteProjectUseCase(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public void Execute(int projectId)
        {
            projectRepository.DeleteProject(projectId);
        }
    }
}
