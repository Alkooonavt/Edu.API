using Domain.DataAccess.DTO;
using Domain.Model;
using Profile = AutoMapper.Profile;

namespace Edu.Api.Profiles
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<Application, ApplicationDTO>();
        }
    }
}