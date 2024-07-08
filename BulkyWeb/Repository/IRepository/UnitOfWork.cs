using BulkyWeb.Data;

namespace BulkyWeb.Repository.IRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository Category {  get; private set; }
        public ICarRepository Car { get; private set; }

        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Car = new CarRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
