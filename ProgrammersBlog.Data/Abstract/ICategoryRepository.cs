using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Abstract;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
        Task<Category> GetById(int categoryId);
    }
}
