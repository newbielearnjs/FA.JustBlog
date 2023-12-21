using FA.JustBlog.Core.Infastructure;
using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Services
{
    public interface IPostService 
    {
        IList<Post> GetAll();
        Post Find(int id);
        void Add(Post post);

        void Update(Post post);
        void Delete(Post post);

        void Delete(int id);

        Post FindPost(int year, int month, string urlSlug);

        IList<Post> GetPublisedPosts();

        IList<Post> GetUnpublisedPosts();

        IList<Post> GetLatestPost(int size);

        IList<Post> GetPostsByMonth(DateTime monthYear);

        int CountPostsForCategory(string category);

        IList<Post> GetPostsByCategory(int id);

        int CountPostsForTag(string tag);

        IList<Post> GetPostsByTag(string tag);

        IList<Post> GetMostViewedPost(int size);
        IList<Post> GetHighestPosts(int size);


    }
}
