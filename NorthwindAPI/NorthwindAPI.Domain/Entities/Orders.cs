using NorthwindAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NorthwindAPI.Domain.Entities
{
    public class Orders : AuditableBaseEntity
    {
        [ForeignKey("OrderID")]
        public virtual int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
}
