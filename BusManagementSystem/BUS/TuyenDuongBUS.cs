using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class TuyenDuongBUS
    {
        private static TuyenDuongBUS instance;

        public static TuyenDuongBUS Instance
        {
            get { if (instance == null) instance = new TuyenDuongBUS(); return TuyenDuongBUS.instance; }
            private set { TuyenDuongBUS.instance = value; }
        }

        public void Xem(DataGrid data)
        {
            data.ItemsSource =TuyenDuongDAO.Instance.Xem();
        }

        public void Them(TuyenXe tuxe)
        {
            TuyenDuongDAO.Instance.Them(tuxe);
        }

        public void CapNhat(TuyenXe tuxe, string maTUXE)
        {
            TuyenDuongDAO.Instance.CapNhat(tuxe, maTUXE);
        }

        public void Xoa(TuyenXe tuxe)
        {
            TuyenDuongDAO.Instance.Xoa(tuxe);
        }

        public void TimKiem(DataGrid data, string search)
        {
            data.ItemsSource = TuyenDuongDAO.Instance.TimKiem(search);
        }

    }
}
