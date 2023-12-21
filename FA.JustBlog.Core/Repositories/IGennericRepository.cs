

namespace FA.JustBlog.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T Find(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        IList<T> GetAll();
    }
}
