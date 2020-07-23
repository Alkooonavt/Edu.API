using Domain.DataAccess.DTO;
using Edu.Api.Responses;
using MediatR;

namespace Edu.Api.Commands
{
    public class CreateApplicationCommand: IRequest<ApplicationResponse>
    {
        public ApplicationDTO ApplicationDto { get; }

        public CreateApplicationCommand(ApplicationDTO applicationDto)
        {
            ApplicationDto = applicationDto;
        }
    }
}