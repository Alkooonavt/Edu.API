using System.Threading;
using System.Threading.Tasks;
using Domain.DataAccess.DTO;
using Domain.DataAccess.Interfaces;
using Edu.Api.Commands;
using MediatR;

namespace Edu.Api.RequestHandlers
{
    public class DeleteApplicationRequestHandler : IRequestHandler<DeleteApplicationCommand, ApplicationDTO>
    {
        private readonly IRepository<ApplicationDTO> _repository;

        public DeleteApplicationRequestHandler(IRepository<ApplicationDTO> repository)
        {
            _repository = repository;
        }

        public async Task<ApplicationDTO> Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.Remove(request.Id);
            return result;
        }
    }
}