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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for UCMonthTicket.xaml
    /// </summary>
    public partial class UCMonthTicket : UserControl
    {
        private bool themMoi = true;
        private string maVETHANG1TUYEN = "";
        private string maVETHANGLIENTUYEN = "";
        public UCMonthTicket()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            VeThang1TuyenBUS.Instance.XemVeThang1Tuyen(dgvTicket1Route);
            VeThang1TuyenBUS.Instance.HienThiCboHanhKhach(cboKhachHang);
            VeThang1TuyenBUS.Instance.HienThiCboTuyenDuong(cboTuyenDuong1Tuyen);
            VeThang1TuyenBUS.Instance.HienThiCboNhanVien(cboNhanVien);
            VeThangLienTuyenBUS.Instance.XemVeThangLienTuyen(dgvTicketMultiRoute);
            VeThangLienTuyenBUS.Instance.HienThiCboHanhKhach(cboHanhKhachLienTuyen);
            VeThangLienTuyenBUS.Instance.HienThiCboNhanVien(cboNhanVienDangKyLienTuyen);
        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtVe1Tuyen.IsEnabled = !giaTri;
            cboTuyenDuong1Tuyen.IsEnabled = !giaTri;
            cboNhanVien.IsEnabled = !giaTri;
            cboKhachHang.IsEnabled = !giaTri;
            dtpNgayDangKy1Tuyen.IsEnabled = !giaTri;
            dtpNgayHetHan1Tuyen.IsEnabled = !giaTri;
            txtGiaVe1Tuyen.IsEnabled = !giaTri;

            txtMaVeLienTuyen.IsEnabled = !giaTri;
            txtGiaVeLienTuyen.IsEnabled = !giaTri;
            cboHanhKhachLienTuyen.IsEnabled = !giaTri;
            cboNhanVienDangKyLienTuyen.IsEnabled = !giaTri;
            dtpNgayDangKyLienTuyen.IsEnabled = !giaTri;
            dtpNgayHetHanLienTuyen.IsEnabled = !giaTri;


            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if(radXylyve1tuyen.IsChecked == true)
            {
                themMoi = true;
                BatTat(false);
                txtMaVeLienTuyen.IsEnabled = false;
                txtGiaVeLienTuyen.IsEnabled = false;
                cboHanhKhachLienTuyen.IsEnabled = false;
                cboNhanVienDangKyLienTuyen.IsEnabled = false;
                dtpNgayDangKyLienTuyen.IsEnabled = false;
                dtpNgayHetHanLienTuyen.IsEnabled = false;
                txtVe1Tuyen.Text = "";
                cboTuyenDuong1Tuyen.Text = "";
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                dtpNgayDangKy1Tuyen.Text = "";
                dtpNgayHetHan1Tuyen.Text = "";
                txtGiaVe1Tuyen.Text = "";
            }
            else if(radXylyvelientuyen.IsChecked == true)
            {
                themMoi = true;
                BatTat(false);
                txtVe1Tuyen.IsEnabled = false;
                cboTuyenDuong1Tuyen.IsEnabled = false;
                cboNhanVien.IsEnabled = false;
                cboKhachHang.IsEnabled = false;
                dtpNgayDangKy1Tuyen.IsEnabled = false;
                dtpNgayHetHan1Tuyen.IsEnabled = false;
                txtGiaVe1Tuyen.IsEnabled = false;
                txtMaVeLienTuyen.Text = "";
                cboNhanVienDangKyLienTuyen.Text = "";
                cboHanhKhachLienTuyen.Text = "";
                dtpNgayDangKyLienTuyen.Text = "";
                dtpNgayHetHanLienTuyen.Text = "";
                txtGiaVeLienTuyen.Text = "";
            }
        }

        private void dgvTicket1Route_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                VeThang1Tuyen row = (VeThang1Tuyen)dgvTicket1Route.SelectedItems[0];
                txtVe1Tuyen.Text = row.mavethang;
                cboTuyenDuong1Tuyen.Text = row.TuyenXe.tentuyenxe;
                cboKhachHang.Text = row.HanhKhachThang.tenhk;
                cboNhanVien.Text = row.NhanVien.hoten;
                dtpNgayDangKy1Tuyen.Text = row.ngaydangky.ToString();
                dtpNgayHetHan1Tuyen.Text = row.ngayhethan.ToString();
                txtGiaVe1Tuyen.Text = row.giave.ToString();
            }
            catch (Exception i)
            {

            }
        }

        private void dgvTicketMultiRoute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                VeThangLienTuyen row = (VeThangLienTuyen)dgvTicketMultiRoute.SelectedItems[0];
                txtMaVeLienTuyen.Text = row.mavethang;
                cboHanhKhachLienTuyen.Text = row.HanhKhachThang.tenhk;
                cboNhanVienDangKyLienTuyen.Text = row.NhanVien.hoten ;
                dtpNgayDangKyLienTuyen.Text = row.ngaydangky.ToString();
                dtpNgayHetHanLienTuyen.Text = row.ngayhethan.ToString();
                txtGiaVeLienTuyen.Text = row.giave.ToString();
            }
            catch (Exception g)
            {

            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (radXylyve1tuyen.IsChecked == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa vé 1 tuyến của hành khách " + cboKhachHang.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    VeThang1Tuyen v1t = new VeThang1Tuyen();
                    v1t.mavethang = txtVe1Tuyen.Text;
                    VeThang1TuyenBUS.Instance.Xoa(v1t);
                    Load(sender, e);
                }
            }
            else if (radXylyvelientuyen.IsChecked == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa vé liên tuyến của hành khách " + cboHanhKhachLienTuyen.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    VeThangLienTuyen vlt = new VeThangLienTuyen();
                    vlt.mavethang = txtMaVeLienTuyen.Text;
                    VeThangLienTuyenBUS.Instance.Xoa(vlt);
                    Load(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            if (radXylyve1tuyen.IsChecked == true)
            {
                BatTat(false);
                themMoi = false;
                maVETHANG1TUYEN = txtVe1Tuyen.Text;
                txtVe1Tuyen.IsEnabled = false;
            }
            else if (radXylyvelientuyen.IsChecked == true)
            {
                BatTat(false);
                themMoi = false;
                maVETHANGLIENTUYEN = txtMaVeLienTuyen.Text;
                txtMaVeLienTuyen.IsEnabled = false;
            }
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            if (radXylyve1tuyen.IsChecked == true)
            {
                VeThang1Tuyen v1t = new VeThang1Tuyen();
                v1t.matuyenxe = cboTuyenDuong1Tuyen.SelectedValue.ToString();
                v1t.mahk = cboKhachHang.SelectedValue.ToString();
                v1t.manv = cboNhanVien.SelectedValue.ToString();
                v1t.ngaydangky = dtpNgayDangKy1Tuyen.SelectedDate.Value;
                v1t.ngayhethan = dtpNgayHetHan1Tuyen.SelectedDate.Value;
                v1t.giave = Convert.ToInt32(txtGiaVe1Tuyen.Text);
                if (themMoi)
                {
                    VeThang1TuyenBUS.Instance.Them(v1t);
                }
                else
                {
                    VeThang1TuyenBUS.Instance.CapNhat(v1t, maVETHANG1TUYEN);
                }
                Load(sender, e);
            }
            else if (radXylyvelientuyen.IsChecked == true)
            {
                VeThangLienTuyen vlt = new VeThangLienTuyen();
                vlt.mahk = cboHanhKhachLienTuyen.SelectedValue.ToString();
                vlt.manv = cboNhanVienDangKyLienTuyen.SelectedValue.ToString();
                vlt.ngaydangky = dtpNgayDangKyLienTuyen.SelectedDate.Value;
                vlt.ngayhethan = dtpNgayHetHanLienTuyen.SelectedDate.Value;
                vlt.giave = Convert.ToInt32(txtGiaVeLienTuyen.Text);
                if (themMoi)
                {
                    VeThangLienTuyenBUS.Instance.Them(vlt);
                }
                else
                {
                    VeThangLienTuyenBUS.Instance.CapNhat(vlt, maVETHANGLIENTUYEN);
                }
                Load(sender, e);
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (radXylyve1tuyen.IsChecked == true)
            {
                VeThang1TuyenBUS.Instance.TimKiemVeThang1Tuyen(dgvTicket1Route,txtTimKiem.Text);
            }
            else if (radXylyvelientuyen.IsChecked == true)
            {
                VeThangLienTuyenBUS.Instance.TimKiemVeThangLienTuyen(dgvTicketMultiRoute, txtTimKiem.Text);
            }
        }
    }
}
