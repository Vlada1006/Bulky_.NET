using BulkyBook.Models;
using BulkyWeb.Models;

namespace BulkyWeb.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);
    }
}
