﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieRentalSystem_Arya.Contexts;

#nullable disable

namespace MovieRentalSystem_Arya.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Account", b =>
                {
                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("staff_id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.HasKey("StaffId");

                    b.ToTable("tb_ary_m_accounts");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.AccountRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("account_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("tb_ary_tr_accountroles");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.HasKey("Id");

                    b.ToTable("tb_ary_m_actors");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address1");

                    b.Property<string>("Address2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address2");

                    b.Property<int>("CityId")
                        .HasColumnType("int")
                        .HasColumnName("city_id");

                    b.Property<int>("District")
                        .HasColumnType("int")
                        .HasColumnName("district");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("postal_code");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("tb_ary_m_addresses");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_ary_m_categories");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("tb_ary_m_cities");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_ary_m_countries");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Active")
                        .IsRequired()
                        .HasColumnType("nchar(1)")
                        .HasColumnName("active");

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("addres_id");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("create_update");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("tb_ary_m_customers");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("FullText")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("full_text");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int")
                        .HasColumnName("language_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<int>("Length")
                        .HasColumnType("int")
                        .HasColumnName("length");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int")
                        .HasColumnName("release_year");

                    b.Property<int>("RentalDuration")
                        .HasColumnType("int")
                        .HasColumnName("rental_duration");

                    b.Property<decimal>("RentalRate")
                        .HasColumnType("numeric(19,0)")
                        .HasColumnName("rental_rate");

                    b.Property<decimal>("ReplacementCost")
                        .HasColumnType("numeric(19,0)")
                        .HasColumnName("replacement_cost");

                    b.Property<string>("SpecialFeatures")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("special_features");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("tittle");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("tb_ary_m_films");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.FilmActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActorId")
                        .HasColumnType("int")
                        .HasColumnName("actor_id");

                    b.Property<int>("FilmId")
                        .HasColumnType("int")
                        .HasColumnName("film_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("FilmId");

                    b.ToTable("tb_ary_tr_filmactors");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.FilmCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("FilmId")
                        .HasColumnType("int")
                        .HasColumnName("film_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FilmId");

                    b.ToTable("tb_ary_tr_filmcategories");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FilmId")
                        .HasColumnType("int")
                        .HasColumnName("film_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.ToTable("tb_ary_m_inventories");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_ary_m_languages");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric(19,0)")
                        .HasColumnName("amount");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("payment_date");

                    b.Property<int>("RentalId")
                        .HasColumnType("int")
                        .HasColumnName("rental_id");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("staff_id");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RentalId");

                    b.HasIndex("StaffId");

                    b.ToTable("tb_ary_tr_payments");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int")
                        .HasColumnName("inventory_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("rental_date");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("return_date");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("staff_id");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("StaffId");

                    b.ToTable("tb_ary_tr_rentals");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_ary_m_roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Staff"
                        });
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Active")
                        .IsRequired()
                        .HasColumnType("nchar(1)")
                        .HasColumnName("active");

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("payment_id");

                    b.Property<string>("PictureUrl")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("picture_url");

                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("store_id");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("StoreId");

                    b.ToTable("tb_ary_m_staffs");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_update");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("tb_ary_m_stores");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Account", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Staff", "Staff")
                        .WithOne("Account")
                        .HasForeignKey("MovieRentalSystem_Arya.Models.Account", "StaffId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.AccountRole", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Account", "Account")
                        .WithMany("AccountRoles")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRentalSystem_Arya.Models.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Address", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.City", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Customer", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Address", "Address")
                        .WithMany("Customers")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Film", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Language", "Language")
                        .WithMany("Films")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.FilmActor", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Actor", "Actor")
                        .WithMany("FilmActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRentalSystem_Arya.Models.Film", "Film")
                        .WithMany("FilmActors")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.FilmCategory", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Category", "Category")
                        .WithMany("FilmCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRentalSystem_Arya.Models.Film", "Film")
                        .WithMany("FilmCategories")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Inventory", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Film", "Film")
                        .WithMany("Inventories")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Payment", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRentalSystem_Arya.Models.Rental", "Rental")
                        .WithMany("Payments")
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MovieRentalSystem_Arya.Models.Staff", "Staff")
                        .WithMany("Payments")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Rental");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Rental", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Customer", "Customer")
                        .WithMany("Rentals")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRentalSystem_Arya.Models.Inventory", "Inventory")
                        .WithMany("Rentals")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRentalSystem_Arya.Models.Staff", "Staff")
                        .WithMany("Rentals")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Inventory");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Staff", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Address", "Address")
                        .WithMany("Staffs")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRentalSystem_Arya.Models.Store", "Store")
                        .WithMany("Staffs")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Store", b =>
                {
                    b.HasOne("MovieRentalSystem_Arya.Models.Address", "Address")
                        .WithMany("Stores")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Account", b =>
                {
                    b.Navigation("AccountRoles");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Actor", b =>
                {
                    b.Navigation("FilmActors");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Address", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Staffs");

                    b.Navigation("Stores");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Category", b =>
                {
                    b.Navigation("FilmCategories");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Customer", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Film", b =>
                {
                    b.Navigation("FilmActors");

                    b.Navigation("FilmCategories");

                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Inventory", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Language", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Rental", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Role", b =>
                {
                    b.Navigation("AccountRoles");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Staff", b =>
                {
                    b.Navigation("Account");

                    b.Navigation("Payments");

                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("MovieRentalSystem_Arya.Models.Store", b =>
                {
                    b.Navigation("Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}
