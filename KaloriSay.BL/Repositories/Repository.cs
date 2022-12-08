using KaloriSay.BL.RepsitoriyInterfaces;
using KaloriSay.DAL.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.BL.Repositories
{
    public class Repository<T> : IRepositoryDal<T> where T : class
    {
        private KaloriSayContext _db;
        public Repository(KaloriSayContext db)
        {
            _db= db;
        }
        public void Ekle(T Entity)
        {
            _db.Add(Entity);
            _db.SaveChanges();
        }

        public void Guncelle()
        {
            _db.SaveChanges();
        }

        public T IdyeGoreGetir(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Sil(T Entity)
        {
            _db.Remove(Entity);
            _db.SaveChanges();
        }
        public void TopluSil(List<T> Entities)
        {
            _db.RemoveRange(Entities);
            _db.SaveChanges();
        }

        public ICollection TumunuGetir()
        {
            return _db.Set<T>().ToList();
        }
    }
}
