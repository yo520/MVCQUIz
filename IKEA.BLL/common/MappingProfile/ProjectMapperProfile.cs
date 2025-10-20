using AutoMapper;
using IKEA.BLL.Dto_s.employeeDto_s;
using IKEA.DAL.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.common.MappingProfile
{
    public class ProjectMapperProfile : Profile
    {
        public ProjectMapperProfile()
        {
            CreateMap<EMployee, EmployeeDto>()
                .ForMember(d=>d.departmentName,options=>options.MapFrom(src=>src.department!=null ?src.department.Name :"N/A" )).ReverseMap();
            CreateMap<EMployee, EmployeeDetailsDto>().ForMember(d => d.departmentName, options => options.MapFrom(src => src.department != null ? src.department.Name : "N/A")).ReverseMap();

            CreateMap<CreatedEmployeeDto,EMployee>().ReverseMap();
            CreateMap<updatedEmployeeDto,EMployee>().ReverseMap();


        }
    }
}
