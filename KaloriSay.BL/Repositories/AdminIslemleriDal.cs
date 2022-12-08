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
    public class AdminIslemleriDal : Repository<Admin>
    {
        public AdminIslemleriDal(KaloriSayContext db) : base(db)
        {
        }
    }
}
