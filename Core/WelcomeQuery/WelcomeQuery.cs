using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace core.Queries
{
    public class WelcomeMessageQuery : IRequest<WelcomeMessage>
    {
        public int MessageId { get; set; }
    }

    public class WelcomeMessageQueryHandler : IRequestHandler<WelcomeMessageQuery, WelcomeMessage>
    {
        public async Task<WelcomeMessage> Handle(WelcomeMessageQuery request, CancellationToken cancellationToken)
        {
            var welcomeMessage = new WelcomeMessage { Text = $"Welcome Stranger {request.MessageId}" };

            return await Task.FromResult(welcomeMessage);
        }
    }
}
