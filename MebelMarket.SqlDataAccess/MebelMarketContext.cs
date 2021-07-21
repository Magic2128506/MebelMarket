using MebelMarket.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MebelMarket.SqlDataAccess
{
    public class MebelMarketContext : DbContext
    {
        public MebelMarketContext(DbContextOptions<MebelMarketContext> Options) : base(Options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<FurnitureType> FurnitureTypes { get; set; }
        public DbSet<FurnitureCategory> FurnitureCategories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FurnitureCategory>().HasData(
                new FurnitureCategory[]
                {
                    new FurnitureCategory { Id = 1, Name="Мягкая мебель"},
                    new FurnitureCategory { Id = 2, Name="Гостиная"},
                    new FurnitureCategory { Id = 3, Name="Кухня"},
                    new FurnitureCategory { Id = 4, Name="Спальня"},
                    new FurnitureCategory { Id = 5, Name="Шкафы"},
                    new FurnitureCategory { Id = 6, Name="Детская мебель"},
                    new FurnitureCategory { Id = 7, Name="Прихожая"},
                    new FurnitureCategory { Id = 8, Name="Офис"},
                    new FurnitureCategory { Id = 9, Name="Сад и дача"},
                });

            modelBuilder.Entity<FurnitureType>().HasData(
                new FurnitureType[]
                {
                    new FurnitureType { Id = 1, Name="Диваны прямые", CategoryId = 1},
                    new FurnitureType { Id = 2, Name="Диваны угловые", CategoryId = 1},
                    new FurnitureType { Id = 3, Name="Диваны для офиса", CategoryId = 1},
                    new FurnitureType { Id = 4, Name="Диваны детские", CategoryId = 1},
                    new FurnitureType { Id = 5, Name="Кресла", CategoryId = 1},
                    new FurnitureType { Id = 6, Name="Кресла-качалки", CategoryId = 1},
                    new FurnitureType { Id = 7, Name="Кресла-мешки", CategoryId = 1},
                    new FurnitureType { Id = 8, Name="Пуфы", CategoryId = 1},
                    new FurnitureType { Id = 9, Name="Банкетки", CategoryId = 1},
                    new FurnitureType { Id = 10, Name="Стенки", CategoryId = 2},
                    new FurnitureType { Id = 11, Name="Журнальные столики", CategoryId = 2},
                    new FurnitureType { Id = 12, Name="Тумбы под ТВ", CategoryId = 2},
                    new FurnitureType { Id = 13, Name="Кухонные гарнитуры", CategoryId = 3},
                    new FurnitureType { Id = 14, Name="Кухонные уголки", CategoryId = 3},
                    new FurnitureType { Id = 15, Name="Кухонные столы", CategoryId = 3},
                    new FurnitureType { Id = 16, Name="Кухонные стулья", CategoryId = 3},
                    new FurnitureType { Id = 17, Name="Барные стулья", CategoryId = 3},
                    new FurnitureType { Id = 18, Name="Табуреты", CategoryId = 3},
                    new FurnitureType { Id = 19, Name="Мойки", CategoryId = 3},
                    new FurnitureType { Id = 20, Name="Столешницы", CategoryId = 3},
                    new FurnitureType { Id = 21, Name="Стеновые панели", CategoryId = 3},
                    new FurnitureType { Id = 22, Name="Комплектующие", CategoryId = 3},
                    new FurnitureType { Id = 23, Name="Спальные гарнитуры", CategoryId = 4},
                    new FurnitureType { Id = 24, Name="Кровати", CategoryId = 4 },
                    new FurnitureType { Id = 25, Name="Кроватные основания", CategoryId = 4},
                    new FurnitureType { Id = 26, Name="Матрасы", CategoryId = 4},
                    new FurnitureType { Id = 27, Name="Банкетки и пуфы", CategoryId = 4},
                    new FurnitureType { Id = 28, Name="Туалетные столики", CategoryId = 4},
                    new FurnitureType { Id = 29, Name="Комоды", CategoryId = 4},
                    new FurnitureType { Id = 30, Name="Тумбы", CategoryId = 4},
                    new FurnitureType { Id = 31, Name="Зеркала", CategoryId = 4},
                    new FurnitureType { Id = 32, Name="Шкафы купе", CategoryId = 5},
                    new FurnitureType { Id = 33, Name="Шкафы распашные", CategoryId = 5},
                    new FurnitureType { Id = 34, Name="Стеллажи", CategoryId = 5},
                    new FurnitureType { Id = 35, Name="Детские кровати", CategoryId = 6},
                    new FurnitureType { Id = 36, Name="Стулья для детской", CategoryId = 6},
                    new FurnitureType { Id = 37, Name="Детские комплексы", CategoryId = 6},
                    new FurnitureType { Id = 38, Name="Тумбы для обуви", CategoryId = 7},
                    new FurnitureType { Id = 39, Name="Вешалки", CategoryId = 7},
                    new FurnitureType { Id = 40, Name="Пуфы", CategoryId = 7},
                    new FurnitureType { Id = 41, Name="Скамьи", CategoryId = 7},
                    new FurnitureType { Id = 42, Name="Прихожие", CategoryId = 7},
                    new FurnitureType { Id = 43, Name="Компьютерные столы", CategoryId = 8},
                    new FurnitureType { Id = 44, Name="Офисные кресла", CategoryId = 8},
                    new FurnitureType { Id = 45, Name="Письменные столы", CategoryId = 8},
                    new FurnitureType { Id = 46, Name="Полки", CategoryId = 8},
                    new FurnitureType { Id = 47, Name="Офисные тумбы", CategoryId = 8},
                    new FurnitureType { Id = 48, Name="Офисные стулья", CategoryId = 8},
                    new FurnitureType { Id = 49, Name="Раскладушки", CategoryId = 9},
                    new FurnitureType { Id = 50, Name="Шезлонги и лежаки", CategoryId = 9},
                    new FurnitureType { Id = 51, Name="Садовые скамейки", CategoryId = 9},
                    new FurnitureType { Id = 52, Name="Этажерки", CategoryId = 9},
                    new FurnitureType { Id = 53, Name="Мебель из ротанга", CategoryId = 9},
                    new FurnitureType { Id = 54, Name="Прочая мебель", CategoryId = 9}
                });
        }
    }
}
