using AutoMapper;
using IKEA.BLL.Dto_s.employeeDto_s;
using IKEA.BLL.Services.employee;
using IKEA.DAL.Models.Employees;
using IKEA.DAL.Repositories.employeeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.Employee
{
    public class EmployeeServices : IemployeesServices
    {
        private readonly IEmployeeRepo employeeRepo;

        public IMapper Mapper { get; }

        public EmployeeServices(IEmployeeRepo employeeRepo,IMapper mapper)
        {
            this.employeeRepo = employeeRepo;
            Mapper = mapper;
        }

        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var employees = employeeRepo.GetAll();
            var mappedemployee = Mapper.Map<IEnumerable<EMployee>,IEnumerable<EmployeeDto>>(employees);
            return mappedemployee;
        }

        public EmployeeDetailsDto GetEmployeeById(int id)
        {
            var employee = employeeRepo.GetById(id);
            var mappedemployee=Mapper.Map<EMployee,EmployeeDetailsDto>(employee);
            return mappedemployee;
        }
        public int Addemployee(CreatedEmployeeDto dto)
        {
            var emp=Mapper.Map<CreatedEmployeeDto,EMployee>(dto);
            emp.CreatedBy = 1;
            emp.CreatedOn = DateTime.Now;
            emp.LastModifiedBy = 1;
            emp.LastModifiedOn = DateTime.Now;
            return employeeRepo.Add(emp);
        }

        public int UpdatedEmployee(updatedEmployeeDto dto)
        {
            var emp = Mapper.Map<updatedEmployeeDto, EMployee>(dto);
            emp.LastModifiedBy = 1;
            emp.LastModifiedOn = DateTime.Now;
            return employeeRepo.Update(emp);
        }
        public int DeleteEmployee(int id)
        {
            if (employeeRepo.GetById(id) != null)
            {
                return employeeRepo.Delete(id);
            }
            else
            {
                return 0;
            }

        }
    }
}
