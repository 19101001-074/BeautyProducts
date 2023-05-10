using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeautyProducts;

namespace BeautyProducts.Data
{
    public class BeautyProductsContext : DbContext
    {
        public BeautyProductsContext (DbContextOptions<BeautyProductsContext> options)
            : base(options)
        {
        }

        public DbSet<BeautyProducts.Contact> Contact { get; set; } = default!;
    }
}
