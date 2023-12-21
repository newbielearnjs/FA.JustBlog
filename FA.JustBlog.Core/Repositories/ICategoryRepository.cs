using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetByName(string name);
    }
}
