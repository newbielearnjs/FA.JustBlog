using FA.JustBlog.Core.Infastructure;
using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Services
{
    public interface ICategoryService
    {
        IList<Category> GetAll();
        Category Find(int id);
        Category FindByName(string name);
        void Add(Category category);

        void Update(Category category);
        void Delete(Category category);

        void Delete(int id);
    }
}
