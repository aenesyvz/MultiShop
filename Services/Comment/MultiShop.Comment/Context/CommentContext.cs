using Microsoft.EntityFrameworkCore;
using MultiShop.Comment.Entities;
using System.Collections.Generic;

namespace MultiShop.Comment.Context;

public class CommentContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1442;initial Catalog=MultiShopCommentDb;User=sa;Password=123456.aA*;TrustServerCertificate=True");
    }
    public DbSet<UserComment> UserComments { get; set; }
}