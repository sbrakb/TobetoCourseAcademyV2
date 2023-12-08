using AutoMapper;
using Business.Abstracts;
using Business.Concretes;
using Business.Mapper;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        //this kelimesi sayesinde AddBusinessServices fonksiyonumuz IServiceCollection dan türemiş bütün sınıf nesnelerine ekleniyor.
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<IInstructorService, InstructorManager>();
            //services.AddScoped<IMapper, >();
            return services;
        }
    }
}
