using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindAPI.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
