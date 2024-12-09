using AutoMapper;
using Career.Src.Models;
using Career.Src.Protos;

namespace Career.Src.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Define your mappings here
            CreateMap<Models.Career, Protos.Career>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<Protos.Career, Models.Career>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}