using Microsoft.EntityFrameworkCore;
using HelloWorldWebApp.Models;

namespace HelloWorldWebApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Message> Messages => Set<Message>();
}