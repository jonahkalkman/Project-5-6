﻿// <auto-generated />
using login2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace login2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171211131515_SolidVersion")]
    partial class SolidVersion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("login2.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("login2.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aantal");

                    b.Property<string>("Beschrijving");

                    b.Property<string>("Merk");

                    b.Property<string>("Model_naam");

                    b.Property<int>("Order_nummer");

                    b.Property<int>("Prijs");

                    b.Property<int>("Product_Id");

                    b.Property<string>("User_Id");

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("login2.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("login2.Models.Drone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aantal");

                    b.Property<int>("Aantal_gekocht");

                    b.Property<int>("Aantal_rotors");

                    b.Property<string>("Afbeelding");

                    b.Property<int>("CategorieId");

                    b.Property<int>("Grootte");

                    b.Property<string>("Kleur");

                    b.Property<string>("Merk");

                    b.Property<string>("Naam");

                    b.Property<int>("Prijs");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Drones");
                });

            modelBuilder.Entity("login2.Models.Fotocamera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aantal");

                    b.Property<int>("Aantal_gekocht");

                    b.Property<string>("Afbeelding");

                    b.Property<int>("CategorieId");

                    b.Property<string>("Flits");

                    b.Property<string>("Kleur");

                    b.Property<int>("Max_Bereik");

                    b.Property<int>("MegaPixels");

                    b.Property<string>("Merk");

                    b.Property<int>("Min_Bereik");

                    b.Property<string>("Naam");

                    b.Property<int>("Prijs");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Fotocameras");
                });

            modelBuilder.Entity("login2.Models.Horloge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aantal");

                    b.Property<int>("Aantal_gekocht");

                    b.Property<string>("Afbeelding");

                    b.Property<int>("CategorieId");

                    b.Property<string>("Geslacht");

                    b.Property<int>("Grootte");

                    b.Property<string>("Kleur");

                    b.Property<string>("Materiaal");

                    b.Property<string>("Merk");

                    b.Property<string>("Naam");

                    b.Property<int>("Prijs");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Horloges");
                });

            modelBuilder.Entity("login2.Models.Kabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aantal");

                    b.Property<int>("Aantal_gekocht");

                    b.Property<string>("Afbeelding");

                    b.Property<int>("CategorieId");

                    b.Property<string>("Kleur");

                    b.Property<int>("Lengte");

                    b.Property<string>("Merk");

                    b.Property<string>("Naam");

                    b.Property<int>("Prijs");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Kabels");
                });

            modelBuilder.Entity("login2.Models.Schoen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aantal");

                    b.Property<int>("Aantal_gekocht");

                    b.Property<string>("Afbeelding");

                    b.Property<int>("CategorieId");

                    b.Property<string>("Geslacht");

                    b.Property<string>("Kleur");

                    b.Property<int>("Maat");

                    b.Property<string>("Materiaal");

                    b.Property<string>("Merk");

                    b.Property<string>("Naam");

                    b.Property<int>("Prijs");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Schoenen");
                });

            modelBuilder.Entity("login2.Models.Spelcomputer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Aantal");

                    b.Property<int>("Aantal_gekocht");

                    b.Property<string>("Afbeelding");

                    b.Property<int>("CategorieId");

                    b.Property<string>("Kleur");

                    b.Property<string>("Merk");

                    b.Property<string>("Naam");

                    b.Property<int>("Opslagcapaciteit");

                    b.Property<string>("Opties");

                    b.Property<int>("Prijs");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Spelcomputers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("login2.Models.Drone", b =>
                {
                    b.HasOne("login2.Models.Categorie", "Categorie")
                        .WithMany("Drones")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("login2.Models.Fotocamera", b =>
                {
                    b.HasOne("login2.Models.Categorie", "Categorie")
                        .WithMany("Fotocameras")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("login2.Models.Horloge", b =>
                {
                    b.HasOne("login2.Models.Categorie", "Categorie")
                        .WithMany("Horloges")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("login2.Models.Kabel", b =>
                {
                    b.HasOne("login2.Models.Categorie", "Categorie")
                        .WithMany("Kabels")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("login2.Models.Schoen", b =>
                {
                    b.HasOne("login2.Models.Categorie", "Categorie")
                        .WithMany("Schoenen")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("login2.Models.Spelcomputer", b =>
                {
                    b.HasOne("login2.Models.Categorie", "Categorie")
                        .WithMany("Spelcomputers")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("login2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("login2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("login2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("login2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
