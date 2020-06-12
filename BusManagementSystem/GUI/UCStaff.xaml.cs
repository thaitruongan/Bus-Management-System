using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BUS;
using DAO;

namespace GUI
{
    /// <summary>
    /// Interaction logic for UCStaff.xaml
    /// </summary>
    public partial class UCStaff : UserControl
    {
        public UCStaff()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            txtManv.IsEnabled = false;
            NhanVienBUS.Instance.Xem(dgvStaff);
            NhanVienBUS.Instance.loadComboBox(cbTaikhoan);
        }

        private void dgvStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NhanVien row = (NhanVien)dgvStaff.SelectedItems[0];
            txtManv.Text = row.manv;
            txtTennv.Text = row.hoten;
            dtpNgaysinh.Text = row.ngaysinh.ToString();
            txtDiachi.Text = row.diachi;
            if(row.gioitinh.ToString()=="Nam")
            {
                radNam.IsChecked = true;
            }
            else if(row.gioitinh.ToString() == "Nữ")
            {
                radNu.IsChecked = true;
            }
            txtDienthoai.Text = row.dienthoai;
            txtCMND.Text = row.cmnd;
            txtBangcap.Text = row.bangcap;
            txtPhongban.Text = row.phongban;
            cbTaikhoan.Text = row.taikhoan;
        }
    }
}
