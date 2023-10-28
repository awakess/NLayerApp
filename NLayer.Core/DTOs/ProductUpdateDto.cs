using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProductUpdateDto   //ProductDto clienta baseDto içindeki created date gibi client a sunmak istemediğimiz dataları içerdiği için clienta sunulacak datalar için ayrı bir productDTo yazdık.!
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
