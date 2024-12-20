// Models/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using System;
// Add the correct namespace where the User class is defined
using YourActualNamespace.Models; // {{ edit_1 }}

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }

    public DbSet<User> Users { get; set; }  // Örnek bir DbSet
}