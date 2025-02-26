using System.Reflection;
using Autofac;
using FlightBooking.Application.Behaviors;
using FlightBooking.Application.Decorators;
using FlightBooking.Domain.Aggregates.CustomerAggregate;
using FlightBooking.Infrastructure.Repositories;
using MediatR;


namespace FlightBooking.Application.Modules
{
 public class ApplicationModule : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        // Register MediatR
        builder.RegisterAssemblyTypes(typeof(IMediator).Assembly)
            .AsImplementedInterfaces();

        // Register handlers
        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .AsClosedTypesOf(typeof(IRequestHandler<,>))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

        // Register notification handlers
        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .AsClosedTypesOf(typeof(INotificationHandler<>))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();

        // Register pipeline behaviors (like logging and validation)
        builder.RegisterGeneric(typeof(LoggingBehavior<,>))
            .As(typeof(IPipelineBehavior<,>))
            .InstancePerLifetimeScope();

        builder.RegisterGeneric(typeof(ValidatorBehavior<,>))
            .As(typeof(IPipelineBehavior<,>))
            .InstancePerLifetimeScope();

        // Register repository implementations
        builder.RegisterAssemblyTypes(typeof(CustomerRepository).Assembly)
            .Where(t => t.IsClass && !t.IsAbstract && t.GetInterfaces().Any())
            .As(t => t.GetInterfaces().First())
            .InstancePerLifetimeScope();

        // Register decorators first, so they wrap the handlers
        builder.RegisterGenericDecorator(
            typeof(DomainEventDispatcherDecorator<,>),  // The decorator type
            typeof(IRequestHandler<,>));                 // The interface to decorate
        builder.RegisterGenericDecorator(
            typeof(TransactionCommandDecorator<,>),    // The decorator type
            typeof(IRequestHandler<,>));                 // The interface to decorate

        // Register the handlers after the decorators
        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .AsClosedTypesOf(typeof(IRequestHandler<,>))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();
    }
}

}