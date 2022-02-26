using ProgrammersBlog.Entities.Concrete;
using System.Collections.Generic;

namespace ProgrammersBlog.Entities.Dtos
{
    public class RoleListDto
    {
        public IList<Role> Roles { get; set; }
    }
}
