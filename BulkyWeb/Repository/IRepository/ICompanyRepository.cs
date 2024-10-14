using BulkyWeb.Models;
using BulkyWeb.Models.ViewModels;

namespace BulkyWeb.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}
