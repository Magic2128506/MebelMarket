﻿// <auto-generated />
using System;
using MebelMarket.SqlDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MebelMarket.Migrations
{
    [DbContext(typeof(MebelMarketContext))]
    [Migration("20210407120752_FurnitureColors")]
    partial class FurnitureColors
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MebelMarket.Domain.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Color1")
                        .HasColumnType("int");

                    b.Property<int?>("Color10")
                        .HasColumnType("int");

                    b.Property<int?>("Color11")
                        .HasColumnType("int");

                    b.Property<int?>("Color12")
                        .HasColumnType("int");

                    b.Property<int?>("Color13")
                        .HasColumnType("int");

                    b.Property<int?>("Color14")
                        .HasColumnType("int");

                    b.Property<int?>("Color15")
                        .HasColumnType("int");

                    b.Property<int?>("Color2")
                        .HasColumnType("int");

                    b.Property<int?>("Color3")
                        .HasColumnType("int");

                    b.Property<int?>("Color4")
                        .HasColumnType("int");

                    b.Property<int?>("Color5")
                        .HasColumnType("int");

                    b.Property<int?>("Color6")
                        .HasColumnType("int");

                    b.Property<int?>("Color7")
                        .HasColumnType("int");

                    b.Property<int?>("Color8")
                        .HasColumnType("int");

                    b.Property<int?>("Color9")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiscountValue")
                        .HasColumnType("int");

                    b.Property<string>("FacadeMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ForOffice")
                        .HasColumnType("bit");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("Upholstery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Furnitures");
                });

            modelBuilder.Entity("MebelMarket.Domain.FurnitureCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FurnitureCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Мягкая мебель"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Гостиная"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Кухня"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Спальня"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Шкафы"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Детская мебель"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Прихожая"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Офис"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Сад и дача"
                        });
                });

            modelBuilder.Entity("MebelMarket.Domain.FurnitureType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("FurnitureTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Диваны прямые"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Диваны угловые"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "Диваны для офиса"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Name = "Диваны детские"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Name = "Кресла"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Name = "Кресла-качалки"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Name = "Кресла-мешки"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Name = "Пуфы"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Name = "Банкетки"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Name = "Стенки"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Name = "Журнальные столики"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Name = "Тумбы под ТВ"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Name = "Кухонные гарнитуры"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Name = "Кухонные уголки"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Name = "Кухонные столы"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Name = "Кухонные стулья"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            Name = "Барные стулья"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Name = "Табуреты"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            Name = "Мойки"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Name = "Столешницы"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            Name = "Стеновые панели"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 3,
                            Name = "Комплектующие"
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Name = "Спальные гарнитуры"
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 4,
                            Name = "Кровати"
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 4,
                            Name = "Кроватные основания"
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 4,
                            Name = "Матрасы"
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 4,
                            Name = "Банкетки и пуфы"
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 4,
                            Name = "Туалетные столики"
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 4,
                            Name = "Комоды"
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 4,
                            Name = "Тумбы"
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 4,
                            Name = "Зеркала"
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 5,
                            Name = "Шкафы купе"
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 5,
                            Name = "Шкафы распашные"
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 5,
                            Name = "Стеллажи"
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 6,
                            Name = "Детские кровати"
                        },
                        new
                        {
                            Id = 36,
                            CategoryId = 6,
                            Name = "Стулья для детской"
                        },
                        new
                        {
                            Id = 37,
                            CategoryId = 6,
                            Name = "Детские комплексы"
                        },
                        new
                        {
                            Id = 38,
                            CategoryId = 7,
                            Name = "Тумбы для обуви"
                        },
                        new
                        {
                            Id = 39,
                            CategoryId = 7,
                            Name = "Вешалки"
                        },
                        new
                        {
                            Id = 40,
                            CategoryId = 7,
                            Name = "Пуфы"
                        },
                        new
                        {
                            Id = 41,
                            CategoryId = 7,
                            Name = "Скамьи"
                        },
                        new
                        {
                            Id = 42,
                            CategoryId = 7,
                            Name = "Прихожие"
                        },
                        new
                        {
                            Id = 43,
                            CategoryId = 8,
                            Name = "Компьютерные столы"
                        },
                        new
                        {
                            Id = 44,
                            CategoryId = 8,
                            Name = "Офисные кресла"
                        },
                        new
                        {
                            Id = 45,
                            CategoryId = 8,
                            Name = "Письменные столы"
                        },
                        new
                        {
                            Id = 46,
                            CategoryId = 8,
                            Name = "Полки"
                        },
                        new
                        {
                            Id = 47,
                            CategoryId = 8,
                            Name = "Офисные тумбы"
                        },
                        new
                        {
                            Id = 48,
                            CategoryId = 8,
                            Name = "Офисные стулья"
                        },
                        new
                        {
                            Id = 49,
                            CategoryId = 9,
                            Name = "Раскладушки"
                        },
                        new
                        {
                            Id = 50,
                            CategoryId = 9,
                            Name = "Шезлонги и лежаки"
                        },
                        new
                        {
                            Id = 51,
                            CategoryId = 9,
                            Name = "Садовые скамейки"
                        },
                        new
                        {
                            Id = 52,
                            CategoryId = 9,
                            Name = "Этажерки"
                        },
                        new
                        {
                            Id = 53,
                            CategoryId = 9,
                            Name = "Мебель из ротанга"
                        },
                        new
                        {
                            Id = 54,
                            CategoryId = 9,
                            Name = "Прочая мебель"
                        });
                });

            modelBuilder.Entity("MebelMarket.Domain.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MebelMarket.Domain.Furniture", b =>
                {
                    b.HasOne("MebelMarket.Domain.FurnitureType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("MebelMarket.Domain.FurnitureType", b =>
                {
                    b.HasOne("MebelMarket.Domain.FurnitureCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
