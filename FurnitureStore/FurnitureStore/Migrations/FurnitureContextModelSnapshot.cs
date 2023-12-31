﻿// <auto-generated />
using FurnitureStore.Models.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FurnitureStore.Migrations
{
    [DbContext(typeof(FurnitureContext))]
    partial class FurnitureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FurnitureStore.Models.DomainModels.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryDesc = "",
                            CategoryName = "Couches"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryDesc = "",
                            CategoryName = "Accent Chairs"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryDesc = "",
                            CategoryName = "Side Tables"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryDesc = "",
                            CategoryName = "Consoles/Cabinets"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryDesc = "",
                            CategoryName = "Dining Tables"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryDesc = "",
                            CategoryName = "Dining Chairs"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryDesc = "",
                            CategoryName = "Dining Benches"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryDesc = "",
                            CategoryName = "Bedframes"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryDesc = "",
                            CategoryName = "Dressers"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryDesc = "",
                            CategoryName = "Nightstands"
                        },
                        new
                        {
                            CategoryID = 11,
                            CategoryDesc = "",
                            CategoryName = "Dining Sets"
                        },
                        new
                        {
                            CategoryID = 12,
                            CategoryDesc = "",
                            CategoryName = "Desks"
                        },
                        new
                        {
                            CategoryID = 13,
                            CategoryDesc = "",
                            CategoryName = "Office Chairs"
                        });
                });

            modelBuilder.Entity("FurnitureStore.Models.DomainModels.Furniture", b =>
                {
                    b.Property<int>("FurnitureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FurnitureID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<bool>("Clearance")
                        .HasColumnType("bit");

                    b.Property<string>("FurnImgThumbNailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FurnitureDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FurnitureImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FurnitureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FurniturePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FurnitureID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Furnitures");

                    b.HasData(
                        new
                        {
                            FurnitureID = 1,
                            CategoryID = 9,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A brown wood dresser perfect for your bedroom.",
                            FurnitureImgUrl = "/images/bedroom/BrownWoodDresser.jpg",
                            FurnitureName = "Brown Wood Dresser",
                            FurniturePrice = 349.99m
                        },
                        new
                        {
                            FurnitureID = 2,
                            CategoryID = 9,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A grey wood dresser perfect for your bedroom.",
                            FurnitureImgUrl = "/images/bedroom/GreyWoodDresser.jpg",
                            FurnitureName = "Grey Wood Dresser",
                            FurniturePrice = 349.99m
                        },
                        new
                        {
                            FurnitureID = 3,
                            CategoryID = 10,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A grey wood night stand to match your dresser.",
                            FurnitureImgUrl = "/images/bedroom/GreyWoodNightStand.jpg",
                            FurnitureName = "Grey Wood Nightstand",
                            FurniturePrice = 249.99m
                        },
                        new
                        {
                            FurnitureID = 4,
                            CategoryID = 8,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A solid black metal frame for your bed (sold seperately).",
                            FurnitureImgUrl = "/images/bedroom/MetalBedFrame.jpg",
                            FurnitureName = "Metal Bedframe",
                            FurniturePrice = 299.99m
                        },
                        new
                        {
                            FurnitureID = 5,
                            CategoryID = 8,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A cushioned frame for your bed (sold seperately).",
                            FurnitureImgUrl = "/images/bedroom/ModernBedFrame.jpg",
                            FurnitureName = "Modern Bedframe",
                            FurniturePrice = 399.99m
                        },
                        new
                        {
                            FurnitureID = 6,
                            CategoryID = 10,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A rustic nighstand perfect for your bedroom.",
                            FurnitureImgUrl = "/images/bedroom/RusticNighStand.jpg",
                            FurnitureName = "Rustic Nightstand",
                            FurniturePrice = 249.99m
                        },
                        new
                        {
                            FurnitureID = 7,
                            CategoryID = 9,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A white wooden dresser perfect for your bedroom.",
                            FurnitureImgUrl = "/images/bedroom/WhiteWoodDresser.jpg",
                            FurnitureName = "White Wood Dresser",
                            FurniturePrice = 499.99m
                        },
                        new
                        {
                            FurnitureID = 8,
                            CategoryID = 8,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A grey wooden frame for your bed (sold seperately).",
                            FurnitureImgUrl = "/images/bedroom/WoodBedFrame.jpg",
                            FurnitureName = "Wood Bedframe",
                            FurniturePrice = 399.99m
                        },
                        new
                        {
                            FurnitureID = 9,
                            CategoryID = 8,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A black wooden chair for your dining room.",
                            FurnitureImgUrl = "/images/bedroom/WoodBedFrame.jpg",
                            FurnitureName = "Black Wood Dining Chair",
                            FurniturePrice = 199.99m
                        },
                        new
                        {
                            FurnitureID = 10,
                            CategoryID = 6,
                            Clearance = true,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A black wooden chair for your dining room.",
                            FurnitureImgUrl = "/images/bedroom/WoodBedFrame.jpg",
                            FurnitureName = "Black X Dining Chair",
                            FurniturePrice = 199.99m
                        },
                        new
                        {
                            FurnitureID = 11,
                            CategoryID = 6,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A cream cushioned chair for your dining room.",
                            FurnitureImgUrl = "/images/bedroom/CreamDiningChair.jpg",
                            FurnitureName = "Cream Dining Chair",
                            FurniturePrice = 249.99m
                        },
                        new
                        {
                            FurnitureID = 12,
                            CategoryID = 11,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A dark wood 3pc dining set, perfect for your dining room.",
                            FurnitureImgUrl = "/images/bedroom/DarkDiningSet.jpg",
                            FurnitureName = "Dark 3pc Dining Set",
                            FurniturePrice = 599.99m
                        },
                        new
                        {
                            FurnitureID = 13,
                            CategoryID = 5,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A round, dark wood dining table.",
                            FurnitureImgUrl = "/images/bedroom/DarkRoundWoodDiningTable.jpg",
                            FurnitureName = "Dark Round Dining Table",
                            FurniturePrice = 599.99m
                        },
                        new
                        {
                            FurnitureID = 14,
                            CategoryID = 6,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A denim cushioned dining chair, perfect for your dining table.",
                            FurnitureImgUrl = "/images/bedroom/DenimDiningChair.jpg",
                            FurnitureName = "Denim Cushioned Dining Chair",
                            FurniturePrice = 249.99m
                        },
                        new
                        {
                            FurnitureID = 15,
                            CategoryID = 7,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A farmhouse style dining bench, perfect for your dining table.",
                            FurnitureImgUrl = "/images/bedroom/FarmhouseDiningBench.jpg",
                            FurnitureName = "Farmhouse Dining Bench",
                            FurniturePrice = 349.99m
                        },
                        new
                        {
                            FurnitureID = 16,
                            CategoryID = 6,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A farmhouse style dining chair, perfect for your dining table.",
                            FurnitureImgUrl = "/images/bedroom/FarmhouseDiningChair.jpg",
                            FurnitureName = "Farmhouse Dining Chair",
                            FurniturePrice = 199.99m
                        },
                        new
                        {
                            FurnitureID = 17,
                            CategoryID = 11,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A farmhouse style 3pc dining set, perfect for your dining room.",
                            FurnitureImgUrl = "/images/bedroom/FarmhouseDiningSet.jpg",
                            FurnitureName = "6pc Farmhouse Dining Set",
                            FurniturePrice = 1099.99m
                        },
                        new
                        {
                            FurnitureID = 18,
                            CategoryID = 5,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A farmhouse style dining table, perfect for your dining room.",
                            FurnitureImgUrl = "/images/bedroom/FarmhouseDiningTable.jpg",
                            FurnitureName = "Farmhouse Dining Table",
                            FurniturePrice = 699.99m
                        },
                        new
                        {
                            FurnitureID = 19,
                            CategoryID = 11,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A 6pc light wood dining set, perfect for your dining room.",
                            FurnitureImgUrl = "/images/bedroom/LightDiningSet.jpg",
                            FurnitureName = "6pc Light Wood Dining Set",
                            FurniturePrice = 1099.99m
                        },
                        new
                        {
                            FurnitureID = 20,
                            CategoryID = 5,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A light wood round dining table, perfect for your dining room.",
                            FurnitureImgUrl = "/images/bedroom/LightRoundWoodDiningTable.jpg",
                            FurnitureName = "Light Round Dining Table",
                            FurniturePrice = 599.99m
                        },
                        new
                        {
                            FurnitureID = 21,
                            CategoryID = 6,
                            Clearance = true,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A light wood dining chair, perfect for your dining table.",
                            FurnitureImgUrl = "/images/bedroom/LightXDiningChair.jpg",
                            FurnitureName = "Light X Dining Chair",
                            FurniturePrice = 199.99m
                        },
                        new
                        {
                            FurnitureID = 22,
                            CategoryID = 7,
                            Clearance = true,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A rustic style dining bench, perfect for your dining table.",
                            FurnitureImgUrl = "/images/bedroom/RusticDiningBench.jpg",
                            FurnitureName = "Rustic Dining Bench",
                            FurniturePrice = 349.99m
                        },
                        new
                        {
                            FurnitureID = 23,
                            CategoryID = 5,
                            Clearance = true,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A rustic style dining table, perfect for your dining room.",
                            FurnitureImgUrl = "/images/bedroom/RusticDiningTable.jpg",
                            FurnitureName = "Rustic Dining Table",
                            FurniturePrice = 699.99m
                        },
                        new
                        {
                            FurnitureID = 24,
                            CategoryID = 3,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A wire basket side table to store blankets.",
                            FurnitureImgUrl = "/images/bedroom/BasketSideTable.jpg",
                            FurnitureName = "Basket Side Table",
                            FurniturePrice = 199.99m
                        },
                        new
                        {
                            FurnitureID = 25,
                            CategoryID = 3,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A wire style coffee table for your living room.",
                            FurnitureImgUrl = "/images/bedroom/CageCoffeeTable.jpg",
                            FurnitureName = "Wire Coffee Table",
                            FurniturePrice = 249.99m
                        },
                        new
                        {
                            FurnitureID = 26,
                            CategoryID = 2,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A cream colored accent chair, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/CreamChair.jpg",
                            FurnitureName = "Cream Accent Chair",
                            FurniturePrice = 349.99m
                        },
                        new
                        {
                            FurnitureID = 27,
                            CategoryID = 4,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A wooden cream console table, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/CreamConsoleTable.jpg",
                            FurnitureName = "Cream Console Table",
                            FurniturePrice = 349.99m
                        },
                        new
                        {
                            FurnitureID = 28,
                            CategoryID = 4,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A rustic style cabinet with sliding wooden door, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/DarkRusticCabinet.jpg",
                            FurnitureName = "Dark Rustic Cabinet",
                            FurniturePrice = 399.99m
                        },
                        new
                        {
                            FurnitureID = 29,
                            CategoryID = 4,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A rustic style cabinet with glass doors, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/DarkWoodCabinet.jpg",
                            FurnitureName = "Dark Wood Cabinet",
                            FurniturePrice = 499.99m
                        },
                        new
                        {
                            FurnitureID = 30,
                            CategoryID = 2,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A denim accent chair, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/DenimChair.jpg",
                            FurnitureName = "Denim Accent Chair",
                            FurniturePrice = 349.99m
                        },
                        new
                        {
                            FurnitureID = 31,
                            CategoryID = 2,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A faux leather accent chair, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/FauxLeatherChair.jpg",
                            FurnitureName = "Faux Leather Accent Chair",
                            FurniturePrice = 399.99m
                        },
                        new
                        {
                            FurnitureID = 32,
                            CategoryID = 1,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A faux leather couch, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/FauxLeatherCouch.jpg",
                            FurnitureName = "Faux Leather Couch",
                            FurniturePrice = 799.99m
                        },
                        new
                        {
                            FurnitureID = 33,
                            CategoryID = 2,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A faux leather recliner, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/FauxLeatherRecliner.jpg",
                            FurnitureName = "Faux Leather Recliner",
                            FurniturePrice = 599.99m
                        },
                        new
                        {
                            FurnitureID = 34,
                            CategoryID = 4,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A TV stand with a built in fireplace.",
                            FurnitureImgUrl = "/images/bedroom/FireplaceTVStand.jpg",
                            FurnitureName = "Fireplace TV Stand",
                            FurniturePrice = 699.99m
                        },
                        new
                        {
                            FurnitureID = 35,
                            CategoryID = 3,
                            Clearance = true,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A hex shaped side table, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/HexSideTable.jpg",
                            FurnitureName = "Hex Side Table",
                            FurniturePrice = 199.99m
                        },
                        new
                        {
                            FurnitureID = 36,
                            CategoryID = 4,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A light wood, rustic style cabinet, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/LightRusticCabinet.jpg",
                            FurnitureName = "Light Rustic Cabinet",
                            FurniturePrice = 399.99m
                        },
                        new
                        {
                            FurnitureID = 37,
                            CategoryID = 4,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A light wood cabinet, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/LightWoodCabinet.jpg",
                            FurnitureName = "Light Wood Cabinet",
                            FurniturePrice = 499.99m
                        },
                        new
                        {
                            FurnitureID = 38,
                            CategoryID = 3,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "An industrial style coffee table perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/RusticCoffeeTable.jpg",
                            FurnitureName = "Industrial Coffee Table",
                            FurniturePrice = 399.99m
                        },
                        new
                        {
                            FurnitureID = 39,
                            CategoryID = 4,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A rustic style console table perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/RusticConsoleTable.jpg",
                            FurnitureName = "Rustic Console Table",
                            FurniturePrice = 299.99m
                        },
                        new
                        {
                            FurnitureID = 40,
                            CategoryID = 4,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A rustic style TV stand, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/RusticTVStand.jpg",
                            FurnitureName = "Rustic TV Stand",
                            FurniturePrice = 299.99m
                        },
                        new
                        {
                            FurnitureID = 41,
                            CategoryID = 3,
                            Clearance = true,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A scalloped coffee table, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/ScallopCoffeeTable.jpg",
                            FurnitureName = "Scallop Coffee Table",
                            FurniturePrice = 299.99m
                        },
                        new
                        {
                            FurnitureID = 42,
                            CategoryID = 3,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A scalloped side table, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/ScallopSideTable.jpg",
                            FurnitureName = "Scallop Side Table",
                            FurniturePrice = 199.99m
                        },
                        new
                        {
                            FurnitureID = 43,
                            CategoryID = 1,
                            Clearance = true,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A shell shaped loveseat, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/ShellCouch.jpg",
                            FurnitureName = "Shell Loveseat",
                            FurniturePrice = 599.99m
                        },
                        new
                        {
                            FurnitureID = 44,
                            CategoryID = 1,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A speckled cream loveseat, perfect for your living room.",
                            FurnitureImgUrl = "/images/bedroom/VanillaSpeckedLoveSeat.jpg",
                            FurnitureName = "Vanilla Speckled Loveseat",
                            FurniturePrice = 599.99m
                        },
                        new
                        {
                            FurnitureID = 45,
                            CategoryID = 12,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A cream colored wooden desk for your office.",
                            FurnitureImgUrl = "/images/bedroom/CreamDesk.jpg",
                            FurnitureName = "Cream Desk",
                            FurniturePrice = 349.99m
                        },
                        new
                        {
                            FurnitureID = 46,
                            CategoryID = 13,
                            Clearance = true,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A cream cushioned swivel chair for your office.",
                            FurnitureImgUrl = "/images/bedroom/CreamDeskChair.jpg",
                            FurnitureName = "Cream Office Chair",
                            FurniturePrice = 199.99m
                        },
                        new
                        {
                            FurnitureID = 47,
                            CategoryID = 13,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A wood and cream cushioned swivel chair for your office.",
                            FurnitureImgUrl = "/images/bedroom/CreamWoodDeskChair.jpg",
                            FurnitureName = "Cream Wood Office Chair",
                            FurniturePrice = 199.99m
                        },
                        new
                        {
                            FurnitureID = 48,
                            CategoryID = 12,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A dark wood desk for your office.",
                            FurnitureImgUrl = "/images/bedroom/DarkWoodDesk.jpg",
                            FurnitureName = "Dark Wood Desk",
                            FurniturePrice = 299.99m
                        },
                        new
                        {
                            FurnitureID = 49,
                            CategoryID = 12,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A farmhouse style desk for your office.",
                            FurnitureImgUrl = "/images/bedroom/FarmhouseDesk.jpg",
                            FurnitureName = "Farmhouse Desk",
                            FurniturePrice = 299.99m
                        },
                        new
                        {
                            FurnitureID = 50,
                            CategoryID = 13,
                            Clearance = false,
                            FurnImgThumbNailUrl = "",
                            FurnitureDescription = "A faux leather swivel chair desk for your office.",
                            FurnitureImgUrl = "/images/bedroom/FauxLeatherDeskChair.jpg",
                            FurnitureName = "Faux Leather Office Chair",
                            FurniturePrice = 199.99m
                        });
                });

            modelBuilder.Entity("FurnitureStore.Models.DomainModels.Furniture", b =>
                {
                    b.HasOne("FurnitureStore.Models.DomainModels.Category", "Category")
                        .WithMany("Furnitures")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FurnitureStore.Models.DomainModels.Category", b =>
                {
                    b.Navigation("Furnitures");
                });
#pragma warning restore 612, 618
        }
    }
}
