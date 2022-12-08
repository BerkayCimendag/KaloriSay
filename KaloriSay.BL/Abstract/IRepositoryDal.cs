using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.BL.RepsitoriyInterfaces
{
    public interface IRepositoryDal<T> where T : class
    {
        public ICollection TumunuGetir();
        public T IdyeGoreGetir(int id);
        public void Ekle(T Entity);
        public void Guncelle();
        public void Sil(T Entity);
    }
}
