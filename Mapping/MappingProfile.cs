using AutoMapper;
using Vega.Models;

namespace Vega.Mapping{
    public class MappingProfile: Profile {
        public MappingProfile()
        {
            CreateMap<Make, MakeResourse>(); 
            CreateMap<Model, ModelResourse>();
        }
    }
}