﻿using Nebuteater.Data.Contexts;
using Nebuteater.Data.Infrastructure.Interfaces;

namespace Nebuteater.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TheatreDbContext context;

        public TheatreDbContext DbContext => context ?? (context = dbFactory.Init());

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}