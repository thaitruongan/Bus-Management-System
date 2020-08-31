using BUS;
using DAO;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace GUI
{ 
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : Window
    {
        private bool themMoi = true;
        private int id = 0;
        public User()
        {
            InitializeComponent();
        }

        private void dgvUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            TaiKhoanBUS.Instance.Xem(dgvUser);
            TaiKhoanBUS.Instance.HienThiVaoCboNhanVien(cboNhanVien);
            cboQuyen.Items.Add("Manager");
            cboQuyen.Items.Add("Admin");
            cboQuyen.Items.Add("Staff");
        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtId.IsEnabled = !giaTri;
            cboNhanVien.IsEnabled = !giaTri;
            txtTenDangNhap.IsEnabled = !giaTri;
            txtMatKhau.IsEnabled = !giaTri;
            cboQuyen.IsEnabled = !giaTri;

            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }

        private void dgvUser_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                TaiKhoan row = (TaiKhoan)dgvUser.SelectedItems[0];
                txtId.Text = row.id.ToString();
                cboNhanVien.Text = row.NhanVien.hoten;
                txtTenDangNhap.Text = row.tendangnhap;
                txtMatKhau.Text = row.matkhau;
                cboQuyen.Text = row.quyen;
            }
            catch (Exception i)
            {

            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            themMoi = true;
            BatTat(false);
            cboNhanVien.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            cboQuyen.Text = "";
            txtId.IsEnabled = false;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản " + txtTenDangNhap.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.id = Convert.ToInt32(txtId.Text);
                TaiKhoanDAO.Instance.Xoa(tk);
                Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            BatTat(false);
            themMoi = false;
            id = Convert.ToInt32(txtId.Text);
            txtId.IsEnabled = false;
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.manv = cboNhanVien.SelectedValue.ToString();
            tk.tendangnhap = txtTenDangNhap.Text;
            tk.matkhau = txtMatKhau.Text;
            tk.quyen = cboQuyen.Text;
            if (themMoi)
            {
                TaiKhoanBUS.Instance.Them(tk);
            }
            else
            {
                TaiKhoanBUS.Instance.CapNhat(tk, id);
            }
            Load(sender, e);
        }
    }
}
