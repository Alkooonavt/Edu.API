using Domain.DataAccess.DTO;
using Edu.Api.Responses;
using MediatR;

namespace Edu.Api.Commands
{
    public class DeleteApplicationCommand : IRequest<ApplicationDTO>
    {
        public int Id { get; }

        public DeleteApplicationCommand(int id)
        {
            Id = id;
        }
    }


}