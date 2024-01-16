using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Business.Interfaces;
using TodoApp.Business.Mappings.AutoMapper;
using TodoApp.Business.Services;
using TodoApp.Business.ValidationRules;
using TodoApp.DataAccess.Context;
using TodoApp.DataAccess.UnitOfWork;
using TodoApp.Dtos.WorkDtos;

namespace TodoApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt =>
            {
                opt.UseSqlServer("server=DESKTOP-UBI1M1S\\SQLEXPRESS; database=TodoDb; integrated security=true;");
                 
                opt.LogTo(Console.WriteLine, LogLevel.Information);
       

            });

            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new WorkProfile());
            });
            var mapper=configuration.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IUow, Uow>();
            services.AddScoped<IWorkService, WorkService>();
            services.AddTransient<IValidator<WorkCreateDto>, WorkCreateDtoValidator>();
            services.AddTransient<IValidator<WorkUpdateDto>, WorkUpdateDtoValidator>();

        }

    }
}
