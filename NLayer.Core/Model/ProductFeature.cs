﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class ProductFeature
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Heihgt { get; set; }
        public int Width { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
