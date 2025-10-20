using IKEA.BLL.Dto_s.DepartmentDto_s;
using IKEA.BLL.Factories.DepartmentFactory;
using IKEA.DAL.Models.Department;
using IKEA.DAL.Repositories.DeptRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Services.Department
{
    public class DepartmentService:IDepartmentServices
    {
        private readonly IDepartmentRepository _repository;
        public DepartmentService(IDepartmentRepository repository) 
        {
         _repository = repository;
        }

        //1st Way of Mapping : Manual Mapping
        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var Departments = _repository.GetAll();
            //var MappedDepartments = Departments.Select(D => new DepartmentDto() 
            //{
            //    Id = D.Id,
            //    Description = D.Description,
            //    Name = D.Name,
            //    Code = D.Code
             
            //});

            //ExtensionMethod 

            List<DepartmentDto> MappedDepartments = new List<DepartmentDto>();
            foreach (var Dept in Departments)
            {
                var MappedDepts = Dept.ToDepartmentDto();
                MappedDepartments.AddRange(MappedDepts);
            }

            return MappedDepartments;
        }


        //2nd Way of Mapping : Constructor Mapping
        //by Using Copy Constructor,,Pass the Department Model to DepartmentDetailsDto class Constructor and Here
        public DepartmentDetailsDto GetDepartmentById(int id)
        {
            var Department= _repository.GetById(id);
            if (Department == null) return null;
            else
            {
                //Constructor Mapping

                //var ReturnedDepartment = new DepartmentDetailsDto(Department);

                //Extension Method
                var ReturnedDepartment= Department.ToEntity();
                return ReturnedDepartment;   
            } 
        }
        public int AddDepartment(CreateDepartmentDto dto)
        {
            var Dept = dto.ToDepartment();
            return _repository.Add(Dept);
        }
        public int UpdatedDepartment(UpdatedDepartmentDto dto)
        {
            var Dept = dto.FromUpdatedDept();
            return _repository.Update(Dept);
        }

        public int DeleteDepartment(int id)
        {
            return _repository.Delete(id);
        }

    }

}
