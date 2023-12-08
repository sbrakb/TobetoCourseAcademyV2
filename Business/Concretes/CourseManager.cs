using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;

        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;
        }

        public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
        {
            //   var config = new MapperConfiguration(cfg => cfg.CreateMap<CreateCourseRequest, Course>());
            //_mapper = config.CreateMapper();

            Course course = _mapper.Map<Course>(createCourseRequest);

            Course createdCourse = await _courseDal.AddAsync(course);

            //CreatedCourseResponse createdCourseResponse = new CreatedCourseResponse();
            //createdCourseResponse.Id = createdCourse.Id;
            //createdCourseResponse.CategoryId = createdCourse.CategoryId;
            //createdCourseResponse.InstructorId = createdCourse.InstructorId;
            //createdCourseResponse.ImageUrl = createdCourse.ImageUrl;
            //createdCourseResponse.Description = createdCourse.Description;

            //config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CreatedCourseResponse>());
            //_mapper = config.CreateMapper();

            return _mapper.Map<CreatedCourseResponse>(createdCourse);
        }

        public async Task<Paginate<GetListedCourseResponse>> GetListAsync()
        {
            var result = await _courseDal.GetListAsync();
            return _mapper.Map<Paginate<GetListedCourseResponse>>(result);
        }
    }
}
