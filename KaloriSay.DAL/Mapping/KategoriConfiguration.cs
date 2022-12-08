using KaloriSay.ENTITIES.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.DAL.Mapping
{
    public class KategoriConfiguration : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.KategoriAdi).IsRequired();
            builder.HasMany(x=>x.Besinler).WithOne(x=>x.Kategori).HasForeignKey(x=>x.KategoriID);
        }
    }
}
