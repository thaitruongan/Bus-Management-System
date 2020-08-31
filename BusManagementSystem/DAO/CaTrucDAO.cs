using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAO
{
    public class CaTrucDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();
        private static CaTrucDAO instance;

        public static CaTrucDAO Instance
        {
            get { if (instance == null) instance = new CaTrucDAO(); return CaTrucDAO.instance; }
            private set { CaTrucDAO.instance = value; }
        }

        public IEnumerable<CaTruc> Xem()
        {
            List<CaTruc> Details = new List<CaTruc>();
            var result = db.Get_CaTruc().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                CaTruc ct = new CaTruc();
                ct.Xe = new Xe();
                ct.TuyenXe = new TuyenXe();
                ct.TaiXe = new TaiXe();
                ct.PhuXe = new PhuXe();
                ct.matuyenduong = Convert.ToString(result[j].matuyenduong);
                ct.ngaytruc = Convert.ToDateTime(result[j].ngaytruc);
                ct.ca = Convert.ToInt32(result[j].ca);
                ct.Xe.bienkiemsoat = Convert.ToString(result[j].bienkiemsoat);
                ct.TuyenXe.tentuyenxe = Convert.ToString(result[j].tentuyenxe);
                ct.TaiXe.hotentx = Convert.ToString(result[j].hotentx);
                ct.PhuXe.hoten = Convert.ToString(result[j].hoten);
                Details.Add(ct);
            }
            return Details;
        }

        public void Them(CaTruc ct)
        {
            var result = db.Insert_CaTruc(ct.ngaytruc,ct.ca,ct.maxe,ct.matuyenxe,ct.matx,ct.mapx);
        }

        public void CapNhat(CaTruc ct, string maCaTruc)
        {
            var result = db.Update_CaTruc(maCaTruc, ct.ngaytruc, ct.ca, ct.maxe, ct.matuyenxe, ct.matx, ct.mapx);
        }

        public void Xoa(CaTruc ct)
        {
            var result = db.Delete_CaTruc(ct.matuyenduong);
        }


    }
}
