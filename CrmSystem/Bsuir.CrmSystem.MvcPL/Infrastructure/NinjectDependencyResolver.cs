﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Bsuir.CrmSystem.DataAccess.DependencyResolver;
using Ninject;

namespace Bsuir.CrmSystem.MvcPL.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            _kernel.ConfigurateResolverWeb();
        }

        public object GetService(Type type)
        {
            return _kernel.TryGet(type);
        }

        public IEnumerable<object> GetServices(Type type)
        {
            return _kernel.GetAll(type);
        }
    }
}