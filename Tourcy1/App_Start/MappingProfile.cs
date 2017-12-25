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
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt=>opt.Ignore());

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            //Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<Tour, TourDto>();
            Mapper.CreateMap<TourDto, Tour>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}