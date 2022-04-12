using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> products { get; set; }
        public DbSet<CategoryEntity> categories { get; set; }
        public DbSet<InOutEntity> inOuts { get; set; }
        public DbSet<WarehouseEntity> warehouses { get; set; }
        public DbSet<StorageEntity> storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=ANDONI\SQLEXPRESS; database=InventoryDb;Trusted_Connection=True;");
                // "Server=XXX\\XX; Database=XXX; User Id=XXX; Password=XXXX"
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { categoryId = "ASH",categoryName="Aseo Hogar"},
                new CategoryEntity { categoryId = "ASP",categoryName="Aseo Personal"},
                new CategoryEntity { categoryId = "HGR", categoryName = "Hogar" },
                new CategoryEntity { categoryId = "SLD", categoryName = "Salud" }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { warehouseId = Guid.NewGuid().ToString(),
                    warehouseName = "Bodega Central", warehouseAddress="Calle 8 con 23"},
                new WarehouseEntity
                {
                    warehouseId = Guid.NewGuid().ToString(),
                    warehouseName = "Bodega Sur",
                    warehouseAddress = "Calle sur con este"
                },
                new WarehouseEntity
                {
                    warehouseId = Guid.NewGuid().ToString(),
                    warehouseName = "Bodega Norte",
                    warehouseAddress = "Calle Norte con oriente"
                }
                );
        }
    }
}
