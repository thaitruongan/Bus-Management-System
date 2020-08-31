using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BusDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();

        private static BusDAO instance;

        public static BusDAO Instance
        {
            get { if (instance == null) instance = new BusDAO(); return BusDAO.instance; }
            private set { BusDAO.instance = value; }
        }

        public IEnumerable<Xe> Xem()
        {
            List<Xe> Details = new List<Xe>();
            var result = db.Get_Xe().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                Xe xe = new Xe();
                xe.maxe = Convert.ToString(result[j].maxe);
                xe.bienkiemsoat = Convert.ToString(result[j].bienkiemsoat);
                xe.hangsanxuat = Convert.ToString(result[j].hangsanxuat);
                xe.namsanxuat = Convert.ToInt32(result[j].namsanxuat);
                xe.soghe = Convert.ToInt32(result[j].soghe);
                Details.Add(xe);
            }
            return Details;
        }

        public void Them(Xe xe)
        {
            var result = db.Insert_Xe(xe.bienkiemsoat,xe.hangsanxuat,xe.namsanxuat,xe.soghe);
        }

        public void CapNhat(Xe xe, string maXE)
        {
            var result = db.Update_Xe(maXE, xe.bienkiemsoat,xe.hangsanxuat,xe.namsanxuat,xe.soghe);
        }

        public void Xoa(Xe xe)
        {
            var result = db.Delete_Xe(xe.maxe);
        }

        public IEnumerable<Xe> TimKiem(string search)
        {
            List<Xe> Details = new List<Xe>();
            var result = db.Search_Xe(search).ToList();
            for (int j = 0; j < result.Count; j++)
            {
                Xe xe = new Xe();
                xe.maxe = Convert.ToString(result[j].maxe);
                xe.bienkiemsoat = Convert.ToString(result[j].bienkiemsoat);
                xe.hangsanxuat = Convert.ToString(result[j].hangsanxuat);
                xe.namsanxuat = Convert.ToInt32(result[j].namsanxuat);
                xe.soghe = Convert.ToInt32(result[j].soghe);
                Details.Add(xe);
            }
            return Details;
        }
    }
}
