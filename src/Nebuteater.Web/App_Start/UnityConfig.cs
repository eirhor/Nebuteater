using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Nebuteater.Services.Interfaces;
using Unity.Mvc5;
using Nebuteater.Services;
using Nebuteater.Data.Infrastructure.Interfaces;
using Nebuteater.Data.Infrastructure;
using Nebuteater.Data.Repositories;
using Nebuteater.Models.Entities;

namespace Nebuteater.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDefaultPlayService, DefaultPlayService>();
            container.RegisterType<IDefaultPerformanceService, DefaultPerformanceService>();
            container.RegisterType<IDefaultReservationService, DefaultReservationService>();
            container.RegisterType<IDefaultRoleService, DefaultRoleService>();
            container.RegisterType<IDefaultUserService, DefaultUserService>();
            container.RegisterType<IRepository<Play>, PlayRepository>();
            container.RegisterType<IRepository<Performance>, PerformanceRepository>();
            container.RegisterType<IRepository<Reservation>, ReservationRepository>();
            container.RegisterType<IRepository<Role>, RoleRepository>();
            container.RegisterType<IRepository<User>, UserRepository>();
            container.RegisterType<IDbFactory, DbFactory>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}