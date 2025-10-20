using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.DAL.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Factories.DepartmentFactory
{
    public static class DeptFact
    {
        public static DepartmentDto ToDepartmentDto(this DEpartment department)
        {
            return new DepartmentDto()
            {
                Id = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
            };
        }

        public static DepartmentDetailsDto ToEntity(this DEpartment Department)
        {
            return new DepartmentDetailsDto(Department)
            {
            };
        }
        public static DEpartment ToDepartment(this CreateDepartmentDto dto)
        {
            return new DEpartment()
            {
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                CreatedBy = 1,
                CreatedOn = DateTime.Now,
                LastModifiedOn = DateTime.Now,
                LastModifiedBy = 1,
                IsDeleted=false
            };
        }
        public static DEpartment FromUpdatedDept(this UpdatedDepartmentDto dto)
        {
            return new DEpartment()
            {
                Id = dto.Id,
                Name = dto.Name,
                Code = dto.Code,
                Description = dto.Description,
                LastModifiedBy = 1,
                LastModifiedOn = DateTime.Now,
                IsDeleted = false,
               



            };
        }
    }
}
