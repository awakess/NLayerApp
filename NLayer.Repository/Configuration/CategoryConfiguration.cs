using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id); //Id değerini primary key olarak belirtmek için  (FluentAPI Yaklaşımı)
            builder.Property(x => x.Id).UseIdentityColumn();//Id değerini birer birer arttırmak için
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50); //isim değerini require(zorunlu) ayarlayıp 50 karakter max verdik
            
            builder.ToTable("Categories"); //tablo ismi (belirtmezsek default olarak Category classının ismini alır )


        }
    }
}
