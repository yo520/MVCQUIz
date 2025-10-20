using IKEA.DAL.Contexts;
using IKEA.DAL.Models.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Repositories
{
    public class ProductRepostory:genaricRepository<Product>, IProductRepo
    {
        private readonly ApplicationDbContext context;

        public ProductRepostory(ApplicationDbContext context):base (context)
        {
            this.context = context;
        }

    }
}
