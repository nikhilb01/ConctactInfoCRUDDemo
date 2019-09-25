using AutoMapper;
using ConctactInfoCRUDDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConctactInfoCRUDDemo.Mappings
{
    public class ContactInfoMappings : Profile
    {
        public ContactInfoMappings()
        {
            CreateMap<ContactInfoViewModel, ContactInfo.DBEntities.Entities.ContactInfo>().ReverseMap();
        }
    }
}