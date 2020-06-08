using System.Threading.Tasks;
using core.Commands;
using core.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Web.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WelcomeController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpGet("{id}")]
        public async Task<WelcomeMessage> Get(int id)
        {
            return await Mediator.Send(new WelcomeMessageQuery { MessageId = id });
        }

        [HttpPost("{id}")]
        public async Task<double> Post(int id, [FromBody] double number)
        {
            return await Mediator.Send(new CalculateSquareRootCommand {
                MessageId = id,
                Number = number
            });
        }
    }
}
