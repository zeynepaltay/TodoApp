using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Dtos.WorkDtos;
using TodoApp.Entities.Domains;

namespace TodoApp.Business.Mappings.AutoMapper
{
    public class WorkProfile :Profile
    {
        public WorkProfile()
        {
            CreateMap<Work, WorkListDto>().ReverseMap();
            CreateMap<Work, WorkCreateDto>().ReverseMap();
            CreateMap<Work, WorkUpdateDto>().ReverseMap();
            CreateMap<WorkListDto, WorkUpdateDto>().ReverseMap();
        }
    }
}
