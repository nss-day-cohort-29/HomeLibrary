﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;
using MyLibrary.Models.BookViewModel;

namespace MyLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            public DbSet<ApplicationUser> ApplicationUser { get; set; }
            public DbSet<Author> Author { get; set; }
            public DbSet<Category> Category { get; set; }
            public DbSet<Book> Book { get; set; }
            public DbSet<Borrow> Borrow { get; set; }
            public DbSet<WishList> wishList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Restrict deletion of related user when borrows entry is removed
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(B => B.Borrows)
                .WithOne(l => l.User)
                .OnDelete(DeleteBehavior.Restrict);

            // Restrict deletion of related book when borrows entry is removed
            modelBuilder.Entity<Book>()
                .HasMany(W => W.Borrows)
                .WithOne(l => l.books)
                .HasForeignKey(bc => bc.BookId) 
                .OnDelete(DeleteBehavior.Restrict);

            // Restrict deletion of related user when wishLists entry is removed
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(B => B.WishLists)
                .WithOne(l => l.User)
                .OnDelete(DeleteBehavior.Restrict);

            /*// Restrict deletion of related book when wishLists entry is removed
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Books)
                .WithOne(l => 1.)
                .OnDelete(DeleteBehavior.Restrict);
*/

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    AuthorId = 1,
                    FirstName = "Meron",
                    LastName = "Getnet"
                },
                new Author()
                {
                    AuthorId = 2,
                    FirstName = "Bewketu",
                    LastName = "Seyoum"
                },
                new Author()
                {
                    AuthorId = 3,
                    FirstName = "Daniel",
                    LastName = "Kibret"
                },
                new Author()
                {
                    AuthorId = 4,
                    FirstName = "Dn Birhanu",
                    LastName = "Gobena"
                },
                new Author()
                {
                    AuthorId = 5,
                    FirstName = "Adolf",
                    LastName = "Parlesak"
                },
                new Author()
                {
                    AuthorId = 6,
                    FirstName = "Anne",
                    LastName = "Frank"
                },
                new Author()
                {
                    AuthorId = 7,
                    FirstName = "Jeff ",
                    LastName = "Kinney"
                }
             );

            modelBuilder.Entity<Category>().HasData(
                 new Category()
                 {
                     CategoryId = 1,
                     CategoryName = "Education"
                 },
                 new Category()
                 {
                     CategoryId = 2,
                     CategoryName = "Spiritual"
                 },
                 new Category()
                 {
                     CategoryId = 3,
                     CategoryName = "Children's"
                 },
                 new Category()
                 {
                     CategoryId = 4,
                     CategoryName = "History"
                 },
                 new Category()
                 {
                     CategoryId = 5,
                     CategoryName = "Poems"
                 }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    BookId = 1,
                    Title = "Ye Habesha Jebdu",
                    Language = "Amharic",
                    AuthorId = 5,
                    CategoryId= 4,
                    PublishDate = new DateTime(1980, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 2,
                    Title = "Yemaleda Dibab",
                    Language = "Amharic",
                    AuthorId = 2,
                    CategoryId = 5,
                    PublishDate = new DateTime(1980, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 3,
                    Title = "Anne Frank",
                    Language = "English",
                    AuthorId = 6,
                    CategoryId = 4,
                    PublishDate = new DateTime(1980, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 4,
                    Title = "Amde Hymanot",
                    Language = "Amharic",
                    AuthorId = 4,
                    CategoryId = 2,
                    PublishDate = new DateTime(1980, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 5,
                    Title = "Sinksar",
                    Language = "Geaz",
                    AuthorId = 4,
                    CategoryId = 2,
                    PublishDate = new DateTime(1988, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 6,
                    Title = "Mezgebe Taric",
                    Language = "Amharic",
                    AuthorId = 3,
                    CategoryId = 4,
                    PublishDate = new DateTime(1988, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 7,
                    Title = "Dawit",
                    Language = "Geaz",
                    AuthorId = 2,
                    CategoryId = 2,
                    PublishDate = new DateTime(1988, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 8,
                    Title = "Sine Fitret",
                    Language = "Amharic",
                    AuthorId = 3,
                    CategoryId = 3,
                    PublishDate = new DateTime(1988, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 9,
                    Title = "Amimals",
                    Language = "English",
                    AuthorId = 7,
                    CategoryId = 3,
                    PublishDate = new DateTime(1988, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 10,
                    Title = "Zuret",
                    Language = "Amharic",
                    AuthorId = 1,
                    CategoryId = 5,
                    PublishDate = new DateTime(1988, 4, 1),
                    UserId = user.Id
                },
                new Book()
                {
                    BookId = 11,
                    Title = "Wimpy Kid",
                    Language = "English",
                    AuthorId = 7,
                    CategoryId = 3,
                    PublishDate = new DateTime(1980, 4, 1),
                    UserId = user.Id
                }
                );
            modelBuilder.Entity<Borrow>().HasData(
                new Borrow()
                {
                    BorrowId = 1,
                    DateBorrowed = new DateTime(2019, 8, 8),
                    DateReturned = null,
                    BookId = 1,
                    UserId = user.Id
                },
                new Borrow()
                {
                    BorrowId = 2,
                    DateBorrowed = new DateTime(2019, 8, 8),
                    DateReturned = new DateTime(2019, 8, 8),
                    BookId = 2,
                    UserId = user.Id
                }

                );
            modelBuilder.Entity<WishList>().HasData(
                new WishList()
                {
                    WishListId = 1,
                    BookId = 6,
                    UserId = user.Id
                },
                new WishList()
                {
                    WishListId = 2,
                    BookId = 7,
                    UserId = user.Id
                }

                );

        }
        
    }
}
