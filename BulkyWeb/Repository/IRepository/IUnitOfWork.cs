namespace BulkyWeb.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICarRepository Car { get; }

        void Save();
    }
}
