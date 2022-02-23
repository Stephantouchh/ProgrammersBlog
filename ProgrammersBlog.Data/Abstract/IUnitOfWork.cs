using System;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IArticleRepository Articles { get; }  //unitofwork.articles
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        // _unitOfWork.Categories.AddAsync();
        // _unitOfWork.Categories.AddAsync(category);
        // _unitOfWork.Users.AddAsync(user);
        // _unitOfWork.SaveAsync();
        Task<int> SaveAsync();
    }
}
