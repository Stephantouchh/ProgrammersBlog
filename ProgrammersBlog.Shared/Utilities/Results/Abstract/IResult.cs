using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using System;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; } // ResultStatus.Success  // ResultStatus.Error
        public String Message { get; }
        public Exception Exception { get; }
    }
}
