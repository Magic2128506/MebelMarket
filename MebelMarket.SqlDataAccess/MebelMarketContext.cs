using MebelMarket.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace MebelMarket.SqlDataAccess
{
    public class MebelMarketContext : DbContext
    {
        public MebelMarketContext(DbContextOptions<MebelMarketContext> Options) : base(Options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<FurnitureType> FurnitureTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FurnitureType>().HasData(
                new FurnitureType[]
                {
                    new FurnitureType { Id = 1, Name="Диваны прямые", Category = "Мягкая мебель"},
                    new FurnitureType { Id = 2, Name="Диваны угловые", Category = "Мягкая мебель"},
                    new FurnitureType { Id = 3, Name="Диваны для офиса", Category = "Мягкая мебель"},
                    new FurnitureType { Id = 4, Name="Диваны детские", Category = "Мягкая мебель"},
                    new FurnitureType { Id = 5, Name="Кресла", Category = "Мягкая мебель"},
                    new FurnitureType { Id = 6, Name="Кресла-качалки", Category = "Мягкая мебель"},
                    new FurnitureType { Id = 7, Name="Кресла-мешки", Category = "Мягкая мебель"},
                    new FurnitureType { Id = 8, Name="Пуфы", Category = "Мягкая мебель"},
                    new FurnitureType { Id = 10, Name="Банкетки", Category = "Мягкая мебель"},
                    new FurnitureType { Id = 11, Name="Стенки", Category = "Гостинная"},
                    new FurnitureType { Id = 12, Name="Журнальные столики", Category = "Гостинная"},
                    new FurnitureType { Id = 13, Name="Тумбы под ТВ", Category = "Гостинная"},
                    new FurnitureType { Id = 14, Name="Кухонные гарнитуры", Category = "Кухня"},
                    new FurnitureType { Id = 15, Name="Кухонные уголки", Category = "Кухня"},
                    new FurnitureType { Id = 16, Name="Кухонные столы", Category = "Кухня"},
                    new FurnitureType { Id = 17, Name="Кухонные стулья", Category = "Кухня"},
                    new FurnitureType { Id = 18, Name="Барные стулья", Category = "Кухня"},
                    new FurnitureType { Id = 19, Name="Табуреты", Category = "Кухня"},
                    new FurnitureType { Id = 20, Name="Мойки", Category = "Кухня"},
                    new FurnitureType { Id = 21, Name="Столешницы", Category = "Кухня"},
                    new FurnitureType { Id = 22, Name="Стеновые панели", Category = "Кухня"},
                    new FurnitureType { Id = 23, Name="Комплектующие", Category = "Кухня"}
                });

            modelBuilder.Entity<Furniture>().HasData(
                new Furniture[]
                {
                    new Furniture { Id = 1, Name="Диван", Price = 111},
                    new Furniture { Id = 2, Name="Табуреты", Price = 222},
                    new Furniture { Id = 3, Name="Мойки", Price = 333},
                    new Furniture { Id = 4, Name="Столешницы", Price = 444},
                    new Furniture { Id = 5, Name="Кресла", Price = 555},
                    new Furniture { Id = 6, Name="Кресла-качалки", Price = 666},
                    new Furniture { Id = 7, Name="Пуфы", Price = 777},
                });
        }
    }
}
