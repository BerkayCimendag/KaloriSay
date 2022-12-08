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
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Ad).HasMaxLength(50);
            builder.Property(x => x.Soyad).HasMaxLength(50);
            builder.Property(x=>x.Email).IsRequired();
            builder.Property(x=>x.Sifre).IsRequired();
            builder.HasIndex(x=>x.Email).IsUnique();
            builder.Property(x => x.KayitOlmaTarihi).IsRequired().HasColumnType("date").HasDefaultValue(DateTime.Now);
            builder.ToTable("Yöneticiler");
            builder.Ignore(x => x.AdSoyad);
        }
    }
}
