using KaloriSay.ENTITIES.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.DAL.Mapping
{
    public class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {      
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasColumnOrder(1);
            builder.Property(x => x.Ad).HasMaxLength(50).IsRequired().HasColumnOrder(2);
            builder.Property(x => x.Soyad).HasMaxLength(50).IsRequired().HasColumnOrder(3);
            builder.Property(x => x.Boy).HasMaxLength(3).IsRequired().HasColumnOrder(4);
            builder.Property(x => x.Kilo).HasMaxLength(3).IsRequired().HasColumnOrder(5);
            builder.Property(x=>x.Yas).HasMaxLength(2).IsRequired().HasColumnOrder(6);
            builder.Property(x=>x.Email).IsRequired().HasColumnOrder(7);
            builder.Property(x=>x.Sifre).IsRequired().HasColumnOrder(8);
            builder.Property(x=>x.GunlukKalori).IsRequired().HasColumnOrder(9);
            builder.Property(x=>x.KayitOlmaTarihi).IsRequired().HasColumnOrder(10).HasColumnType("date").HasDefaultValue(DateTime.Now);
            builder.HasMany(x => x.KullanicininSikayetleri).WithOne(x => x.Kullanici).HasForeignKey(x => x.KullaniciID);
            builder.HasMany(x => x.KullanicininBesinleri).WithOne(x => x.BesininKullanicisi).HasForeignKey(x => x.KullaniciID);          
            builder.HasIndex(x => x.Email).IsUnique();

            builder.Ignore(x => x.AdSoyad);
            
        }
    }
}
