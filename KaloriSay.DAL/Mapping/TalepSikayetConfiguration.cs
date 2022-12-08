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
    public class TalepSikayetConfiguration : IEntityTypeConfiguration<TalepSikayet>
    {
        public void Configure(EntityTypeBuilder<TalepSikayet> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Talep_Sikayet).IsRequired();
            builder.Property(x => x.Acıklama).IsRequired();            
            builder.Property(x => x.OkunduMu).HasDefaultValue(false);
            builder.HasOne(x => x.Kullanici).WithMany(x => x.KullanicininSikayetleri).HasForeignKey(x => x.KullaniciID);

        }
    }
}
