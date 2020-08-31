using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class VeThang1TuyenBUS
    {
        private static VeThang1TuyenBUS instance;

        public static VeThang1TuyenBUS Instance
        {
            get { if (instance == null) instance = new VeThang1TuyenBUS(); return VeThang1TuyenBUS.instance; }
            private set { VeThang1TuyenBUS.instance = value; }
        }

        public void XemVeThang1Tuyen(DataGrid data)
        {
            data.ItemsSource = VeThang1TuyenDAO.Instance.XemVe1Tuyen();
        }

        public void HienThiCboHanhKhach(ComboBox cbo)
        {
            cbo.ItemsSource = HanhKhachThangDAO.Instance.Xem();
        }

        public void HienThiCboTuyenDuong(ComboBox cbo)
        {
            cbo.ItemsSource = TuyenDuongDAO.Instance.Xem();
        }

        public void HienThiCboNhanVien(ComboBox cbo)
        {
            cbo.ItemsSource = NhanVienDAO.Instance.Xem();
        }

        public void Them(VeThang1Tuyen v1t)
        {
            VeThang1TuyenDAO.Instance.Them(v1t);
        }

        public void CapNhat(VeThang1Tuyen v1t, string maVETHANG)
        {
            VeThang1TuyenDAO.Instance.CapNhat(v1t, maVETHANG);
        }

        public void Xoa(VeThang1Tuyen v1t)
        {
            VeThang1TuyenDAO.Instance.Xoa(v1t);
        }

        public void TimKiemVeThang1Tuyen(DataGrid data,string input)
        {
            data.ItemsSource = VeThang1TuyenDAO.Instance.TimKiemVeThang1Tuyen(input);
        }
    }
}
