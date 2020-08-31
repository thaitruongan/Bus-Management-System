using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class CaTrucBUS
    {
        private static CaTrucBUS instance;

        public static CaTrucBUS Instance
        {
            get { if (instance == null) instance = new CaTrucBUS(); return CaTrucBUS.instance; }
            private set { CaTrucBUS.instance = value; }
        }

        public void Xem(DataGrid data)
        {
            data.ItemsSource = CaTrucDAO.Instance.Xem();
        }

        public void HienThiCboTuyenDuong(ComboBox cbo)
        {
            cbo.ItemsSource = TuyenDuongDAO.Instance.Xem();
        }

        public void HienThiCboTaiXe(ComboBox cbo)
        {
            cbo.ItemsSource = TaiXeDAO.Instance.Xem();
        }

        public void HienThiCboXe(ComboBox cbo)
        {
            cbo.ItemsSource = BusDAO.Instance.Xem();
        }

        public void HienThiCboPhuXe(ComboBox cbo)
        {
            cbo.ItemsSource = PhuXeDAO.Instance.Xem();
        }

        public void Them(CaTruc ct)
        {
            CaTrucDAO.Instance.Them(ct);
        }

        public void CapNhat(CaTruc ct, string maCaTruc)
        {
            CaTrucDAO.Instance.CapNhat(ct, maCaTruc);
        }

        public void Xoa(CaTruc ct)
        {
            CaTrucDAO.Instance.Xoa(ct);
        }
    }
}
