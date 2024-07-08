using BulkyWeb.Models;

namespace BulkyWeb.Repository.IRepository
{
    public interface ICarRepository : IRepository<Car>
    {
        void Update(Car obj);
    }
}
