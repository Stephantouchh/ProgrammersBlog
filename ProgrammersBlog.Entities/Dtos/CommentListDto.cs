using ProgrammersBlog.Entities.Concrete;
using System.Collections.Generic;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CommentListDto
    {
        public IList<Comment> Comments { get; set; }
    }
}
