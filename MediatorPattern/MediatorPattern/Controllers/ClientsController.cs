using Application.Queries.Clients.SearchClient;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorPattern.Controllers
{
    [ApiController]
    [Route("Clients")]
    public class ClientsController : ControllerBase
    {

        private readonly IMediator _mediator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediator"></param>
        public ClientsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Search Client By Id
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [HttpGet("GetById/{Id}")]
        public async Task<IActionResult> GetClientById([FromRoute] GetClientQuery query)
        {
            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}