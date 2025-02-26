using FlightBooking.Infrastructure;
using MediatR;

namespace FlightBooking.Application.Decorators
{
    public class TransactionCommandDecorator<T, TResponse> : IRequestHandler<T, TResponse> where T : IRequest<TResponse>
    {
        private readonly IRequestHandler<T, TResponse> _decorated;
        private readonly BookingDbContext _context;
        public TransactionCommandDecorator(IRequestHandler<T, TResponse> decorated,BookingDbContext context)
        {
            _decorated = decorated ?? throw new ArgumentNullException(nameof(decorated));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<TResponse> Handle(T request, CancellationToken cancellationToken)
        {
            var result = await _decorated.Handle(request, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}