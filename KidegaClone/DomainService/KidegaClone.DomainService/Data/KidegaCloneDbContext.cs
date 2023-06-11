using Microsoft.EntityFrameworkCore;
using KidegaClone.Domain.Entities;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace KidegaClone.DomainService.Data
{
    public class KidegaCloneDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books {get; set;}  
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BookOrder> BookOrders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }        
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Review> Reviews { get; set; }        
        public DbSet<User> Users { get; set; }

        public KidegaCloneDbContext(DbContextOptions<KidegaCloneDbContext> options): base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = KidegaCloneDatabase; Integrated Security = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Address

            modelBuilder.Entity<Address>().HasKey(m => m.Id);

            modelBuilder.Entity<Address>().HasOne(m => m.User)
                                          .WithMany(m => m.Addresses)
                                          .HasForeignKey(m => m.UserID);
            modelBuilder.Entity<Address>().HasMany(m => m.Orders)
                                          .WithOne(m => m.Address)
                                          .HasForeignKey(m => m.AddressID);

            modelBuilder.Entity<Address>().Property(m => m.Name)
                                          .HasMaxLength(30);
            modelBuilder.Entity<Address>().Property(m => m.City)
                                          .HasMaxLength(50);
            modelBuilder.Entity<Address>().Property(m => m.District)
                                          .HasMaxLength(50);
            modelBuilder.Entity<Address>().Property(m => m.Neighbourhood)
                                          .HasMaxLength(100);
            modelBuilder.Entity<Address>().Property(m => m.Street)
                                          .HasMaxLength(100);


            //Authors

            modelBuilder.Entity<Author>().HasKey(m => m.Id);

            modelBuilder.Entity<Author>().HasMany(m => m.Books)
                                         .WithOne(m => m.Author)
                                         .HasForeignKey(m=>m.AuthorID)
                                         .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Author>().Property(m => m.Name)
                                          .HasMaxLength(50);
            modelBuilder.Entity<Author>().Property(m => m.Surname)
                                          .HasMaxLength(50);
            modelBuilder.Entity<Author>().Property(m => m.Biography)
                                          .HasMaxLength(1000);

            //BookOrder
            modelBuilder.Entity<BookOrder>().HasKey("BookID", "OrderID");

            //BookCategories
            modelBuilder.Entity<BookCategory>().HasKey("BookID","CategoryID");

            //Books

            modelBuilder.Entity<Book>().HasKey(m=>m.Id);

            modelBuilder.Entity<Book>().HasOne(m => m.Publisher)
                                       .WithMany(m=> m.Books)
                                       .HasForeignKey(m=>m.PublisherID)
                                       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Book>().HasOne(m => m.Author)
                                       .WithMany(m => m.Books)
                                       .HasForeignKey(m => m.AuthorID)
                                       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Book>().HasMany(m => m.Reviews)
                                       .WithOne(m=>m.Book)
                                       .HasForeignKey(m=>m.BookID)
                                       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Book>().HasMany(m => m.Categories)
                                       .WithOne(m => m.Book)
                                       .HasForeignKey(m => m.BookID)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Book>().HasMany(m => m.Orders)
                                       .WithOne(m => m.Book)
                                       .HasForeignKey(m => m.BookID)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Book>().Property(m => m.Name)
                                       .HasMaxLength(100);
            modelBuilder.Entity<Book>().Property(m => m.Price)
                                       .HasColumnType("decimal(7,2)");
            modelBuilder.Entity<Book>().Property(m => m.Description)
                                       .HasMaxLength(1000);
            modelBuilder.Entity<Book>().Property(m => m.ShortExcerpt)
                                       .HasMaxLength(100);
            modelBuilder.Entity<Book>().Property(m=> m.IsHardcover)
                                       .HasDefaultValue(false);
            modelBuilder.Entity<Book>().Property(m => m.PublishDate)
                                       .HasColumnType("datetime2");
            modelBuilder.Entity<Book>().Property(m=>m.Rating)
                                       .HasColumnType("decimal(2,1)");


            //Categories

            modelBuilder.Entity<Category>().HasKey(m=> m.Id);

            modelBuilder.Entity<Category>().HasMany(m => m.Books)
                                           .WithOne(m => m.Category)
                                           .HasForeignKey(m=>m.CategoryID)
                                           .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().Property(m => m.Name)
                                           .HasMaxLength(50);
            //Orders
            modelBuilder.Entity<Order>().HasKey(m=> m.Id);

            modelBuilder.Entity<Order>().HasMany(m => m.Books)
                                        .WithOne(m => m.Order)
                                        .HasForeignKey(m => m.OrderID)
                                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>().HasOne(m => m.User)
                                        .WithMany(m=>m.Orders)
                                        .HasForeignKey(m=>m.UserID)
                                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>().HasOne(m => m.Address)
                                        .WithMany(m => m.Orders)
                                        .HasForeignKey(m => m.AddressID)
                                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>().Property(m => m.IsSuccesfullyPaid)
                                        .HasDefaultValue(false);



            //Publishers

            modelBuilder.Entity<Publisher>().HasKey(m=>m.Id);
            modelBuilder.Entity<Publisher>().HasMany(m => m.Books)
                                            .WithOne(m => m.Publisher)
                                            .HasForeignKey(m => m.PublisherID)
                                            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Publisher>().Property(m=> m.Name) 
                                            .HasMaxLength(100);

            //Reviews

            modelBuilder.Entity<Review>().HasKey(m=>m.Id);

            modelBuilder.Entity<Review>().HasOne(m => m.User)
                                         .WithMany(m=> m.Reviews)
                                         .HasForeignKey(m=>m.UserID)
                                         .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Review>().HasOne(m => m.Book)
                                         .WithMany(m => m.Reviews)
                                         .HasForeignKey(m => m.BookID)
                                         .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Review>().Property(m => m.Title)
                                         .HasMaxLength(100);
            modelBuilder.Entity<Review>().Property(m => m.Title)
                                         .HasMaxLength(1000);

            //Users
            modelBuilder.Entity<User>().HasKey(m=>m.Id);

            modelBuilder.Entity<User>().HasMany(m=>m.Addresses)
                                       .WithOne(m=>m.User)
                                       .HasForeignKey(m=>m.UserID) 
                                       .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany(m => m.Reviews)
                                       .WithOne(m => m.User)
                                       .HasForeignKey(m => m.UserID)
                                       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>().HasMany(m => m.Orders)
                                       .WithOne(m => m.User)
                                       .HasForeignKey(m => m.UserID)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>().Property(m => m.Name)
                                       .HasMaxLength(50);
            modelBuilder.Entity<User>().Property(m => m.Surname)
                                       .HasMaxLength(50);
            modelBuilder.Entity<User>().Property(m => m.Email)
                                       .HasMaxLength(100);
            modelBuilder.Entity<User>().Property(m => m.PhoneNumber)
                                       .HasMaxLength(20);
        }
    }
}
