using Microsoft.EntityFrameworkCore;
using MovieRentalSystem_Arya.Models;

namespace MovieRentalSystem_Arya.Contexts;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountRole> AccountRoles { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<FilmActor> FilmActors { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<FilmCategory> FilmCategories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Payment> Payments { get; set; }

    // Fluent API
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<Role>().HasData(
        //    new Role
        //    {
        //        Id = 1,
        //        Name = "Admin"
        //    },
        //    new Role
        //    {
        //        Id = 2,
        //        Name = "User"
        //    });

        //// Membuat atribute menjadi unique
        //modelBuilder.Entity<Employee>().HasIndex(e => new
        //{
        //    e.Email,
        //    e.PhoneNumber
        //}).IsUnique();

        //// Relasi one Employee ke one Account 
        //modelBuilder.Entity<Employee>()
        //    .HasOne(e => e.Account)
        //    .WithOne(a => a.Employee)
        //    .HasForeignKey<Account>(fk => fk.EmployeeNIK);

        //// Relasi ke many employee ke one manager
        //modelBuilder.Entity<Employee>()
        //    .HasOne(e => e.Manager)
        //    .WithMany(e => e.Employees)
        //    .HasForeignKey(fk => fk.ManagerId)
        //    .OnDelete(DeleteBehavior.NoAction);
    }
}
