using BeautyProducts;
using Microsoft.EntityFrameworkCore;



public class BeautyProductsContext : DbContext
{
    public BeautyProductsContext(DbContextOptions<BeautyProductsContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MenuItem>().HasData(GetSeedDataMenuItems());
        modelBuilder.Entity<Contact>().HasData(GetSeedDataContacts());
    }

    public DbSet<BeautyProducts.Contact> Contact { get; set; } = default!;

    public DbSet<BeautyProducts.MenuItem> MenuItem { get; set; } = default!;



    public DbSet<BeautyProducts.TogoOrder> TogoOrder { get; set; } = default!;
    private MenuItem[] GetSeedDataMenuItems() => new MenuItem[] {
        new MenuItem {
            Id = 1,
            Name = "Facewash",
            Price = (decimal)3.68,
            
          
        },
        new MenuItem {
            Id = 2,
            Name = "Lipstick",
            Price = (decimal)5.70,
           
           
        },
        new MenuItem {
            Id = 3,
            Name = "Facial",
            Price = (decimal)4.09,
            
            
        },
        new MenuItem {
            Id = 4,
            Name = "Eye-Liner",
            Price = (decimal)5.09,
            
            
        },
        
    };
    private Contact[] GetSeedDataContacts() => new Contact[] {
        new Contact {
            Id = 1,
            Name = "Adil",
            Email = "adil@example.com",
            Phone = "555-111-2222"
        },
        new Contact {
            Id=2,
            Name = "Muneeb",
            Email = "Muneeb@example.com",
            Phone = "555-111-3333"
        },
        new Contact {
            Id=3,
            Name = "Zaman",
            Email = "Zaman@example.com",
            Phone = "555-111-4444"
        },
        
    };
      
}