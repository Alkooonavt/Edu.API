using System.Threading;
using System.Threading.Tasks;
using Domain.DataAccess.DTO;
using Domain.DataAccess.Interfaces;
using Edu.Api.Commands;
using MediatR;

namespace Edu.Api.RequestHandlers
{
    public class UpdateApplicationRequestHandler : IRequestHandler<UpdateApplicationCommand, ApplicationDTO>
    {
        private readonly IRepository<ApplicationDTO> _repository;

        public UpdateApplicationRequestHandler(IRepository<ApplicationDTO> repository)
        {
            _repository = repository;
        }

        public async Task<ApplicationDTO> Handle(UpdateApplicationCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.Update(request.Id, request.ApplicationDto);
            return result;
        }
    }
}