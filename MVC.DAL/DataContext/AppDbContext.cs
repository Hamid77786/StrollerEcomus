using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StrollerEcomus.DAL.DataContext.Entities;


namespace StrollerEcomus.DAL.DataContext;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<BrandLogo> BrandLogo { get; set; } = null!;
    public DbSet<Color> Colors { get; set; } = null!;
    public DbSet<ProductColor> ProductColors { get; set; } = null!;
    public DbSet<Currency> Currencies { get; set; } = null!;
    public DbSet<FrequentlyQuestion> FrequentlyQuestions { get; set; } = null!;
    public DbSet<Icon> Icons { get; set; }= null!;
    public DbSet<IconCategory> IconCategories { get; set; } = null!;
    public DbSet<Language> Languages { get; set; }=null!;
    public DbSet<LogInContent> LogInContents { get; set; } = null!;
    public DbSet<WebLogo> WebLogos { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderItem> OrdersItem { get; set;} = null!;
    public DbSet<PaymentImage> PaymentImages { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> ProductCategories { get; set; }=null!;
    public DbSet<ProductImage> ProductImages { get; set; } = null!;
    public DbSet<PromoCode> PromoCodes { get; set; } = null!;
    public DbSet<PromoUsage> PromoUsages { get; set; } = null!;
    public DbSet<RecommendationBanner> RecommendationsBanners { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; }= null!;
    public DbSet<SiteBanner> SiteBanners { get; set; } = null!;
    public DbSet<Slider> Sliders { get; set; } = null!;
    public DbSet<Social> Socials { get; set; } = null!;
    public DbSet<WebInfo> WebInfos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Product>()
           .Property(p => p.Price)
           .HasPrecision(18, 2);

        builder.Entity<OrderItem>()
           .Property(p => p.UnitPrice)
           .HasPrecision(18, 2);

        builder.Entity<OrderItem>()
           .Property(p => p.TotalPrice)
           .HasPrecision(18, 2);

        builder.Entity<Order>()
           .Property(p => p.DisCount)
           .HasPrecision(18, 2);

        builder.Entity<Order>()
           .Property(p => p.Total)
           .HasPrecision(18, 2);

        builder.Entity<Order>()
           .Property(p => p.SubTotal)
           .HasPrecision(18, 2);

       

        base.OnModelCreating(builder);
    }
    
    

    public override int SaveChanges()
    {
        UpdateTimestamps();
        return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateTimestamps();
        return await base.SaveChangesAsync(cancellationToken);
    }

    private void UpdateTimestamps()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.Entity is TimeStample &&
                       (e.State == EntityState.Added || e.State == EntityState.Modified));

        foreach (var entry in entries)
        {
            var timestamp = (TimeStample)entry.Entity;

            if (entry.State == EntityState.Added)
            {
                timestamp.CreatedAt = DateTime.UtcNow;
            }

            timestamp.UpdatedAt = DateTime.UtcNow;
        }
    }

}
