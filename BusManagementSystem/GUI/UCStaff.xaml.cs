using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
using BUS;
using DAO;
using Microsoft.Win32;

namespace GUI
{
    /// <summary>
    /// Interaction logic for UCStaff.xaml
    /// </summary>
    public partial class UCStaff : UserControl
    {

        private bool themMoi = true;
        private string maNV = "";
        private int flag = 0;
        public UCStaff()
        {
            InitializeComponent();
        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtManv.IsEnabled = !giaTri;
            txtTennv.IsEnabled = !giaTri;
            radNam.IsEnabled = !giaTri;
            radNu.IsEnabled = !giaTri;
            txtDiachi.IsEnabled = !giaTri;
            dtpNgaysinh.IsEnabled = !giaTri;
            txtCMND.IsEnabled = !giaTri;
            txtDiachi.IsEnabled = !giaTri;
            txtBangcap.IsEnabled = !giaTri;
            txtAnh.IsEnabled = !giaTri; ;
            txtPhongban.IsEnabled = !giaTri;
            txtDienthoai.IsEnabled = !giaTri;


            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            NhanVienBUS.Instance.Xem(dgvStaff);
        }


        private void dgvStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                NhanVien row = (NhanVien)dgvStaff.SelectedItems[0];
                txtManv.Text = row.manv;
                txtTennv.Text = row.hoten;
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
                txtBangcap.Text = row.bangcap;
                txtPhongban.Text = row.phongban;
                txtAnh.Text = row.anh;
            }
            catch (Exception i)
            {

            }
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

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            themMoi = true;
            BatTat(false);
            txtManv.Text = "";
            txtTennv.Text = "";
            dtpNgaysinh.Text = "";
            txtDiachi.Text = "";
            radNam.IsChecked = false;
            radNu.IsChecked = false;
            txtDienthoai.Text = "";
            txtCMND.Text = "";
            txtBangcap.Text = ""; ;
            txtPhongban.Text = "";
            txtAnh.Text = "";
            txtManv.IsEnabled = false;

        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.anh = txtAnh.Text;
            nv.hoten = txtTennv.Text;
            nv.ngaysinh = dtpNgaysinh.SelectedDate.Value;
            nv.diachi = txtDiachi.Text;
            if (radNam.IsChecked == true)
            {
                nv.gioitinh = radNam.Content.ToString();
            }
            else if (radNu.IsChecked == true)
            {
                nv.gioitinh = radNu.Content.ToString();
            }
            nv.dienthoai = txtDienthoai.Text;
            nv.cmnd = txtCMND.Text;
            nv.bangcap = txtBangcap.Text;
            nv.phongban = txtPhongban.Text;
            if (themMoi)
            {
                NhanVienBUS.Instance.Them(nv);
            }
            else
            {
                if(flag == 1)
                {
                    NhanVienBUS.Instance.CapNhat(nv, maNV);
                    flag = 0;
                }
                else
                {
                    NhanVienBUS.Instance.CapNhatNoImg(nv, maNV);
                }
            }
            Load(sender, e);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên " + txtTennv.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                NhanVien nv = new NhanVien();
                nv.manv = txtManv.Text;
                NhanVienBUS.Instance.Xoa(nv);
                Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            BatTat(false);
            themMoi = false;
            maNV = txtManv.Text;
            txtManv.IsEnabled = false;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            NhanVienBUS.Instance.TimKiem(dgvStaff, txtTimKiem.Text);
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }
}
