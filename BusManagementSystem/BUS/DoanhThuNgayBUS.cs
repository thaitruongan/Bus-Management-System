using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class DoanhThuNgayBUS
    {
        private static DoanhThuNgayBUS instance;

        public static DoanhThuNgayBUS Instance
        {
            get { if (instance == null) instance = new DoanhThuNgayBUS(); return DoanhThuNgayBUS.instance; }
            private set { DoanhThuNgayBUS.instance = value; }
        }

        public void Xem(DataGrid data)
        {
            data.ItemsSource = DoanhThuNgayDAO.Instance.Xem();
        }

        public void HienThiCboPhuXe(ComboBox cbo)
        {
            cbo.ItemsSource = PhuXeDAO.Instance.Xem();
        }

        public void Them(DoanhThuNgay dtn)
        {
            DoanhThuNgayDAO.Instance.Them(dtn);
        }

        public void CapNhat(DoanhThuNgay dtn, string maDTN)
        {
            DoanhThuNgayDAO.Instance.CapNhat(dtn, maDTN);
        }

        public void Xoa(DoanhThuNgay dtn)
        {
            DoanhThuNgayDAO.Instance.Xoa(dtn);
        }
    }
}
