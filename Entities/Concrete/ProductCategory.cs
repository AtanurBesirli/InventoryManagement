﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class ProductCategory:IEntity
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }
    }
}