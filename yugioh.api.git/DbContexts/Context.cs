using CardsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardsAPI.DbContexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
        //    public DbSet<User> Users { get; set; }

        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        //        {
        //            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        //        }

        //        ConfigureModelBuilderForUser(modelBuilder);
        //    }

        //    void ConfigureModelBuilderForUser(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<User>().ToTable("User");
        //        modelBuilder.Entity<User>()
        //            .Property(user => user.Username)
        //            .HasMaxLength(60)
        //            .IsRequired();

        //        modelBuilder.Entity<User>()
        //            .Property(user => user.Email)
        //            .HasMaxLength(60)
        //            .IsRequired();
        //    }

        //}
    }
}
