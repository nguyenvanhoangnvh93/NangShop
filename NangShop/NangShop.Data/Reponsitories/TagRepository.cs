using NangShop.Data.Infrastructure;
using NangShop.Model.Models;

namespace NangShop.Data.Reponsitories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}