using System.Data.Entity;
using Bsuir.CrmSystem.DataAccess.Interfaces.Repositories;
using Bsuir.CrmSystem.DataAccess.MSSql.Concrete;
using Bsuir.CrmSystem.DataAccess.MSSqlDbModel;
using Bsuir.CrmSystem.DataServices.Concrete;
using Bsuir.CrmSystem.DataServices.Interfacies;
using Ninject;
using Ninject.Web.Common;

namespace Bsuir.CrmSystem.DataAccess.DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolverWeb(this IKernel kernel)
        {
            Configure(kernel);
        }

        private static void Configure(IKernel kernel)
        {
            kernel.Bind<DbContext>().To<DbModelContext>().InRequestScope();

            kernel.Bind<IClientRepository>().To<ClientRepository>();
            kernel.Bind<IClientService>().To<ClientService>();

            kernel.Bind<IClientOrderRepository>().To<ClientOrderRepository>();
            kernel.Bind<IClientOrderService>().To<ClientOrderService>();

            kernel.Bind<ISupplierRepository>().To<SupplierRepository>();
            kernel.Bind<ISupplierService>().To<SupplierService>();

            kernel.Bind<ISupplierOrderRepository>().To<SupplierOrderRepository>();
            kernel.Bind<ISupplierOrderService>().To<SupplierOrderService>();

            kernel.Bind<IExpenseRepository>().To<ExpenseRepository>();
            kernel.Bind<IExpenseService>().To<ExpenseService>();

            kernel.Bind<IMaterialRepository>().To<MaterialRepository>();
            kernel.Bind<IMaterialService>().To<MaterialService>();

            kernel.Bind<IOrderArchiveRepository>().To<OrderArchiveRepository>();
            kernel.Bind<IOrderArchiveService>().To<OrderArchiveService>();

            kernel.Bind<IProductRepository>().To<ProductRepository>();
            kernel.Bind<IProductService>().To<ProductService>();

            kernel.Bind<IWallpaperSizeRepository>().To<WallpaperSizeRepository>();
            kernel.Bind<IWallpaperSizeService>().To<IWallpaperSizeService>();

            kernel.Bind<IWallpaperTypeRepository>().To<WallpaperTypeRepository>();
            kernel.Bind<IWallpaperTypeService>().To<WallpaperTypeService>();
        }
    }
}
