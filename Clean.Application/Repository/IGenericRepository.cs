namespace Clean.Application.Repository
{
    public interface IGenericRepository<TAggregateId, TAggregate>
    {
        TAggregate GetById(TAggregateId id);

        TAggregate InsertOrUpdate(TAggregate aggregate);

        void Delete(TAggregateId id);
    }
}
