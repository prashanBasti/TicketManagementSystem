﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class EditProjectUseCase : IEditProjectUseCase
    {
        private readonly IProjectRepository projectRepository;

        public EditProjectUseCase(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }
        public void Execute(Project project)
        {
            projectRepository.UpdateProject(project);
        }
    }
}
