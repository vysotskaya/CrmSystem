using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    public class DbModelContext : DbContext
    {
        public DbModelContext()
            : base("name=DbModelContext")
        {
            Database.SetInitializer(new CrmSystemDbInitializer());
        }

        public virtual IDbSet<ClientDbModel> Clients { get; set; }
        public virtual IDbSet<ClientOrderDbModel> ClientOrders { get; set; }
        public virtual IDbSet<ExpenseDbModel> Expenses { get; set; }
        public virtual IDbSet<MaterialDbModel> Materials { get; set; }
        public virtual IDbSet<OrderArchiveDbModel> OrderArchives { get; set; }
        public virtual IDbSet<ProductDbModel> Products { get; set; }
        public virtual IDbSet<SupplierDbModel> Suppliers { get; set; }
        public virtual IDbSet<SupplierOrderDbModel> SupplierOrders { get; set; }
        public virtual IDbSet<WallpaperTypeDbModel> WallparerTypes { get; set; }
        public virtual IDbSet<WallpaperSizeDbModel> WallpaperSizes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<ClientDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<ClientOrderDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<ClientOrderDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<ExpenseDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<ExpenseDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<MaterialDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<MaterialDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<OrderArchiveDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<OrderArchiveDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<ProductDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<ProductDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<SupplierDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<SupplierDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<SupplierOrderDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<SupplierOrderDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<WallpaperTypeDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<WallpaperTypeDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<WallpaperSizeDbModel>().HasKey(t => t.Id);
            modelBuilder.Entity<WallpaperSizeDbModel>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ClientOrderDbModel>()
                  .HasRequired<ProductDbModel>(t => t.Product)
                  .WithMany(t => t.ClientOrders)
                  .HasForeignKey(t => t.ProductRefId);
            modelBuilder.Entity<ClientOrderDbModel>()
                  .HasRequired<ClientDbModel>(t => t.Client)
                  .WithMany(t => t.ClientOrders)
                  .HasForeignKey(t => t.ClientRefId);
            modelBuilder.Entity<OrderArchiveDbModel>()
                  .HasRequired<ClientDbModel>(t => t.Client)
                  .WithMany(t => t.OrderArchives)
                  .HasForeignKey(t => t.ClientRefId);
            modelBuilder.Entity<ProductDbModel>()
                  .HasRequired<WallpaperTypeDbModel>(t => t.WallpaperType)
                  .WithMany(t => t.Products)
                  .HasForeignKey(t => t.WallpaperTypeRefId);
            modelBuilder.Entity<ProductDbModel>()
                  .HasRequired<WallpaperSizeDbModel>(t => t.WallpaperSize)
                  .WithMany(t => t.Products)
                  .HasForeignKey(t => t.WallpaperSizeRefId);
            modelBuilder.Entity<ExpenseDbModel>()
                  .HasRequired<WallpaperTypeDbModel>(t => t.WallpaperType)
                  .WithMany(t => t.Expenses)
                  .HasForeignKey(t => t.WallpaperTypeRefId);
            modelBuilder.Entity<ExpenseDbModel>()
                  .HasRequired<MaterialDbModel>(t => t.Material)
                  .WithMany(t => t.Expenses)
                  .HasForeignKey(t => t.MaterialRefId);
            modelBuilder.Entity<SupplierOrderDbModel>()
                  .HasRequired<SupplierDbModel>(t => t.Supplier)
                  .WithMany(t => t.SuppliersOrders)
                  .HasForeignKey(t => t.SupplierRefId);
            modelBuilder.Entity<SupplierOrderDbModel>()
                  .HasRequired<MaterialDbModel>(t => t.Material)
                  .WithMany(t => t.SupplierOrders)
                  .HasForeignKey(t => t.MaterialRefId);
        }
    }
}
