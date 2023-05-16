﻿// <auto-generated />
using System;
using IkProjemCore3dot1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IkProjemCore3dot1.Migrations
{
    [DbContext(typeof(PersonelContext))]
    [Migration("20230515184407_c5")]
    partial class c5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IkProjemCore3dot1.Models.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActiveOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ActivetedBy")
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("AktifMi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EditedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("IseGirisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reserved1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reserved2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SirketNumarasi")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UnvanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnvanId");

                    b.ToTable("Personel16");
                });

            modelBuilder.Entity("IkProjemCore3dot1.Models.Roller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActiveOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ActivetedBy")
                        .HasColumnType("int");

                    b.Property<int>("AktifMi")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EditedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reserved1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reserved2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roller");
                });

            modelBuilder.Entity("IkProjemCore3dot1.Models.Unvan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActiveOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ActivetedBy")
                        .HasColumnType("int");

                    b.Property<int>("AktifMi")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EditedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reserved1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reserved2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unvan");
                });

            modelBuilder.Entity("IkProjemCore3dot1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActiveOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ActivetedBy")
                        .HasColumnType("int");

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AktifMi")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EditedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reserved1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reserved2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("IkProjemCore3dot1.Models.WebItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ActiveOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ActivetedBy")
                        .HasColumnType("int");

                    b.Property<int>("AktifMi")
                        .HasColumnType("int");

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControllerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EditedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reserved1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reserved2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpperId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WebItem");
                });

            modelBuilder.Entity("IkProjemCore3dot1.Models.ct_RolePrivilege", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActiveOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ActivetedBy")
                        .HasColumnType("int");

                    b.Property<int>("AktifMi")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EditedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reserved1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reserved2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("WebItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ct_RolePrivilege");
                });

            modelBuilder.Entity("IkProjemCore3dot1.Models.ct_UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActiveOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ActivetedBy")
                        .HasColumnType("int");

                    b.Property<int>("AktifMi")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EditedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EditedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reserved1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reserved2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ct_UserRole");
                });

            modelBuilder.Entity("IkProjemCore3dot1.Models.Personel", b =>
                {
                    b.HasOne("IkProjemCore3dot1.Models.Unvan", "Unvan2")
                        .WithMany("Personel")
                        .HasForeignKey("UnvanId");
                });
#pragma warning restore 612, 618
        }
    }
}
