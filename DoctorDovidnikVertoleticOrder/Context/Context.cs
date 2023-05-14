using Microsoft.EntityFrameworkCore;
using TasksOrderVert1000.Model;
namespace TasksOrderVert1000.Context;

public class Context : DbContext
{
    public DbSet<Tip> Tips { get; set; }

    public Context()
    {
        Database.EnsureCreated();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite($"Data Source=TipsDB.db");//.LogTo(Console.WriteLine);
        SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tip>()
            .HasKey(t => t.TipId) // configure TipId as primary key
            .HasName("PK_TipId");

        modelBuilder.Entity<Tip>()
            .Property(t => t.TipId)
            .HasColumnName("Id"); // configure TipId to be named Id

        modelBuilder.Entity<Tip>()
            .Property(t => t.TipName)
            .HasMaxLength(30); // configure max length of TipName to be 30
        
        modelBuilder.Entity<Tip>()
            .Property(t => t.Description)
            .HasMaxLength(300); // configure max length of Description to be 300

        modelBuilder.Entity<Tip>()
            .Property(t => t.Major)
            .IsRequired();


        base.OnModelCreating(modelBuilder);
    }
}