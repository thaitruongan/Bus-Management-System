using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VeThang1TuyenDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();

        private static VeThang1TuyenDAO instance;

        public static VeThang1TuyenDAO Instance
        {
            get { if (instance == null) instance = new VeThang1TuyenDAO(); return VeThang1TuyenDAO.instance; }
            private set { VeThang1TuyenDAO.instance = value; }
        }

        public IEnumerable<VeThang1Tuyen> XemVe1Tuyen()
        {
            List<VeThang1Tuyen> Details = new List<VeThang1Tuyen>();
            var result = db.Get_VeThang1Tuyen().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                VeThang1Tuyen v1t = new VeThang1Tuyen();
                v1t.NhanVien = new NhanVien();
                v1t.HanhKhachThang = new HanhKhachThang();
                v1t.TuyenXe = new TuyenXe();
                v1t.mavethang = Convert.ToString(result[j].mavethang);
                v1t.TuyenXe.tentuyenxe = Convert.ToString(result[j].tentuyenxe);
                v1t.HanhKhachThang.tenhk = Convert.ToString(result[j].tenhk);
                v1t.NhanVien.hoten = Convert.ToString(result[j].hoten);
                v1t.ngaydangky = Convert.ToDateTime(result[j].ngaydangky);
                v1t.ngayhethan = Convert.ToDateTime(result[j].ngayhethan);
                v1t.giave = Convert.ToInt32(result[j].giave);
                Details.Add(v1t);
            }
            return Details;
        }

        public void Them(VeThang1Tuyen v1t)
        {
            var result = db.Insert_VeThang1Tuyen(v1t.matuyenxe,v1t.mahk,v1t.manv,v1t.ngaydangky,v1t.ngayhethan,v1t.giave);
        }

        public void CapNhat(VeThang1Tuyen v1t, string maVETHANG)
        {
            var result = db.Update_VeThang1Tuyen(maVETHANG,v1t.matuyenxe, v1t.mahk, v1t.manv, v1t.ngaydangky, v1t.ngayhethan, v1t.giave);
        }

        public void Xoa(VeThang1Tuyen v1t)
        {
            var result = db.Delete_VeThang1Tuyen(v1t.mavethang);
        }

        public IEnumerable<VeThang1Tuyen> TimKiemVeThang1Tuyen(string input)
        {
            List<VeThang1Tuyen> Details = new List<VeThang1Tuyen>();
            var result = db.Search_VeThang1Tuyen(input).ToList();
            for (int j = 0; j < result.Count; j++)
            {
                VeThang1Tuyen v1t = new VeThang1Tuyen();
                v1t.NhanVien = new NhanVien();
                v1t.HanhKhachThang = new HanhKhachThang();
                v1t.TuyenXe = new TuyenXe();
                v1t.mavethang = Convert.ToString(result[j].mavethang);
                v1t.TuyenXe.tentuyenxe = Convert.ToString(result[j].tentuyenxe);
                v1t.HanhKhachThang.tenhk = Convert.ToString(result[j].tenhk);
                v1t.NhanVien.hoten = Convert.ToString(result[j].hoten);
                v1t.ngaydangky = Convert.ToDateTime(result[j].ngaydangky);
                v1t.ngayhethan = Convert.ToDateTime(result[j].ngayhethan);
                v1t.giave = Convert.ToInt32(result[j].giave);
                Details.Add(v1t);
            }
            return Details;
        }
    }
}
