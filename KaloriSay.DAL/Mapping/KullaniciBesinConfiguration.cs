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
    public class KullaniciBesinConfiguration : IEntityTypeConfiguration<KullaniciBesin>
    {
        public void Configure(EntityTypeBuilder<KullaniciBesin> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.OlusturulmaTarihi).HasColumnType("date");
            builder.ToTable("KullaniciEtkilesim");
        }
    }
}
