using IKEA.DAL.Models.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Configurations
{
    public class ProductConfigrations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.price).IsRequired();
            builder.Property(p => p.quantity).IsRequired();
            builder.HasOne(p => p.catugory)
                   .WithMany(c => c.products)
                   .HasForeignKey(p => p.categoryId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
