using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Repositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(JustBlogDbContext dbContext) : base(dbContext)
        {
        }
        public Tag GetTagByUrlSlug(string urlSlug)
        {
            return _dbContext.Tags.FirstOrDefault(t => t.UrlSlug == urlSlug);
        }

    }
}
