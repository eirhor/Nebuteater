﻿using Nebuteater.Data.Infrastructure;
using Nebuteater.Data.Infrastructure.Interfaces;
using Nebuteater.Models.Entities;

namespace Nebuteater.Data.Repositories
{
    public class RoleRepository : RepositoryBase<Role>, IRepository<Role>
    {
        public RoleRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}