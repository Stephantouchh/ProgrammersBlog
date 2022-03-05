using ProgrammersBlog.Shared.Entities.Concrete;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; } // ResultStatus.Success  // ResultStatus.Error
        public String Message { get; }
        public Exception Exception { get; }
        public IEnumerable<ValidationError> ValidationErrors { get; set; } //ValidationErrors.Add
    }
}
