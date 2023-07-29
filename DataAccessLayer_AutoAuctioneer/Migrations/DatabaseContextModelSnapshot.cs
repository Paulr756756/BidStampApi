﻿// <auto-generated />
using System;
using System.Collections.Generic;
using DataAccessLibrary_AutoAuctioneer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccessLayer_AutoAuctioneer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.Car", b =>
                {
                    b.Property<Guid>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<List<string>>("AftermarketUpgrades")
                        .HasColumnType("text[]");

                    b.Property<List<string>>("AudioAndEntertainment")
                        .HasColumnType("text[]");

                    b.Property<string>("BodyStyle")
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("EngineDisplacement")
                        .HasColumnType("double precision");

                    b.Property<string>("EngineType")
                        .HasColumnType("text");

                    b.Property<List<string>>("ExteriorFeatures")
                        .HasColumnType("text[]");

                    b.Property<double?>("FuelEfficiency")
                        .HasColumnType("double precision");

                    b.Property<bool>("HasAccidentHistory")
                        .HasColumnType("boolean");

                    b.Property<int?>("Horsepower")
                        .HasColumnType("integer");

                    b.Property<List<string>>("ImageUrls")
                        .HasColumnType("text[]");

                    b.Property<string>("InteriorColor")
                        .HasColumnType("text");

                    b.Property<List<string>>("InteriorFeatures")
                        .HasColumnType("text[]");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Mileage")
                        .HasColumnType("integer");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("NumberOfPreviousOwners")
                        .HasColumnType("integer");

                    b.Property<List<string>>("OwnershipHistory")
                        .HasColumnType("text[]");

                    b.Property<List<string>>("SafetyFeatures")
                        .HasColumnType("text[]");

                    b.Property<int>("SeatingCapacity")
                        .HasColumnType("integer");

                    b.Property<List<string>>("ServiceRecords")
                        .HasColumnType("text[]");

                    b.Property<string>("Suspension")
                        .HasColumnType("text");

                    b.Property<List<string>>("TechnologyFeatures")
                        .HasColumnType("text[]");

                    b.Property<int?>("Torque")
                        .HasColumnType("integer");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WheelsAndTires")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.CarPart", b =>
                {
                    b.Property<Guid>("CarpartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("MarketPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PartType")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("CarpartId");

                    b.HasIndex("UserId");

                    b.ToTable("CarParts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CarPart");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.Listing", b =>
                {
                    b.Property<Guid>("ListingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CarId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CarPartId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("ListingId");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.HasIndex("CarPartId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Listings");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("VerifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccessLibrary_AutoAuctioneer.Models.Bid", b =>
                {
                    b.Property<Guid>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("BidAmount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BidTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ListingId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("BidId");

                    b.HasIndex("ListingId");

                    b.HasIndex("UserId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.CustomizationPart", b =>
                {
                    b.HasBaseType("DataAccessLayer_AutoAuctioneer.Models.CarPart");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("CustomizationPart");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.Engine", b =>
                {
                    b.HasBaseType("DataAccessLayer_AutoAuctioneer.Models.CarPart");

                    b.Property<double>("Displacement")
                        .HasColumnType("double precision");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Horsepower")
                        .HasColumnType("integer");

                    b.Property<int>("Torque")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("Engine");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.IndividualCarPart", b =>
                {
                    b.HasBaseType("DataAccessLayer_AutoAuctioneer.Models.CarPart");

                    b.Property<string>("CarMake")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("IndividualCarPart");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.Car", b =>
                {
                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.CarPart", b =>
                {
                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.User", "User")
                        .WithMany("CarParts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.Listing", b =>
                {
                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.Car", "Car")
                        .WithOne("Listing")
                        .HasForeignKey("DataAccessLayer_AutoAuctioneer.Models.Listing", "CarId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.CarPart", "CarPart")
                        .WithOne("Listing")
                        .HasForeignKey("DataAccessLayer_AutoAuctioneer.Models.Listing", "CarPartId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("CarPart");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccessLibrary_AutoAuctioneer.Models.Bid", b =>
                {
                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.Listing", "Listing")
                        .WithMany("Bids")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.User", "User")
                        .WithMany("Bids")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Listing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.CustomizationPart", b =>
                {
                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.CarPart", "CarPart")
                        .WithOne("CustomizationPart")
                        .HasForeignKey("DataAccessLayer_AutoAuctioneer.Models.CustomizationPart", "CarpartId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("CarPart");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.Engine", b =>
                {
                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.CarPart", "CarPart")
                        .WithOne("Engine")
                        .HasForeignKey("DataAccessLayer_AutoAuctioneer.Models.Engine", "CarpartId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("CarPart");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.IndividualCarPart", b =>
                {
                    b.HasOne("DataAccessLayer_AutoAuctioneer.Models.CarPart", "CarPart")
                        .WithOne("IndividualCarPart")
                        .HasForeignKey("DataAccessLayer_AutoAuctioneer.Models.IndividualCarPart", "CarpartId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("CarPart");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.Car", b =>
                {
                    b.Navigation("Listing");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.CarPart", b =>
                {
                    b.Navigation("CustomizationPart");

                    b.Navigation("Engine");

                    b.Navigation("IndividualCarPart");

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.Listing", b =>
                {
                    b.Navigation("Bids");
                });

            modelBuilder.Entity("DataAccessLayer_AutoAuctioneer.Models.User", b =>
                {
                    b.Navigation("Bids");

                    b.Navigation("CarParts");

                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
