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
	
	public class InstructorManager : IInstructorService
	{
		IMapper _mapper;
		IInstructorDal _instructorDal;

		public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
		{
			_instructorDal = instructorDal;
			_mapper = mapper;
		}

		public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
		{
			Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
			var createdInstructor = await _instructorDal.AddAsync(instructor);
			return _mapper.Map<CreatedInstructorResponse>(createdInstructor);
		}

		public async Task<Paginate<GetListedInstructorResponse>> GetListAsync()
		{
			var result = await _instructorDal.GetListAsync();
			return _mapper.Map<Paginate<GetListedInstructorResponse>>(result);
		}
	}
}
