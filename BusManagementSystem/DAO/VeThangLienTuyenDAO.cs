using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VeThangLienTuyenDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();
        private static VeThangLienTuyenDAO instance;

        public static VeThangLienTuyenDAO Instance
        {
            get { if (instance == null) instance = new VeThangLienTuyenDAO(); return VeThangLienTuyenDAO.instance; }
            private set { VeThangLienTuyenDAO.instance = value; }
        }

        public IEnumerable<VeThangLienTuyen> XemVeLienTuyen()
        {
            List<VeThangLienTuyen> Details = new List<VeThangLienTuyen>();
            var result = db.Get_VeThangLienTuyen().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                VeThangLienTuyen vlt = new VeThangLienTuyen();
                vlt.NhanVien = new NhanVien();
                vlt.HanhKhachThang = new HanhKhachThang();
                vlt.mavethang = Convert.ToString(result[j].mavethang);
                vlt.HanhKhachThang.tenhk = Convert.ToString(result[j].tenhk);
                vlt.NhanVien.hoten = Convert.ToString(result[j].hoten);
                vlt.ngaydangky = Convert.ToDateTime(result[j].ngaydangky);
                vlt.ngayhethan = Convert.ToDateTime(result[j].ngayhethan);
                vlt.giave = Convert.ToInt32(result[j].giave);
                Details.Add(vlt);
            }
            return Details;
        }

        public void Them(VeThangLienTuyen vlt)
        {
            var result = db.Insert_VeThangLienTuyen(vlt.mahk, vlt.manv, vlt.ngaydangky, vlt.ngayhethan, vlt.giave);
        }

        public void CapNhat(VeThangLienTuyen vlt, string maVETHANG)
        {
            var result = db.Update_VeThangLienTuyen(maVETHANG,vlt.mahk, vlt.manv, vlt.ngaydangky, vlt.ngayhethan, vlt.giave);
        }

        public void Xoa(VeThangLienTuyen vlt)
        {
            var result = db.Delete_VeThangLienTuyen(vlt.mavethang);
        }

        public IEnumerable<VeThangLienTuyen> TimKiemVeThangLienTuyen(string input)
        {
            List<VeThangLienTuyen> Details = new List<VeThangLienTuyen>();
            var result = db.Search_VeThangLienTuyen(input).ToList();
            for (int j = 0; j < result.Count; j++)
            {
                VeThangLienTuyen vlt = new VeThangLienTuyen();
                vlt.NhanVien = new NhanVien();
                vlt.HanhKhachThang = new HanhKhachThang();
                vlt.mavethang = Convert.ToString(result[j].mavethang);
                vlt.HanhKhachThang.tenhk = Convert.ToString(result[j].tenhk);
                vlt.NhanVien.hoten = Convert.ToString(result[j].hoten);
                vlt.ngaydangky = Convert.ToDateTime(result[j].ngaydangky);
                vlt.ngayhethan = Convert.ToDateTime(result[j].ngayhethan);
                vlt.giave = Convert.ToInt32(result[j].giave);
                Details.Add(vlt);
            }
            return Details;
        }
    }
}
