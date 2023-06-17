using CQRS.Core.Events;

namespace CQRS.Core.Infrastructure
{
    public interface IEventStore
    {
        Task SaveEventsAsync(Guid aggregateId, IEnumerable<BaseEvent> events, int expectVersion);
        Task<List<BaseEvent>> GetEventsAsync(Guid aggregateId);
        Task<List<Guid>> GetAggregateIdsAsync();
    }
}