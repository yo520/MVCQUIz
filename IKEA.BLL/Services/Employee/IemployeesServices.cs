using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.BLL.Dto_s.employeeDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.employee
{
    public interface IemployeesServices
    {
        public IEnumerable<EmployeeDto> GetAllEmployees();
        public EmployeeDetailsDto GetEmployeeById(int id);
        public int Addemployee(CreatedEmployeeDto dto);

        public int UpdatedEmployee(updatedEmployeeDto dto);
        public int DeleteEmployee(int id);
    }
}
