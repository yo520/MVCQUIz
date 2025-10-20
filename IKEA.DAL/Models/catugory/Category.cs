using IKEA.DAL.Models.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.DAL.Models.catugory
{
    public class Category: BaseEntity
    {
  
        public ICollection<Product> products { get; set; }=new List<Product>();
    }
}

