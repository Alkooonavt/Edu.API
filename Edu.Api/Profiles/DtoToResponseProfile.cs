using AutoMapper;
using Domain.DataAccess.DTO;
using Edu.Api.Responses;

namespace Edu.Api.Profiles
{
    public class DtoToResponseProfile : Profile
    {
        public DtoToResponseProfile()
        {
            CreateMap<ApplicationDTO, ApplicationResponse>().ForMember(x => x.ApplicationDTO,
                x => x.MapFrom(x => x));
        }
    }
}