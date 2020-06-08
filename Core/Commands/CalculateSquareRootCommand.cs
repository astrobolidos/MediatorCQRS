using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace core.Commands
{
    public class CalculateSquareRootCommand : IRequest<double>
    {
        public int MessageId { get; set; }
        public double Number { get; set; }
    }

    public class CalculateSquareRootCommandHandler : IRequestHandler<CalculateSquareRootCommand, double>
    {
        public async Task<double> Handle(CalculateSquareRootCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(Math.Sqrt(request.Number));
        }
    }
}
