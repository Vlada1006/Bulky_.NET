using BulkyBook.Models;
using BulkyWeb.Data;
using BulkyWeb.Models;
using BulkyWeb.Repository.IRepository;

namespace BulkyWeb.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.orderHeaders.Update(obj);
        }
    }
}
