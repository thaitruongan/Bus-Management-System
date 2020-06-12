using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void loadComboBox(ComboBox cbTaiKhoan)
        {
            cbTaiKhoan.ItemsSource = NhanVienDAO.Instance.LoadComboBox();
        }
    }
}
