using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(JustBlogDbContext dbContext) : base(dbContext)
        {
        }

        public Category GetByName(string name)
        {
            return _entitySet
                .Where(p => p.Name == name).FirstOrDefault();
        }

    }
}
