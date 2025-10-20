using IKEA.DAL.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Dto_s.DepartmentDto_s
{
    public class DepartmentDetailsDto
    {
        public DepartmentDetailsDto(DEpartment Department) 
        {
            Id = Department.Id;
            Name = Department.Name;
            Code = Department.Code;
            CreatedBy = Department.CreatedBy;
            CreatedOn = DateOnly.FromDateTime(Department.CreatedOn);
            Description = Department.Description;
            LastModifiedBy = Department.LastModifiedBy;
            LastModifiedOn = DateOnly.FromDateTime(Department.LastModifiedOn);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }

        public int CreatedBy { get; set; } //User Id

        public DateOnly CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public DateOnly LastModifiedOn { get; set; }
    }
}
