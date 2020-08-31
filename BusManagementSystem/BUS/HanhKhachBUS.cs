using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class HanhKhachBUS
    {
        private static HanhKhachBUS instance;

        public static HanhKhachBUS Instance
        {
            get { if (instance == null) instance = new HanhKhachBUS(); return HanhKhachBUS.instance; }
            private set { HanhKhachBUS.instance = value; }
        }

        public void Xem(DataGrid data)
        {
            data.ItemsSource = HanhKhachThangDAO.Instance.Xem();
        }

        public void Them(HanhKhachThang hk)
        {
            HanhKhachThangDAO.Instance.Them(hk);
        }

        public void Xoa(HanhKhachThang hk)
        {
            HanhKhachThangDAO.Instance.Xoa(hk);
        }

        public void CapNhat(HanhKhachThang hk, string maHK)
        {
            HanhKhachThangDAO.Instance.CapNhat(hk, maHK);
        }

        public void TimKiem(DataGrid data, string search)
        {
            data.ItemsSource = HanhKhachThangDAO.Instance.TimKiem(search);
        }
    }
}
