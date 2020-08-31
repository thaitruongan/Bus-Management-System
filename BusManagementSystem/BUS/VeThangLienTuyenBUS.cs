using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class VeThangLienTuyenBUS
    {
        private static VeThangLienTuyenBUS instance;

        public static VeThangLienTuyenBUS Instance
        {
            get { if (instance == null) instance = new VeThangLienTuyenBUS(); return VeThangLienTuyenBUS.instance; }
            private set { VeThangLienTuyenBUS.instance = value; }
        }

        public void XemVeThangLienTuyen(DataGrid data)
        {
            data.ItemsSource = VeThangLienTuyenDAO.Instance.XemVeLienTuyen();
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

        public void Them(VeThangLienTuyen vlt)
        {
            VeThangLienTuyenDAO.Instance.Them(vlt);
        }

        public void CapNhat(VeThangLienTuyen vlt, string maVETHANG)
        {
            VeThangLienTuyenDAO.Instance.CapNhat(vlt, maVETHANG);
        }

        public void Xoa(VeThangLienTuyen vlt)
        {
            VeThangLienTuyenDAO.Instance.Xoa(vlt);
        }

        public void TimKiemVeThangLienTuyen(DataGrid data, string input)
        {
            data.ItemsSource = VeThangLienTuyenDAO.Instance.TimKiemVeThangLienTuyen(input);
        }
    }
}
