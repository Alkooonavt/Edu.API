using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Domain.DataAccess.DTO;
using Edu.Api.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Edu.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApplicationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ApplicationsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var request = new GetApplicationsCommand();
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        // GET api/<ApplicationsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var request = new GetApplicationByIdCommand(id);
            var response = await _mediator.Send(request);
            return response == null
                ? (IActionResult)NotFound((ApplicationDTO)null)
                : Ok(response);
        }

        // POST api/<ApplicationsController>
        [HttpPost]
        public async Task<IActionResult> Post(ApplicationDTO applicationDto)
        {
            var createApplicationCommand = new CreateApplicationCommand(applicationDto);
            var response = await _mediator.Send(createApplicationCommand);
            return response.StatusCode == HttpStatusCode.NotFound
                ? (IActionResult)NotFound(response)
                : Ok(response);
        }

        // PUT api/<ApplicationsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ApplicationDTO applicationDto)
        {
            var updateApplicationCommand = new UpdateApplicationCommand(id, applicationDto);
            var response = await _mediator.Send(updateApplicationCommand);
            return Ok(response);
        }

        // DELETE api/<ApplicationsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteApplicationCommand = new DeleteApplicationCommand(id);
            var response = await _mediator.Send(deleteApplicationCommand);
            return Ok(response);
        }
    }
}
