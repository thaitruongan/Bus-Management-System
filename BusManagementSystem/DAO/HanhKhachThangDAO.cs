using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HanhKhachThangDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();

        private static HanhKhachThangDAO instance;

        public static HanhKhachThangDAO Instance
        {
            get { if (instance == null) instance = new HanhKhachThangDAO(); return HanhKhachThangDAO.instance; }
            private set { HanhKhachThangDAO.instance = value; }
        }

        public IEnumerable<HanhKhachThang> Xem()
        {
            List<HanhKhachThang> Details = new List<HanhKhachThang>();
            var result = db.Get_HanhKhachThang().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                HanhKhachThang hk = new HanhKhachThang();
                hk.mahk = Convert.ToString(result[j].mahk);
                hk.tenhk = Convert.ToString(result[j].tenhk);
                hk.gioitinh = Convert.ToString(result[j].gioitinh);
                hk.diachi = Convert.ToString(result[j].diachi);
                hk.cmnd = Convert.ToString(result[j].cmnd);
                hk.doituonguutien = Convert.ToInt32(result[j].doituonguutien);
                Details.Add(hk);
            }
            return Details;
        }

        public void Them(HanhKhachThang hk)
        {
            var result = db.Insert_HanhKhachThang(hk.tenhk, hk.gioitinh, hk.diachi,hk.cmnd,hk.doituonguutien);
        }

        public void Xoa(HanhKhachThang hk)
        {
            var result = db.Delete_HanhKhachThang(hk.mahk);
        }

        public void CapNhat(HanhKhachThang hk, string maHK)
        {
            var result = db.Update_HanhKhachThang(maHK, hk.tenhk, hk.gioitinh,hk.diachi,hk.cmnd,hk.doituonguutien);
        }

        public IEnumerable<HanhKhachThang> TimKiem(string search)
        {
            List<HanhKhachThang> Details = new List<HanhKhachThang>();
            var result = db.Search_HanhKhachThang(search).ToList();
            for (int j = 0; j < result.Count; j++)
            {
                HanhKhachThang hk = new HanhKhachThang();
                hk.mahk = Convert.ToString(result[j].mahk);
                hk.tenhk = Convert.ToString(result[j].tenhk);
                hk.gioitinh = Convert.ToString(result[j].gioitinh);
                hk.diachi = Convert.ToString(result[j].diachi);
                hk.cmnd = Convert.ToString(result[j].cmnd);
                hk.doituonguutien = Convert.ToInt32(result[j].doituonguutien);
                Details.Add(hk);
            }
            return Details;
        }
    }
}
