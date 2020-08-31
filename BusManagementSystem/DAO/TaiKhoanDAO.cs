using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAO
{
    public class TaiKhoanDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();

        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }
        public TaiKhoan Login(string tendangnhap, string matkhau)
        {
            var tmp = db.USP_Login(tendangnhap, matkhau).ToList();
            TaiKhoan tk = new TaiKhoan();
            if (tmp.Count > 0)
            {
                tk.NhanVien = new NhanVien();
                tk.id = Convert.ToInt32(tmp[0].id);
                tk.tendangnhap = tmp[0].tendangnhap.ToString();
                tk.matkhau = tmp[0].matkhau.ToString();
                tk.quyen = tmp[0].quyen.ToString();
                tk.NhanVien.hoten = tmp[0].hoten.ToString();
                tk.NhanVien.anh = tmp[0].anh.ToString();
            }
            return tk;
        }

        public IEnumerable<TaiKhoan> Xem()
        {
            List<TaiKhoan> Details = new List<TaiKhoan>();
            var result = db.Get_TaiKhoan().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.NhanVien = new NhanVien();
                tk.id = Convert.ToInt32(result[j].id);
                tk.NhanVien.hoten = Convert.ToString(result[j].hoten);
                tk.tendangnhap = Convert.ToString(result[j].tendangnhap);
                tk.matkhau = Convert.ToString(result[j].matkhau);
                tk.quyen = Convert.ToString(result[j].quyen);
                Details.Add(tk);
            }
            return Details;
        }

        public TaiKhoan get_quyen(string tendangnhap,string taikhoan)
        {
            var res = db.Get_Quyen(tendangnhap,taikhoan).ToList();
            TaiKhoan tk = new TaiKhoan();
            tk.quyen = Convert.ToString(res[0].quyen);
            return tk;
        }

        public void Them(TaiKhoan tk)
        {
            var result = db.Insert_TaiKhoan(tk.manv,tk.tendangnhap,tk.matkhau,tk.quyen);

        }

        public void CapNhat(TaiKhoan tk, int maTK)
        {
            var result = db.Update_TaiKhoan(maTK,tk.manv, tk.tendangnhap, tk.matkhau, tk.quyen);
        }

        public void Xoa(TaiKhoan tk)
        {
            var result = db.Delete_TaiKhoan(tk.id);
        }
    }
}
