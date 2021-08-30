﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210829135055_AddMoreTablesForCoordination")]
    partial class AddMoreTablesForCoordination
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Categorie", b =>
                {
                    b.Property<Guid>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("ServerTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("CategorieId");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("Entities.Models.ExternalLogin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ExternalLogin");
                });

            modelBuilder.Entity("Entities.Models.Gamme", b =>
                {
                    b.Property<Guid>("GammeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategorieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("MarqueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Prix_Unité")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ServerTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StyleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("GammeId");

                    b.HasIndex("CategorieId");

                    b.HasIndex("MarqueId");

                    b.HasIndex("StyleId");

                    b.ToTable("Gamme");
                });

            modelBuilder.Entity("Entities.Models.GrosGateau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Auteur")
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("Categorie")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Date_Ajout")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_gros_gateau");
                });

            modelBuilder.Entity("Entities.Models.Marque", b =>
                {
                    b.Property<Guid>("MarqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("ServerTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MarqueId");

                    b.ToTable("Marque");
                });

            modelBuilder.Entity("Entities.Models.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Refreshable")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("Entities.Models.Reservation", b =>
                {
                    b.Property<int>("Reference")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse_Livraison")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Auteur")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Client")
                        .HasColumnType("Varchar(75)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Livraison")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dept_Auteur")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Description")
                        .HasColumnType("Varchar(100)");

                    b.Property<Guid?>("GammeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Gateau")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Gateau_Pour")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Genre_Client")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Heure_Livraison")
                        .HasColumnType("Varchar(10)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Mention_Sur_Gateau")
                        .HasColumnType("Varchar(100)");

                    b.Property<decimal?>("Montant")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Nombre")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Num2_Client")
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Num_Client")
                        .HasColumnType("Varchar(50)");

                    b.Property<decimal?>("Part")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Payée")
                        .HasColumnType("Varchar(5)");

                    b.Property<int?>("TransId")
                        .HasColumnType("int");

                    b.HasKey("Reference");

                    b.HasIndex("GammeId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("Entities.Models.Style", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("ServerTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Style");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("ServerTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Entities.Models.Gamme", b =>
                {
                    b.HasOne("Entities.Models.Categorie", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieId");

                    b.HasOne("Entities.Models.Marque", "Marque")
                        .WithMany()
                        .HasForeignKey("MarqueId");

                    b.HasOne("Entities.Models.Style", "Style")
                        .WithMany()
                        .HasForeignKey("StyleId");

                    b.Navigation("Categorie");

                    b.Navigation("Marque");

                    b.Navigation("Style");
                });

            modelBuilder.Entity("Entities.Models.Reservation", b =>
                {
                    b.HasOne("Entities.Models.Gamme", "Gamme")
                        .WithMany()
                        .HasForeignKey("GammeId");

                    b.Navigation("Gamme");
                });
#pragma warning restore 612, 618
        }
    }
}
