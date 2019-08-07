﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyLibrary.Data;

namespace MyLibrary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

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

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyLibrary.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

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
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c39b7db4-20e1-4ca5-9af5-c5e0734373d8",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "admin",
                            LastName = "admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECSEQCGHyT/ib89qIuQ9ZKa2kfwKRHKcFtCkqI8Ol7PZ3uQUF52rDjPZ6BBDlbsIZQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("MyLibrary.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "Meron",
                            LastName = "Getnet"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Bewketu",
                            LastName = "Seyoum"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Daniel",
                            LastName = "Kibret"
                        },
                        new
                        {
                            AuthorId = 4,
                            FirstName = "Dn Birhanu",
                            LastName = "Gobena"
                        },
                        new
                        {
                            AuthorId = 5,
                            FirstName = "Adolf",
                            LastName = "Parlesak"
                        },
                        new
                        {
                            AuthorId = 6,
                            FirstName = "Anne",
                            LastName = "Frank"
                        },
                        new
                        {
                            AuthorId = 7,
                            FirstName = "Jeff ",
                            LastName = "Kinney"
                        });
                });

            modelBuilder.Entity("MyLibrary.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Language");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 5,
                            CategoryId = 4,
                            Language = "Amharic",
                            PublishDate = new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ye Habesha Jebdu",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            CategoryId = 5,
                            Language = "Amharic",
                            PublishDate = new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Yemaleda Dibab",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 6,
                            CategoryId = 4,
                            Language = "English",
                            PublishDate = new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Anne Frank",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 4,
                            CategoryId = 2,
                            Language = "Amharic",
                            PublishDate = new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Amde Hymanot",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 4,
                            CategoryId = 2,
                            Language = "Geaz",
                            PublishDate = new DateTime(1988, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sinksar",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 3,
                            CategoryId = 4,
                            Language = "Amharic",
                            PublishDate = new DateTime(1988, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Mezgebe Taric",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 2,
                            CategoryId = 2,
                            Language = "Geaz",
                            PublishDate = new DateTime(1988, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Dawit",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 8,
                            AuthorId = 3,
                            CategoryId = 3,
                            Language = "Amharic",
                            PublishDate = new DateTime(1988, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sine Fitret",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 9,
                            AuthorId = 7,
                            CategoryId = 3,
                            Language = "English",
                            PublishDate = new DateTime(1988, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Amimals",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 10,
                            AuthorId = 1,
                            CategoryId = 5,
                            Language = "Amharic",
                            PublishDate = new DateTime(1988, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Zuret",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BookId = 11,
                            AuthorId = 7,
                            CategoryId = 3,
                            Language = "English",
                            PublishDate = new DateTime(1980, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Wimpy Kid",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("MyLibrary.Models.Borrow", b =>
                {
                    b.Property<int>("BorrowId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<DateTime?>("DateBorrowed")
                        .IsRequired();

                    b.Property<DateTime?>("DateReturned");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("BorrowId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Borrow");

                    b.HasData(
                        new
                        {
                            BorrowId = 1,
                            BookId = 1,
                            DateBorrowed = new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            BorrowId = 2,
                            BookId = 2,
                            DateBorrowed = new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateReturned = new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("MyLibrary.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Education"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Spiritual"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Children's"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "History"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Poems"
                        });
                });

            modelBuilder.Entity("MyLibrary.Models.WishList", b =>
                {
                    b.Property<int>("WishListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("WishListId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("wishList");

                    b.HasData(
                        new
                        {
                            WishListId = 1,
                            BookId = 6,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            WishListId = 2,
                            BookId = 7,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
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
                    b.HasOne("MyLibrary.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyLibrary.Models.ApplicationUser")
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

                    b.HasOne("MyLibrary.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyLibrary.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyLibrary.Models.Book", b =>
                {
                    b.HasOne("MyLibrary.Models.Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyLibrary.Models.Category", "catagory")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyLibrary.Models.ApplicationUser", "User")
                        .WithMany("Books")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyLibrary.Models.Borrow", b =>
                {
                    b.HasOne("MyLibrary.Models.Book", "books")
                        .WithMany("Borrows")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MyLibrary.Models.ApplicationUser", "User")
                        .WithMany("Borrows")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyLibrary.Models.WishList", b =>
                {
                    b.HasOne("MyLibrary.Models.Book", "book")
                        .WithMany("WishLists")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyLibrary.Models.ApplicationUser", "User")
                        .WithMany("WishLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
