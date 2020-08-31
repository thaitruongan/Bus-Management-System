using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace GUI
{
    /// <summary>
    /// Interaction logic for UCPassengerMonth.xaml
    /// </summary>
    public partial class UCPassengerMonth : UserControl
    {
        private bool themMoi = true;
        private string maHK = "";
        public UCPassengerMonth()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            HanhKhachBUS.Instance.Xem(dgvPassengerMonth);
        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtMaHK.IsEnabled = !giaTri;
            txtTenHK.IsEnabled = !giaTri;
            radNam.IsEnabled = !giaTri;
            radNu.IsEnabled = !giaTri;
            txtDiaChi.IsEnabled = !giaTri;
            txtCmnd.IsEnabled = !giaTri;
            chkDoiTuongUuTien.IsEnabled = !giaTri;


            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }

        private void dgvPassengerMonth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                HanhKhachThang row = (HanhKhachThang)dgvPassengerMonth.SelectedItems[0];
                txtMaHK.Text = row.mahk;
                txtTenHK.Text = row.tenhk;
                txtDiaChi.Text = row.diachi;
                txtCmnd.Text = row.cmnd;
                if (row.gioitinh.ToString() == "Nam")
                {
                    radNam.IsChecked = true;
                }
                else if (row.gioitinh.ToString() == "Nữ")
                {
                    radNu.IsChecked = true;
                }
                if(row.doituonguutien == 1)
                {
                    chkDoiTuongUuTien.IsChecked = true;
                }
                else
                {
                    chkDoiTuongUuTien.IsChecked = false;
                }
            }
            catch (Exception i)
            {

            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            themMoi = true;
            BatTat(false);
            txtMaHK.Text = "";
            txtTenHK.Text = "";
            txtDiaChi.Text = "";
            txtCmnd.Text = "";
            radNam.IsChecked = false;
            radNu.IsChecked = false;
            chkDoiTuongUuTien.IsChecked = false;
            txtMaHK.IsEnabled = false;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            BatTat(false);
            themMoi = false;
            maHK = txtMaHK.Text;
            txtMaHK.IsEnabled = false;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hành khách " + txtTenHK.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                HanhKhachThang hk = new HanhKhachThang();
                hk.mahk = txtMaHK.Text;
                HanhKhachBUS.Instance.Xoa(hk);
                Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            HanhKhachThang hk = new HanhKhachThang();
            hk.tenhk = txtTenHK.Text;
            hk.diachi = txtDiaChi.Text;
            hk.cmnd = txtCmnd.Text;
            if (radNam.IsChecked == true)
            {
                hk.gioitinh = radNam.Content.ToString();
            }
            else if (radNu.IsChecked == true)
            {
                hk.gioitinh = radNu.Content.ToString();
            }
            if(chkDoiTuongUuTien.IsChecked == true)
            {
                hk.doituonguutien = 1;
            }
            else
            {
                hk.doituonguutien = 0;
            }
            if (themMoi)
            {
                HanhKhachBUS.Instance.Them(hk);
            }
            else
            {
                HanhKhachBUS.Instance.CapNhat(hk, maHK);
            }
            Load(sender, e);
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            HanhKhachBUS.Instance.TimKiem(dgvPassengerMonth, txtTimKiem.Text);
        }
    }
}
