using NangShop.Data.Infrastructure;
using NangShop.Model.Models;

namespace NangShop.Data.Reponsitories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}