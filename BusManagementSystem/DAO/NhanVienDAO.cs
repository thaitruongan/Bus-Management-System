using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();

        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        public IEnumerable<NhanVien> Xem()
        {
            List<NhanVien> Details = new List<NhanVien>();
            var result = db.uspGetStaff().ToList();            
            for (int j = 0; j < result.Count; j++)
            {
                NhanVien nv = new NhanVien();
                nv.manv = Convert.ToString(result[j].manv);
                nv.anh = AppDomain.CurrentDomain.BaseDirectory + @"image\avatar\" + Convert.ToString(result[j].anh);
                nv.hoten = Convert.ToString(result[j].hoten);
                nv.ngaysinh = Convert.ToDateTime(result[j].ngaysinh);
                nv.diachi = Convert.ToString(result[j].diachi);
                nv.gioitinh = Convert.ToString(result[j].gioitinh);
                nv.dienthoai = Convert.ToString(result[j].dienthoai);
                nv.cmnd = Convert.ToString(result[j].cmnd);
                nv.bangcap = Convert.ToString(result[j].bangcap);
                nv.phongban = Convert.ToString(result[j].phongban);
                Details.Add(nv);
            }
            return Details;
        }

        public void Them(NhanVien nv)
        {
            var result = db.Insert_NhanVien(nv.anh, nv.hoten, nv.ngaysinh, nv.diachi, nv.gioitinh, nv.dienthoai, nv.cmnd, nv.bangcap, nv.phongban);
            
        }

        public void Xoa(NhanVien nv)
        {
            var result = db.Delete_NhanVien(nv.manv);
        }

        public void CapNhat(NhanVien nv, string maNV)
        {
            var result = db.Update_NhanVien(maNV, nv.anh,nv.hoten, nv.ngaysinh, nv.diachi, nv.gioitinh, nv.dienthoai, nv.cmnd, nv.bangcap, nv.phongban);
        }

        public void CapNhatNoImg(NhanVien nv, string maNV)
        {
            var result = db.Update_NhanVienNoImg(maNV, nv.hoten, nv.ngaysinh, nv.diachi, nv.gioitinh, nv.dienthoai, nv.cmnd, nv.bangcap, nv.phongban);
        }

        public IEnumerable<NhanVien> TimKiem(string search)
        {
            List<NhanVien> Details = new List<NhanVien>();
            var result = db.Search_NhanVien(search).ToList();
            for (int j = 0; j < result.Count; j++)
            {
                NhanVien nv = new NhanVien();
                nv.manv = Convert.ToString(result[j].manv);
                nv.anh = Convert.ToString(result[j].anh);
                nv.hoten = Convert.ToString(result[j].hoten);
                nv.ngaysinh = Convert.ToDateTime(result[j].ngaysinh);
                nv.diachi = Convert.ToString(result[j].diachi);
                nv.gioitinh = Convert.ToString(result[j].gioitinh);
                nv.dienthoai = Convert.ToString(result[j].dienthoai);
                nv.cmnd = Convert.ToString(result[j].cmnd);
                nv.bangcap = Convert.ToString(result[j].bangcap);
                nv.phongban = Convert.ToString(result[j].phongban);
                Details.Add(nv);
            }
            return Details;
        }
    }
}
