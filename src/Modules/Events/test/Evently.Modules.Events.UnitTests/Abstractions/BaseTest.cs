using Bogus;
using Evently.Common.Domain;

namespace Evently.Modules.Events.UnitTests.Abstractions;

public class BaseTest
{
    protected readonly Faker Faker = new();

    public static T AssertDomainEventWasPublished<T>(Entity entity)
    where T : IDomainEvent
    {
        T? domainEvent = entity.DomainEvents.OfType<T>().SingleOrDefault();

        if (domainEvent is null)
        {
            throw new Exception($"{typeof(T).Name} was published");
        }
        return domainEvent;
    }

}
