using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get { if (instance == null) instance = new NhanVienBUS(); return NhanVienBUS.instance; }
            private set { NhanVienBUS.instance = value; }
        }

        public void Xem(DataGrid data)
        {
            data.ItemsSource = NhanVienDAO.Instance.Xem();
        }

        public void Them(NhanVien nv)
        {
            NhanVienDAO.Instance.Them(nv);
        }

        public void Xoa(NhanVien nv)
        {
            NhanVienDAO.Instance.Xoa(nv);
        }

        public void CapNhat(NhanVien nv, string maNV)
        {
            NhanVienDAO.Instance.CapNhat(nv,maNV);
        }

        public void CapNhatNoImg(NhanVien nv, string maNV)
        {
            NhanVienDAO.Instance.CapNhatNoImg(nv, maNV);
        }

        public void TimKiem(DataGrid data, string search)
        {
            data.ItemsSource = NhanVienDAO.Instance.TimKiem(search);
        }
    }
}
