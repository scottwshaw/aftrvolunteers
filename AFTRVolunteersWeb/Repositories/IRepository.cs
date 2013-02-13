namespace AFTRVolunteersWeb.Repositories
{
    public interface IRepository<T>
    {
        void Add(T newEntity);
    }
}