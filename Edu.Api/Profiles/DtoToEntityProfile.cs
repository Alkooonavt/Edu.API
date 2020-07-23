using Domain.DataAccess.DTO;
using Domain.Model;
using Edu.Api.Responses;
using Profile = AutoMapper.Profile;

namespace Edu.Api.Profiles
{
    public class DtoToEntityProfile:Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<ApplicationDTO, Application>();
        }
    }
}