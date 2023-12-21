using FA.JustBlog.Core.Repositories;

namespace FA.JustBlog.Core.Infastructure
{
    public interface IUnitOfWork
    {
        IPostRepository PostRepository { get; }
        ITagRepository TagRepository { get; }

        ICategoryRepository CategoryRepository { get; }
        ICommentRepository CommentRepository { get; }

  

        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
