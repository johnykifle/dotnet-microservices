using Platformservice.Dtos;
using Platformservice.Models;
using AutoMapper;

namespace Platformservice.Profiles
{ 
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
            CreateMap<Platform, PlatformReadDto>();
            
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}