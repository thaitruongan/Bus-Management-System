using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DAO
{
    public class DoanhThuNgayDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();
        private static DoanhThuNgayDAO instance;

        public static DoanhThuNgayDAO Instance
        {
            get { if (instance == null) instance = new DoanhThuNgayDAO(); return DoanhThuNgayDAO.instance; }
            private set { DoanhThuNgayDAO.instance = value; }
        }

        public IEnumerable<DoanhThuNgay> Xem()
        {
            List<DoanhThuNgay> Details = new List<DoanhThuNgay>();
            var result = db.Get_DoanhThuNgay().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                DoanhThuNgay dtn = new DoanhThuNgay();
                dtn.PhuXe = new PhuXe();
                dtn.madtngay = Convert.ToString(result[j].madtngay);
                dtn.PhuXe.hoten = Convert.ToString(result[j].hoten);
                dtn.tenvengay = Convert.ToString(result[j].tenvengay);
                dtn.ngay = Convert.ToDateTime(result[j].ngay);
                dtn.soluongveloai1 = Convert.ToInt32(result[j].soluongveloai1);
                dtn.soluongveloai2 = Convert.ToInt32(result[j].soluongveloai2);
                dtn.soluongveloai3 = Convert.ToInt32(result[j].soluongveloai3);
                dtn.dtngay = Convert.ToDouble(result[j].dtngay);
                Details.Add(dtn);
            }
            return Details;
        }

        public void Them(DoanhThuNgay dtn)
        {
            var result = db.Insert_DoanhThuNgay(dtn.mapx,dtn.tenvengay,dtn.ngay, dtn.soluongveloai1,dtn.soluongveloai2,dtn.soluongveloai3,dtn.dtngay);
        }

        public void CapNhat(DoanhThuNgay dtn, string maDTN)
        {
            var result = db.Update_DoanhThuNgay(maDTN, dtn.mapx, dtn.tenvengay, dtn.ngay, dtn.soluongveloai1, dtn.soluongveloai2, dtn.soluongveloai3, dtn.dtngay);
        }

        public void Xoa(DoanhThuNgay dtn)
        {
            var result = db.Delete_DoanhThuNgay(dtn.madtngay);
        }
    }


}
