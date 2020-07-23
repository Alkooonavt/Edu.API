using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Domain.DataAccess.DTO;
using Domain.DataAccess.Interfaces;
using Edu.Api.Commands;
using Edu.Api.Responses;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Edu.Api.RequestHandlers
{
    public class CreateApplicationHandler : IRequestHandler<CreateApplicationCommand, ApplicationResponse>

    {
        private readonly IRepository<ApplicationDTO> _repository;

        public CreateApplicationHandler(IRepository<ApplicationDTO> repository)
        {
            _repository = repository;
        }

        public async Task<ApplicationResponse> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.Create(request.ApplicationDto);
            var response = new ApplicationResponse();

            if (result == null)
            {
                response.StatusCode = HttpStatusCode.NotFound;
                response.ErrorMessage = "Not created";
            }
            else
            {
                response.StatusCode = HttpStatusCode.OK;
                response.ApplicationDTO = result;
            }
            return response;
        }
    }
}