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
    /// Interaction logic for UCAssistantDriver.xaml
    /// </summary>
    public partial class UCAssistantDriver : UserControl
    {
        private bool themMoi = true;
        private int flag = 0;
        private string maPX = "";
        public UCAssistantDriver()
        {
            InitializeComponent();
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
            flag = 0;
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

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            PhuXeBUS.Instance.Xem(dgvAssistantDriver);
        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtMaPX.IsEnabled = !giaTri;
            txtTenPX.IsEnabled = !giaTri;
            radNam.IsEnabled = !giaTri;
            radNu.IsEnabled = !giaTri;
            txtDiachi.IsEnabled = !giaTri;
            dtpNgaysinh.IsEnabled = !giaTri;
            txtCMND.IsEnabled = !giaTri;
            txtAnh.IsEnabled = !giaTri; ;
            txtDienthoai.IsEnabled = !giaTri;


            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }

        private void dgvAssistantDriver_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                PhuXe row = (PhuXe)dgvAssistantDriver.SelectedItems[0];
                txtMaPX.Text = row.mapx;
                txtTenPX.Text = row.hoten;
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
                txtAnh.Text = row.anh;
            }
            catch (Exception i)
            {

            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            themMoi = true;
            BatTat(false);
            txtMaPX.Text = "";
            txtTenPX.Text = "";
            dtpNgaysinh.Text = "";
            txtDiachi.Text = "";
            radNam.IsChecked = false;
            radNu.IsChecked = false;
            txtDienthoai.Text = "";
            txtCMND.Text = "";
            txtAnh.Text = "";
            txtMaPX.IsEnabled = false;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phụ xe " + txtTenPX.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                PhuXe px = new PhuXe();
                px.mapx = txtMaPX.Text;
                PhuXeBUS.Instance.Xoa(px);
                Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            PhuXe px = new PhuXe();
            px.anh = txtAnh.Text;
            px.hoten = txtTenPX.Text;
            px.ngaysinh = dtpNgaysinh.SelectedDate.Value;
            px.diachi = txtDiachi.Text;
            if (radNam.IsChecked == true)
            {
                px.gioitinh = radNam.Content.ToString();
            }
            else if (radNu.IsChecked == true)
            {
                px.gioitinh = radNu.Content.ToString();
            }
            px.dienthoai = txtDienthoai.Text;
            px.cmnd = txtCMND.Text;
            if (themMoi)
            {
                PhuXeBUS.Instance.Them(px);
            }
            else
            {
                if (flag == 1)
                {
                    PhuXeBUS.Instance.CapNhat(px, maPX);
                    flag = 0;
                }
                else
                {
                    PhuXeBUS.Instance.CapNhatNoImg(px, maPX);
                }
            }
            Load(sender, e);
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            BatTat(false);
            themMoi = false;
            maPX = txtMaPX.Text;
            txtMaPX.IsEnabled = false;
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            PhuXeBUS.Instance.TimKiem(dgvAssistantDriver, txtTimKiem.Text);
        }
    }
}
