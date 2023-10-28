using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        //navigation property product sınıfının categoryyi kullanmasına izin verir
        public ICollection<Product> Products { get; set; }
    }
}
