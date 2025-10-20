using IKEA.BLL.Dto_s.DepartmentDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.Department
{
    public interface IDepartmentServices
    {
        public IEnumerable<DepartmentDto> GetAllDepartments();
        public DepartmentDetailsDto GetDepartmentById(int id);
        public int AddDepartment(CreateDepartmentDto dto);

        public int UpdatedDepartment(UpdatedDepartmentDto dto);
        public int DeleteDepartment(int id);

    }
}
