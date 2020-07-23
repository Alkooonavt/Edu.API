using Domain.DataAccess.DTO;
using Edu.Api.Responses;
using MediatR;

namespace Edu.Api.Commands
{
    public class UpdateApplicationCommand: IRequest<ApplicationDTO>
    {
        public ApplicationDTO ApplicationDto { get; }
        public int Id { get; set; }

        public UpdateApplicationCommand(int id,ApplicationDTO applicationDto)
        {
            Id = id;
            ApplicationDto = applicationDto;
        }
    }
}