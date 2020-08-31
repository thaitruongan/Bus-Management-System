using BUS;
using DAO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace GUI
{
    /// <summary>
    /// Interaction logic for UCDriver.xaml
    /// </summary>
    public partial class UCDriver : UserControl
    {
        private bool themMoi = true;
        private string maTX = "";
        int flag = 0;
        public UCDriver()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            TaiXeBUS.Instance.Xem(dgvDriver);
        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtMaTX.IsEnabled = !giaTri;
            txtTenTaiXe.IsEnabled = !giaTri;
            radNam.IsEnabled = !giaTri;
            radNu.IsEnabled = !giaTri;
            txtDiachi.IsEnabled = !giaTri;
            dtpNgaysinh.IsEnabled = !giaTri;
            txtCMND.IsEnabled = !giaTri;
            txtBanglai.IsEnabled = !giaTri;
            txtAnh.IsEnabled = !giaTri; ;
            txtDienthoai.IsEnabled = !giaTri;


            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }
        private void btnOpenFile_Dialog(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "JPG Files (*.jpg)|*.jpg";
            if (op.ShowDialog() == true)
            {
                string tmp = RandomString() + ".jpg";
                File.Copy(op.FileName, AppDomain.CurrentDomain.BaseDirectory + @"image\avatar\" + tmp);
                txtAnh.Text = tmp;
                flag = 1;
            }
        }

        private void dgvDriver_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                TaiXe row = (TaiXe)dgvDriver.SelectedItems[0];
                txtMaTX.Text = row.matx;
                txtTenTaiXe.Text = row.hotentx;
                dtpNgaysinh.Text = row.ngaysinh.ToString();
                txtDiachi.Text = row.diachi;
                if (row.gioitinh.ToString() == "Nam")
                {
                    radNam.IsChecked = true;
                }
                else if (row.gioitinh.ToString() == "Nữ")
                {
                    radNu.IsChecked = true;
                }
                txtDienthoai.Text = row.dienthoai;
                txtCMND.Text = row.cmnd;
                txtBanglai.Text = row.loaibang;
                txtAnh.Text = row.anh;
            }
            catch (Exception i)
            {

            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            themMoi = true;
            BatTat(false);
            txtMaTX.Text = "";
            txtTenTaiXe.Text = "";
            dtpNgaysinh.Text = "";
            txtDiachi.Text = "";
            radNam.IsChecked = false;
            radNu.IsChecked = false;
            txtDienthoai.Text = "";
            txtCMND.Text = "";
            txtBanglai.Text = "";
            txtAnh.Text = "";
            txtMaTX.IsEnabled = false;
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            TaiXe tx = new TaiXe();
            tx.anh = txtAnh.Text;
            tx.hotentx = txtTenTaiXe.Text;
            tx.ngaysinh = dtpNgaysinh.SelectedDate.Value;
            tx.diachi = txtDiachi.Text;
            if (radNam.IsChecked == true)
            {
                tx.gioitinh = radNam.Content.ToString();
            }
            else if (radNu.IsChecked == true)
            {
                tx.gioitinh = radNu.Content.ToString();
            }
            tx.dienthoai = txtDienthoai.Text;
            tx.cmnd = txtCMND.Text;
            tx.loaibang = txtBanglai.Text;
            if (themMoi)
            {
                TaiXeBUS.Instance.Them(tx);
            }
            else
            {
                if(flag == 1)
                {
                    TaiXeBUS.Instance.CapNhat(tx, maTX);
                    flag = 0;
                }
                else
                {
                    TaiXeBUS.Instance.CapNhatNoImg(tx, maTX);
                }
            }
            Load(sender, e);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài xế " + txtTenTaiXe.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                TaiXe tx = new TaiXe();
                tx.matx = txtMaTX.Text;
                TaiXeBUS.Instance.Xoa(tx);
                Load(sender, e);
            }
        }

        public string RandomString()
        {
            string res = "";
            string scr = "qwertyuiopasdfghjklzxcvbnm0123456789QWERTYUIOPASDFGHJKLZXCVBNM";
            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                res += scr[r.Next(0, scr.Length)];
            }
            return res;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            BatTat(false);
            themMoi = false;
            maTX = txtMaTX.Text;
            txtMaTX.IsEnabled = false;
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            TaiXeBUS.Instance.TimKiem(dgvDriver, txtTimKiem.Text);
        }
    }
}
