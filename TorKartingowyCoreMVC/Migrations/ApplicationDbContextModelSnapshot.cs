﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorKartingowyCoreMVC.Data;

#nullable disable

namespace TorKartingowyCoreMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.DostepneGodziny", b =>
                {
                    b.Property<string>("TorData")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("G08")
                        .HasColumnType("int");

                    b.Property<int>("G09")
                        .HasColumnType("int");

                    b.Property<int>("G10")
                        .HasColumnType("int");

                    b.Property<int>("G11")
                        .HasColumnType("int");

                    b.Property<int>("G12")
                        .HasColumnType("int");

                    b.Property<int>("G13")
                        .HasColumnType("int");

                    b.Property<int>("G14")
                        .HasColumnType("int");

                    b.Property<int>("G15")
                        .HasColumnType("int");

                    b.Property<int>("G16")
                        .HasColumnType("int");

                    b.Property<int>("G17")
                        .HasColumnType("int");

                    b.Property<int>("G18")
                        .HasColumnType("int");

                    b.Property<int>("G19")
                        .HasColumnType("int");

                    b.Property<int>("G20")
                        .HasColumnType("int");

                    b.HasKey("TorData");

                    b.ToTable("DostepneGodziny");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Gokart", b =>
                {
                    b.Property<int>("Numer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numer"), 1L, 1);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Numer");

                    b.ToTable("Gokarty");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Klient", b =>
                {
                    b.Property<int>("Numer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numer"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Rekord")
                        .HasColumnType("real");

                    b.Property<bool?>("Szkolenie")
                        .HasColumnType("bit");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("Numer");

                    b.ToTable("Klienci");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Pracownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Pensja")
                        .HasColumnType("float");

                    b.Property<string>("Stanowisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("Id");

                    b.ToTable("Pracownicy");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.RejestrPrac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("PracownikId")
                        .HasColumnType("int");

                    b.Property<string>("WykonanaPraca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PracownikId");

                    b.ToTable("RejestrPrac");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Rezerwacja", b =>
                {
                    b.Property<int>("Numer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numer"), 1L, 1);

                    b.Property<int>("Czas")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DodatkoweSzkolenia")
                        .HasColumnType("bit");

                    b.Property<string>("Godzina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KlientNumer")
                        .HasColumnType("int");

                    b.Property<int>("LiczbaOsob")
                        .HasColumnType("int");

                    b.Property<int?>("PracownikId")
                        .HasColumnType("int");

                    b.Property<int>("TorId")
                        .HasColumnType("int");

                    b.Property<bool>("Zaliczka")
                        .HasColumnType("bit");

                    b.HasKey("Numer");

                    b.HasIndex("KlientNumer");

                    b.HasIndex("PracownikId");

                    b.HasIndex("TorId");

                    b.ToTable("Rezerwacje");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Serwis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataUtworzenia")
                        .HasColumnType("datetime2");

                    b.Property<int>("GokartNumer")
                        .HasColumnType("int");

                    b.Property<int?>("InstruktorId")
                        .HasColumnType("int");

                    b.Property<int?>("IntruktorId")
                        .HasColumnType("int");

                    b.Property<int?>("MechanikId")
                        .HasColumnType("int");

                    b.Property<string>("Notatka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usterka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Wykonano")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GokartNumer");

                    b.HasIndex("IntruktorId");

                    b.HasIndex("MechanikId");

                    b.ToTable("Serwisy");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Tor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Pojemnosc")
                        .HasColumnType("int");

                    b.Property<string>("Rodzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.RejestrPrac", b =>
                {
                    b.HasOne("TorKartingowyCoreMVC.Models.Pracownik", "Pracownik")
                        .WithMany()
                        .HasForeignKey("PracownikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pracownik");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Rezerwacja", b =>
                {
                    b.HasOne("TorKartingowyCoreMVC.Models.Klient", "Klient")
                        .WithMany("Rezerwacje")
                        .HasForeignKey("KlientNumer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TorKartingowyCoreMVC.Models.Pracownik", "Pracownik")
                        .WithMany("Rezerwacje")
                        .HasForeignKey("PracownikId");

                    b.HasOne("TorKartingowyCoreMVC.Models.Tor", "Tor")
                        .WithMany("Rezerwacja")
                        .HasForeignKey("TorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klient");

                    b.Navigation("Pracownik");

                    b.Navigation("Tor");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Serwis", b =>
                {
                    b.HasOne("TorKartingowyCoreMVC.Models.Gokart", "Gokart")
                        .WithMany()
                        .HasForeignKey("GokartNumer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TorKartingowyCoreMVC.Models.Pracownik", "Intruktor")
                        .WithMany()
                        .HasForeignKey("IntruktorId");

                    b.HasOne("TorKartingowyCoreMVC.Models.Pracownik", "Mechanik")
                        .WithMany()
                        .HasForeignKey("MechanikId");

                    b.Navigation("Gokart");

                    b.Navigation("Intruktor");

                    b.Navigation("Mechanik");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Klient", b =>
                {
                    b.Navigation("Rezerwacje");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Pracownik", b =>
                {
                    b.Navigation("Rezerwacje");
                });

            modelBuilder.Entity("TorKartingowyCoreMVC.Models.Tor", b =>
                {
                    b.Navigation("Rezerwacja");
                });
#pragma warning restore 612, 618
        }
    }
}
