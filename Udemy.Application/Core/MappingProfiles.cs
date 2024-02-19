using AutoMapper;
using Udemy.Domain;

namespace Udemy.Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Activity, Activity>();
        }
    }
}
