using System.Collections.Generic;
using Domain.DataAccess.DTO;
using MediatR;

namespace Edu.Api.Commands
{
    public class GetApplicationByIdCommand:IRequest<ApplicationDTO>
    {
        public GetApplicationByIdCommand(int id)
        {
            Id = id;
        }

        public int Id { get; }

    }

    public class GetApplicationsCommand : IRequest<IList<ApplicationDTO>>
    {

    }
}