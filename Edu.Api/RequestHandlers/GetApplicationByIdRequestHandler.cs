using System.Threading;
using System.Threading.Tasks;
using Domain.DataAccess.DTO;
using Domain.DataAccess.Interfaces;
using Edu.Api.Commands;
using MediatR;

namespace Edu.Api.RequestHandlers
{
    public class GetApplicationByIdRequestHandler : IRequestHandler<GetApplicationByIdCommand, ApplicationDTO>
    {
        private readonly IRepository<ApplicationDTO> _repository;

        public GetApplicationByIdRequestHandler(IRepository<ApplicationDTO> repository)
        {
            _repository = repository;
        }

        public async Task<ApplicationDTO> Handle(GetApplicationByIdCommand request, CancellationToken cancellationToken)
        {
            var result =await _repository.GetById(request.Id);
            return result;
        }
    }
}