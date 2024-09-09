﻿// <auto-generated />
using System;
using Humanity.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Humanity.Infrastructure.Migrations
{
    [DbContext(typeof(LisanssizContext))]
    [Migration("20240905110725_logs")]
    partial class logs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Humanity.Domain.Entities.Abone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Agog")
                        .HasColumnType("integer");

                    b.Property<double>("BaglantiGucu")
                        .HasColumnType("double precision");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DagitimFirmaId")
                        .HasColumnType("integer");

                    b.Property<string>("EtsoKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<double>("KuruluGuc")
                        .HasColumnType("double precision");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MusteriId")
                        .HasColumnType("integer");

                    b.Property<int>("SahisTip")
                        .HasColumnType("integer");

                    b.Property<long>("SeriNo")
                        .HasColumnType("bigint");

                    b.Property<double>("SozlesmeGucu")
                        .HasColumnType("double precision");

                    b.Property<int>("Tarife")
                        .HasColumnType("integer");

                    b.Property<int>("Terim")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId")
                        .IsUnique();

                    b.ToTable("Abone");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.AboneIletisim", b =>
                {
                    b.Property<int>("AboneId")
                        .HasColumnType("integer");

                    b.Property<int?>("IletisimId")
                        .HasColumnType("integer");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("AboneId", "IletisimId");

                    b.HasIndex("IletisimId");

                    b.ToTable("AboneIletisim");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.AboneSayac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AboneId")
                        .HasColumnType("integer");

                    b.Property<int>("FazAdedi")
                        .HasColumnType("integer");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("SayacNo")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AboneId");

                    b.ToTable("AboneSayac");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.AboneTuketici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AboneId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BaslamaZamani")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Durum")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("UreticiAboneId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AboneId");

                    b.HasIndex("UreticiAboneId");

                    b.ToTable("AboneTuketici");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.AboneUretici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AboneId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CagrimektupTarihi")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("LisansBilgisi")
                        .HasColumnType("integer");

                    b.Property<int>("MahsupTipi")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UretimBaslama")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UretimSekli")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AboneId");

                    b.ToTable("AboneUretici");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.CariIletisim", b =>
                {
                    b.Property<int>("CariKartId")
                        .HasColumnType("integer");

                    b.Property<int>("IletisimId")
                        .HasColumnType("integer");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("CariKartId", "IletisimId");

                    b.HasIndex("IletisimId");

                    b.ToTable("CariIletisim");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.CariKart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Durum")
                        .HasColumnType("integer");

                    b.Property<int>("GercekTuzel")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("OzelkodId1")
                        .HasColumnType("integer");

                    b.Property<int?>("OzelkodId2")
                        .HasColumnType("integer");

                    b.Property<int?>("OzelkodId3")
                        .HasColumnType("integer");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("Tckn")
                        .HasColumnType("bigint");

                    b.Property<string>("Unvan")
                        .HasColumnType("text");

                    b.Property<long?>("Vkn")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("CariKart");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Durum")
                        .HasColumnType("integer");

                    b.Property<int>("FirmaEntegrasyon")
                        .HasColumnType("integer");

                    b.Property<string>("FirmaUnvan")
                        .HasColumnType("text");

                    b.Property<int>("GercekTuzel")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("OzelkodId1")
                        .HasColumnType("integer");

                    b.Property<int?>("OzelkodId2")
                        .HasColumnType("integer");

                    b.Property<int?>("OzelkodId3")
                        .HasColumnType("integer");

                    b.Property<long?>("Tckn")
                        .HasColumnType("bigint");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("Vkn")
                        .HasColumnType("bigint");

                    b.Property<string>("firmaAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FirmaEntegrasyon");

                    b.ToTable("Firma");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.FirmaEntegrasyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FirmaId")
                        .HasColumnType("integer");

                    b.Property<string>("ServisAdres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ServisId")
                        .HasColumnType("integer");

                    b.Property<string>("ServisKullaniciAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ServisSifre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FirmaEntegrasyon");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.Iletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .HasColumnType("text");

                    b.Property<string>("CepTel")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int?>("Ilceid")
                        .HasColumnType("integer");

                    b.Property<int?>("Ilid")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Iletisim");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.Logs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Application")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Exception")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Logger")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CariKartId")
                        .HasColumnType("integer");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Durum")
                        .HasColumnType("integer");

                    b.Property<int>("GercekTuzel")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("OzelkodId1")
                        .HasColumnType("integer");

                    b.Property<int?>("OzelkodId2")
                        .HasColumnType("integer");

                    b.Property<int?>("OzelkodId3")
                        .HasColumnType("integer");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("Tckn")
                        .HasColumnType("bigint");

                    b.Property<string>("Unvan")
                        .HasColumnType("text");

                    b.Property<long?>("Vkn")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CariKartId");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.MusteriIletisim", b =>
                {
                    b.Property<int>("MusteriId")
                        .HasColumnType("integer");

                    b.Property<int>("IletisimId")
                        .HasColumnType("integer");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("MusteriId", "IletisimId");

                    b.HasIndex("IletisimId");

                    b.HasIndex("MusteriId")
                        .IsUnique();

                    b.ToTable("MusteriIletisim");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.MusteriOzelKod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("KodNo")
                        .HasColumnType("integer");

                    b.Property<int>("RootId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("MusteriOzelKod");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Humanity.Domain.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("LastActiveAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("PasswordConfigured")
                        .HasColumnType("boolean");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Humanity.Domain.Entities.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Humanity.Domain.Entities.Abone", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.Musteri", "Musteri")
                        .WithOne("Abone")
                        .HasForeignKey("Humanity.Domain.Entities.Abone", "MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.AboneIletisim", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.Abone", "Abone")
                        .WithMany()
                        .HasForeignKey("AboneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Humanity.Domain.Entities.Iletisim", "Iletisim")
                        .WithMany()
                        .HasForeignKey("IletisimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abone");

                    b.Navigation("Iletisim");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.AboneSayac", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.Abone", "Abone")
                        .WithMany()
                        .HasForeignKey("AboneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abone");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.AboneTuketici", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.Abone", "Abone")
                        .WithMany()
                        .HasForeignKey("AboneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Humanity.Domain.Entities.Abone", "UreticiAbone")
                        .WithMany()
                        .HasForeignKey("UreticiAboneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abone");

                    b.Navigation("UreticiAbone");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.AboneUretici", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.Abone", "Abone")
                        .WithMany()
                        .HasForeignKey("AboneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abone");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.CariIletisim", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.CariKart", "CariKart")
                        .WithMany()
                        .HasForeignKey("CariKartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Humanity.Domain.Entities.Iletisim", "Iletisim")
                        .WithMany()
                        .HasForeignKey("IletisimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CariKart");

                    b.Navigation("Iletisim");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.Firma", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.FirmaEntegrasyon", "Entegrasyon")
                        .WithMany()
                        .HasForeignKey("FirmaEntegrasyon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entegrasyon");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.Musteri", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.CariKart", "CariKart")
                        .WithMany()
                        .HasForeignKey("CariKartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CariKart");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.MusteriIletisim", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.Iletisim", "Iletisim")
                        .WithMany()
                        .HasForeignKey("IletisimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Humanity.Domain.Entities.Musteri", "Musteri")
                        .WithOne("MusteriIletisim")
                        .HasForeignKey("Humanity.Domain.Entities.MusteriIletisim", "MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Iletisim");

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("Humanity.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Humanity.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Humanity.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Humanity.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Humanity.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Humanity.Domain.Entities.Musteri", b =>
                {
                    b.Navigation("Abone")
                        .IsRequired();

                    b.Navigation("MusteriIletisim")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
