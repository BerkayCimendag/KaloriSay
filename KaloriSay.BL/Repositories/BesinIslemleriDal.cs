using KaloriSay.BL.RepsitoriyInterfaces;
using KaloriSay.DAL.Context;
using KaloriSay.ENTITIES.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriSay.BL.Repositories
{
    public class BesinIslemleriDal : Repository<Besin>
    {
        public BesinIslemleriDal(KaloriSayContext db) : base(db)
        {
        }
    }
}
