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
    }
}
