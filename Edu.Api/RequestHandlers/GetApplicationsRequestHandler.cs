using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.DataAccess.DTO;
using Domain.DataAccess.Interfaces;
using Edu.Api.Commands;
using MediatR;

namespace Edu.Api.RequestHandlers
{
    public class GetApplicationsRequestHandler : IRequestHandler<GetApplicationsCommand, IList<ApplicationDTO>>
    {
        private readonly IRepository<ApplicationDTO> _repository;

        public GetApplicationsRequestHandler(IRepository<ApplicationDTO> repository)
        {
            _repository = repository;
        }

        public async Task<IList<ApplicationDTO>> Handle(GetApplicationsCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAll();
            return result;
        }
    }
}