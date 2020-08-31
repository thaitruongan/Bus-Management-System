using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class BusBUS
    {
        private static BusBUS instance;

        public static BusBUS Instance
        {
            get { if (instance == null) instance = new BusBUS(); return BusBUS.instance; }
            private set { BusBUS.instance = value; }
        }

        public void Xem(DataGrid data)
        {
            data.ItemsSource = BusDAO.Instance.Xem();
        }

        public void Them(Xe xe)
        {
            BusDAO.Instance.Them(xe);
        }

        public void CapNhat(Xe xe, string maXE)
        {
            BusDAO.Instance.CapNhat(xe, maXE);
        }

        public void Xoa(Xe xe)
        {
            BusDAO.Instance.Xoa(xe);
        }

        public void TimKiem(DataGrid data, string search)
        {
            data.ItemsSource = BusDAO.Instance.TimKiem(search);
        }
    }
}
