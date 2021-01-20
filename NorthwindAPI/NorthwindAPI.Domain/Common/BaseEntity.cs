using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindAPI.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
    }
}
