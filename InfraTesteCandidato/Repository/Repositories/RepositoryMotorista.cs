using Domain.Interfaces;
using EntitiesTesteCandidato;
using Infra.Repository.Generics;
using InfraTesteCandidato.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.Repositories
{
    public class RepositoryMotorista : RepositoryGenerics<Motorista>, IMotorista
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositoryMotorista()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        
    }
}
