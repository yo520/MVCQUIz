using IKEA.DAL.Models.catugory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Models.product
{
    public class Product: BaseEntity
    {
  
        public int price { get; set; }
         public int quantity { get; set; }

        public int categoryId { get; set; }
        public virtual Category? catugory { get; set; }
    }
}
