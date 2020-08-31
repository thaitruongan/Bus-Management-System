using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TuyenDuongDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();

        private static TuyenDuongDAO instance;

        public static TuyenDuongDAO Instance
        {
            get { if (instance == null) instance = new TuyenDuongDAO(); return TuyenDuongDAO.instance; }
            private set { TuyenDuongDAO.instance = value; }
        }

        public IEnumerable<TuyenXe> Xem()
        {
            List<TuyenXe> Details = new List<TuyenXe>();
            var result = db.Get_TuyenXe().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                TuyenXe tuxe = new TuyenXe();
                tuxe.matuyenxe = Convert.ToString(result[j].matuyenxe);
                tuxe.tentuyenxe = Convert.ToString(result[j].tentuyenxe);
                tuxe.giobatdau = Convert.ToString(result[j].giobatdau);
                tuxe.gioketthuc = Convert.ToString(result[j].gioketthuc);
                tuxe.diemdau = Convert.ToString(result[j].diemdau);
                tuxe.diemcuoi = Convert.ToString(result[j].diemcuoi);
                tuxe.chitiettram = Convert.ToString(result[j].chitiettram);
                tuxe.tansuat = Convert.ToInt32(result[j].tansuat);
                tuxe.soluongxe = Convert.ToInt32(result[j].soluongxe);
                Details.Add(tuxe);
            }
            return Details;
        }

        public void Them(TuyenXe tuxe)
        {
            var result = db.Insert_TuyenXe(tuxe.tentuyenxe, tuxe.giobatdau, tuxe.gioketthuc, tuxe.diemdau, tuxe.diemcuoi, tuxe.chitiettram, tuxe.tansuat,tuxe.soluongxe);
        }

        public void CapNhat(TuyenXe tuxe, string maTUXE)
        {
            var result = db.Update_TuyenXe(maTUXE, tuxe.tentuyenxe, tuxe.giobatdau, tuxe.gioketthuc, tuxe.diemdau, tuxe.diemcuoi, tuxe.chitiettram, tuxe.tansuat, tuxe.soluongxe);
        }

        public void Xoa(TuyenXe tuxe)
        {
            var result = db.Delete_TuyenXe(tuxe.matuyenxe);
        }

        public IEnumerable<TuyenXe> TimKiem(string search)
        {
            List<TuyenXe> Details = new List<TuyenXe>();
            var result = db.Search_TuyenXe(search).ToList();
            for (int j = 0; j < result.Count; j++)
            {
                TuyenXe tuxe = new TuyenXe();
                tuxe.matuyenxe = Convert.ToString(result[j].matuyenxe);
                tuxe.tentuyenxe = Convert.ToString(result[j].tentuyenxe);
                tuxe.giobatdau = Convert.ToString(result[j].giobatdau);
                tuxe.gioketthuc = Convert.ToString(result[j].gioketthuc);
                tuxe.diemdau = Convert.ToString(result[j].diemdau);
                tuxe.diemcuoi = Convert.ToString(result[j].diemcuoi);
                tuxe.chitiettram = Convert.ToString(result[j].chitiettram);
                tuxe.tansuat = Convert.ToInt32(result[j].tansuat);
                tuxe.soluongxe = Convert.ToInt32(result[j].soluongxe);
                Details.Add(tuxe);
            }
            return Details;
        }
    }
}
