using AutoMapper;
using CourseServices.Catalog.Dtos;
using CourseServices.Catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseServices.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CourseServices.Catalog.Models.Course, CourseDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();
            CreateMap<CourseServices.Catalog.Models.Course, CourseCreateDto>().ReverseMap();
            CreateMap<CourseServices.Catalog.Models.Course, CourseUpdateDto>().ReverseMap();
        }
    }
}
