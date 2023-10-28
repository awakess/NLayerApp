using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public abstract class BaseEntity  //soyut nesne olduğu için abstract yaptık (new ile yapılamıyor)
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; } //?nullable olması için 
    }
}
