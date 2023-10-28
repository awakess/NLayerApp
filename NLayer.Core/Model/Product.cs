using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }   //EFCore bunun bir foreignkey olduğunu algılayacak boşluklsuz yazınca
                                              //Bu sayede categoryıd değerine primary key yapacak
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
