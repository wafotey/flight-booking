using FlightBooking.Domain.SharedKennel;
using FlightBooking.Infrastructure;
using MediatR;


namespace FlightBooking.Application.Decorators
{
    public class DomainEventDispatcherDecorator<T, TResponse> : IRequestHandler<T, TResponse> where T : IRequest<TResponse>
    {
        private readonly IRequestHandler<T, TResponse> _decorated;

        private readonly IMediator _mediator;
        private readonly BookingDbContext _context;

        public DomainEventDispatcherDecorator(IRequestHandler<T, TResponse> decorated, IMediator mediator, BookingDbContext context)
        {
            _decorated = decorated ?? throw new ArgumentNullException(nameof(decorated));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<TResponse> Handle(T request, CancellationToken cancellationToken)
        {
            var result = await _decorated.Handle(request, cancellationToken);

            var domainEntities = _context.ChangeTracker
                .Entries<Entity<TypedIdValueBase>>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.ClearDomainEvents());

            foreach (var domainEvent in domainEvents)
                await _mediator.Publish(domainEvent);
            return result;
        }
    }
}