using System.Web.Http;
using Demo.DataAccess;
using Demo.Logic;
using Unity;
using Unity.WebApi;

namespace Demo
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDataAccess, DataAccess.DataAccess>();
            container.RegisterType<ICustomerManager, CustomerManager>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}