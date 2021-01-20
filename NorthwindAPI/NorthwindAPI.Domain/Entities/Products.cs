﻿using NorthwindAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindAPI.Domain.Entities
{
    public class Products
    {
     
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
}
