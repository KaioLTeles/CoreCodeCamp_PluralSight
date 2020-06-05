using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            this.CreateMap<Camp, CampModel>();
        }
    }
}
