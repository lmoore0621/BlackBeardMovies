using AutoMapper;
using BlackBeardMovies.Dtos;
using BlackBeardMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackBeardMovies.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.Initialize(cfg => cfg.CreateMap<Customer, CustomerDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<Movie, MovieDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<MembershipType, MembershipTypeDto>());
            Mapper.Initialize(cfg => cfg.CreateMap<Genre, GenreDto>());

            //Mapper.CreateMap<Customer, CustomerDto>();
            //Mapper.CreateMap<Movie, MovieDto>();
            //Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            //Mapper.CreateMap<Genre, GenreDto>();


            // Dto to Domian
            Mapper.Initialize(cfg => cfg.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore()));
            //Mapper.CreateMap<CustomerDto, Customer>()
            //    .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.Initialize(cfg => cfg.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore()));

            //Mapper.CreateMap<MovieDto, Movie>()
            //    .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}