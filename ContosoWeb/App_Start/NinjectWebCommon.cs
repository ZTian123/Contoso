﻿using Contoso.Service;
using Contoso.Model;
//using Contoso.Data.Repositories;
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Contoso.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Contoso.App_Start.NinjectWebCommon), "Stop")]


namespace Contoso.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Contoso.Data;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            // Repositories

            //kernel.Bind<IStudentRepository>().To<StudentRepository>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();
            kernel.Bind<IStudentRepository>().To<StudentRepository>();
            kernel.Bind<IDepartmentRepository>().To<DepartmentRepository>();

            //Services
            //kernel.Bind<IStudentService>().To<StudentService>();
            kernel.Bind<IPersonService>().To<PersonService>();//what class should be inject
            //ninjec.web.mvc will remove MVC controller parameterless exception
            //(asp.net code 中build-in dependency injection functionality)
            //also will inject concrete time of classes to interface
            kernel.Bind<IStudentService>().To<StudentService>();
            kernel.Bind<IDepartmentService>().To<DepartmentService>();

        }        
    }
}
