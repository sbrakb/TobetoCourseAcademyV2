using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class InstructorProfile:Profile
    {
        public InstructorProfile()
        {
            CreateMap<CreateInstructorRequest, Instructor>().ReverseMap();
            CreateMap<CreatedInstructorResponse, Instructor>().ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<GetListedInstructorResponse>>().ReverseMap();
            CreateMap<Instructor, GetListedInstructorResponse>().ReverseMap();
        }
    }
}
