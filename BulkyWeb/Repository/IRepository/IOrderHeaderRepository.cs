using BulkyBook.Models;
using BulkyWeb.Models;

namespace BulkyWeb.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);
        void UpdateStatus(int id, string orderStatus, string paymentStatus = null);
        void UpdateStripePaymentID(int id1, string id2, string paymentIntentId);
    }
}
