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
    public class BesinConfiguration : IEntityTypeConfiguration<Besin>
    {
        public void Configure(EntityTypeBuilder<Besin> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Adi).IsRequired();
            builder.Property(x => x.Miktar).IsRequired();
            builder.Property(x => x.Birim).IsRequired();
            builder.Property(x => x.Porsiyon).IsRequired();
            builder.Property(x => x.Protein).IsRequired();
            builder.Property(x => x.Karbonhidrat).IsRequired();
            builder.Property(x => x.Yag).IsRequired();
            builder.HasMany(x => x.BesininKullanicilari).WithOne(x => x.KullanicininBesini).HasForeignKey(x => x.BesinID);
            builder.HasOne(x => x.Kategori).WithMany(x => x.Besinler);
        }
    }
}
