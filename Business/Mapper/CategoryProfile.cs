using Business.Dtos.Requests;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AutoMapper;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using AutoMapper;

namespace Business.Mapper
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CreateCategoryRequest, Category>().ReverseMap();
            CreateMap<CreatedCategoryResponse, Category>().ReverseMap();
            CreateMap<Paginate<Category>, Paginate<GetListedCategoryResponse>>().ReverseMap();
            CreateMap<Category, GetListedCategoryResponse>().ReverseMap();
        }
    }
}
