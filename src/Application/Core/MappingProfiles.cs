﻿
using AutoMapper;
using Domain;
using Domain.Qeraat2;

namespace Application.Core
{
   public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, Activity>();

            CreateMap<UserContact, UserContact>();
        }
    }
}
