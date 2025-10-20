using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Dto_s.DepartmentDto_s
{
    public class CreateDepartmentDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        
    }
}
