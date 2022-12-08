using KaloriSay.DAL.Mapping;
using KaloriSay.ENTITIES.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KaloriSay.DAL.Context
{
    public class KaloriSayContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=KaloriSayDB;integrated security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            string KategoriYolu = Environment.CurrentDirectory + @"\Seed\Kategori.xml";

            XDocument kategoriler = XDocument.Load(KategoriYolu);

            var kategori = kategoriler.Element("Kategoriler").Elements("Kategori");
            foreach (var item in kategori)
            {
                modelBuilder.Entity<Kategori>().HasData(new Kategori
                {
                    ID = Convert.ToInt32(item.Attribute("KategoriID").Value),
                    KategoriAdi = item.Element("KATEGORIADI").Value

                });
            }
            string dosyaYolu = Environment.CurrentDirectory + @"\Seed\Besinler.xml";
            XDocument besinler = XDocument.Load(dosyaYolu);

            var besin = besinler.Element("Besinler").Elements("Besin");
            foreach (var item in besin)
            {
                modelBuilder.Entity<Besin>().HasData(new Besin
                {
                    ID = Convert.ToInt32(item.Attribute("BesinID").Value),
                    Adi = item.Element("BesinAdi").Value,
                    Miktar = Convert.ToDouble(item.Element("Miktar").Value),
                    Birim = item.Element("Birim").Value,
                    Porsiyon = item.Element("Porsiyon").Value,
                    Karbonhidrat = Convert.ToDouble(item.Element("Karbonhidrat").Value),
                    Protein = Convert.ToDouble(item.Element("Protein").Value),
                    Yag = Convert.ToDouble(item.Element("Yag").Value),
                    Kalori = Convert.ToDouble(item.Element("Kalori").Value),
                    KategoriID = Convert.ToInt32(item.Element("KategoriID").Value)
                });
            }
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                ID = 1,
                Ad = "admin",
                Soyad= "admin",
                Email= "admin@admin.com",
                Sifre= "AAaaa!!1"

            }) ;
            modelBuilder.Entity<ProjeYoneticisi>().HasData(new ProjeYoneticisi
            {
                ID = 1,
                Ad = "projeyonetici",
                Soyad = "projeyonetici",
                Email = "projeyonetici@projeyonetici.com",
                Sifre = "AAaaa!!1"
            });

            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciConfiguration());
            modelBuilder.ApplyConfiguration(new ProjeYoneticisiConfiguration());
            modelBuilder.ApplyConfiguration(new BesinConfiguration());
            modelBuilder.ApplyConfiguration(new KategoriConfiguration());
            modelBuilder.ApplyConfiguration(new TalepSikayetConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciBesinConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Kullanici> Kullanicilar => Set<Kullanici>();
        public DbSet<Admin> Adminler => Set<Admin>();
        public DbSet<ProjeYoneticisi> ProjeYoneticileri => Set<ProjeYoneticisi>();
        public DbSet<Besin> Besinler => Set<Besin>();
        public DbSet<Kategori> Kategoriler => Set<Kategori>();
        public DbSet<KullaniciBesin> KullanıcıEtkilesim => Set<KullaniciBesin>();
        public DbSet<TalepSikayet> TalepSikayetler => Set<TalepSikayet>();
    }
}
