// AppDbContext: nucleo del Data Access Layer. Configura EF Core e mappa le entità.
// Per modificare la struttura del DB: modifica questo file e crea una nuova migration.
using ComeUbBalenoApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComeUbBalenoApp.DAL;

/// <summary>
/// Contesto principale del database. Contiene tutti i DbSet (tabelle).
/// Per aggiungere un'entità: 1) Crea la classe in Entities/ 2) Aggiungi DbSet qui 3) Crea migration.
/// </summary>
public class AppDbContext : DbContext
{
    /// <summary>Costruttore con DI delle opzioni. Segue il principio DIP.</summary>
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Material> Materials => Set<Material>();
    public DbSet<BillOfMaterials> BillOfMaterials => Set<BillOfMaterials>();
    /// <summary>Tabella utenti. TODO: sostituire con ASP.NET Core Identity in produzione.</summary>
    public DbSet<User> Users => Set<User>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    public DbSet<CustomizationRequest> CustomizationRequests => Set<CustomizationRequest>();
    public DbSet<Message> Messages => Set<Message>();
    public DbSet<ProductImage> ProductImages => Set<ProductImage>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>(e =>
        {
            e.HasKey(p => p.Id);
            e.Property(p => p.Name).IsRequired().HasMaxLength(200);
            e.Property(p => p.PricePlaceholder).HasColumnType("decimal(18,2)");
        });

        modelBuilder.Entity<Material>(e =>
        {
            e.HasKey(m => m.Id);
            e.Property(m => m.Name).IsRequired().HasMaxLength(200);
        });

        modelBuilder.Entity<BillOfMaterials>(e =>
        {
            e.HasKey(b => b.Id);
            e.HasOne(b => b.Product).WithMany(p => p.BillOfMaterials).HasForeignKey(b => b.ProductId).OnDelete(DeleteBehavior.Cascade);
            e.HasOne(b => b.Material).WithMany(m => m.BillOfMaterials).HasForeignKey(b => b.MaterialId).OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<User>(e =>
        {
            e.HasKey(u => u.Id);
            e.Property(u => u.Email).IsRequired().HasMaxLength(256);
            e.HasIndex(u => u.Email).IsUnique();
        });

        modelBuilder.Entity<Order>(e =>
        {
            e.HasKey(o => o.Id);
            e.HasOne(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.UserId).OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<OrderItem>(e =>
        {
            e.HasKey(oi => oi.Id);
            e.HasOne(oi => oi.Order).WithMany(o => o.Items).HasForeignKey(oi => oi.OrderId).OnDelete(DeleteBehavior.Cascade);
            e.HasOne(oi => oi.Product).WithMany().HasForeignKey(oi => oi.ProductId).OnDelete(DeleteBehavior.Restrict);
            e.Property(oi => oi.UnitPrice).HasColumnType("decimal(18,2)");
        });

        modelBuilder.Entity<CustomizationRequest>(e =>
        {
            e.HasKey(cr => cr.Id);
            e.HasOne(cr => cr.Product).WithMany(p => p.CustomizationRequests).HasForeignKey(cr => cr.ProductId).OnDelete(DeleteBehavior.Restrict);
            e.HasOne(cr => cr.User).WithMany(u => u.CustomizationRequests).HasForeignKey(cr => cr.UserId).OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Message>(e =>
        {
            e.HasKey(m => m.Id);
            e.HasOne(m => m.Sender).WithMany().HasForeignKey(m => m.SenderId).OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<ProductImage>(e =>
        {
            e.HasKey(pi => pi.Id);
            e.HasOne(pi => pi.Product).WithMany(p => p.Images).HasForeignKey(pi => pi.ProductId).OnDelete(DeleteBehavior.Cascade);
            e.HasOne(pi => pi.User).WithMany().HasForeignKey(pi => pi.UserId).OnDelete(DeleteBehavior.SetNull);
        });
    }
}
