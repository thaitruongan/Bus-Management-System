using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {

        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get { if (instance == null) instance = new TaiKhoanBUS(); return TaiKhoanBUS.instance; }
            private set { TaiKhoanBUS.instance = value; }
        }

        public TaiKhoan get_quyen(string tendangnhap,string matkhau)
        {
            return TaiKhoanDAO.Instance.get_quyen(tendangnhap,matkhau);
        }
        public TaiKhoan ValidateAccount(string tendangnhap, string matkhau)
        {
            return TaiKhoanDAO.Instance.Login(tendangnhap, matkhau);
        }

        public void Xem(DataGrid data)
        {
            data.ItemsSource = TaiKhoanDAO.Instance.Xem();
        }

        public void Them(TaiKhoan tk)
        {
            TaiKhoanDAO.Instance.Them(tk);
        }

        public void Xoa(TaiKhoan tk)
        {
            TaiKhoanDAO.Instance.Xoa(tk);
        }

        public void CapNhat(TaiKhoan tk, int id)
        {
            TaiKhoanDAO.Instance.CapNhat(tk, id);
        }

        public void HienThiVaoCboNhanVien(ComboBox cbo)
        {
            cbo.ItemsSource = NhanVienDAO.Instance.Xem();
        }
    }
}
