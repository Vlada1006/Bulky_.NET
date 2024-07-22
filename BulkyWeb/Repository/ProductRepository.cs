using BulkyWeb.Data;
using BulkyWeb.Models;
using BulkyWeb.Repository.IRepository;

namespace BulkyWeb.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.ProductId == obj.ProductId);
            if (objFromDb != null)
            {
                objFromDb.Title = objFromDb.Title;
                objFromDb.Author = objFromDb.Author;
                objFromDb.Description = objFromDb.Description;
                objFromDb.ISBN = objFromDb.ISBN;
                objFromDb.Price = objFromDb.Price;
                objFromDb.ListPrice = objFromDb.ListPrice;
                objFromDb.Price50 = objFromDb.Price50;
                objFromDb.Price100 = objFromDb.Price100;
                objFromDb.CategoryId = objFromDb.CategoryId;

                if (objFromDb.ImageUrl != null)
                {
                    objFromDb.ImageUrl = objFromDb.ImageUrl;

                }
            }
        }
    }
}

