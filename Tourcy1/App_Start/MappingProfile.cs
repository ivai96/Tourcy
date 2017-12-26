using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Tourcy1.Models;
using Tourcy1.Dtos;

namespace Tourcy1.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            
            
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt=>opt.Ignore());

            CreateMap<MembershipType, MembershipTypeDto>();
            //Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

           CreateMap<Continent, ContinentDto>();

           CreateMap<Tour, TourDto>();
           CreateMap<TourDto, Tour>().ForMember(t => t.Id, opt => opt.Ignore());

            CreateMap<Reservation, ReservationDto>();
            CreateMap<ReservationDto, Reservation>().ForMember(r => r.Id, opt => opt.Ignore());
        }
    }
}