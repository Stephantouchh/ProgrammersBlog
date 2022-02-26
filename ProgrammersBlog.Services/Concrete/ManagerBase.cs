using AutoMapper;
using ProgrammersBlog.Data.Abstract;

namespace ProgrammersBlog.Services.Concrete
{
    public class ManagerBase
    {
        public ManagerBase(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
        protected IUnitOfWork UnitOfWork { get; }

        protected IMapper Mapper { get; }
    }
}
