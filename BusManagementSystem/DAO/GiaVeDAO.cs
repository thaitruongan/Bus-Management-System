using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaVeDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();
        private static GiaVeDAO instance;

        public static GiaVeDAO Instance
        {
            get { if (instance == null) instance = new GiaVeDAO(); return GiaVeDAO.instance; }
            private set { GiaVeDAO.instance = value; }
        }

        public GiaVeNgay get_giave()
        {
            var result = db.Get_GiaVe().ToList();
            GiaVeNgay gvn =  new GiaVeNgay();
            gvn.giaveloai1 = Convert.ToInt32(result[0].giaveloai1);
            gvn.giaveloai2 = Convert.ToInt32(result[0].giaveloai2);
            gvn.giaveloai3 = Convert.ToInt32(result[0].giaveloai3);
            return gvn;
        }
    }
}
