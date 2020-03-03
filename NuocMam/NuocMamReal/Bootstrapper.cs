using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;
using NuocMam.Model.Interface ;
using NuocMam.Model.Repository;

namespace NuocMamReal
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here  
            //This is the important line to edit  
            //container.RegisterType<ICompanyRepository, CompanyRepository>();
            container.RegisterType<IAspNetUser, AspNetUserRepo>();
            container.RegisterType<IDatabaseFactory, DatabaseFactory>();
            RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}