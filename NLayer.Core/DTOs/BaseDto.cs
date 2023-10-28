using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public abstract class BaseDto  //dto lar içinde client a sunacağımız datalar seçilir. Client her datayı görmemesi gerek durumlar için
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
