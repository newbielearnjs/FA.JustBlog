using FA.JustBlog.Core.Infastructure;
using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Services
{
    public interface ICommentService
    {
        IList<Comment> GetAll();
        Comment Find(int id);
        void Add(Comment comment);

        void Update(Comment comment);
        void Delete(Comment comment);

        void Delete(int id);

        void AddComment(int postId, string commentName, string commentEmail, string commentTitle,
                        string commentBody);
        IList<Comment> GetCommentsForPost(int postId);
        IList<Comment> GetCommentsForPost(Post post);
    }
}
