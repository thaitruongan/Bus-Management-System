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
    /// Interaction logic for UCRoute.xaml
    /// </summary>
    public partial class UCRoute : UserControl
    {
        private bool themMoi = true;
        private string maTUXE = "";

        public UCRoute()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            TuyenDuongBUS.Instance.Xem(dgvRoute);
        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtTuyenDuong.IsEnabled = !giaTri;
            txtTenTuyenDuong.IsEnabled = !giaTri;
            txtGioBatDau.IsEnabled = !giaTri;
            txtGioKetThuc.IsEnabled = !giaTri;
            txtDiemDau.IsEnabled = !giaTri;
            txtDiemKetThuc.IsEnabled = !giaTri;
            txtChiTietTram.IsEnabled = !giaTri;
            txtTanSuat.IsEnabled = !giaTri;
            txtSoLuongXe.IsEnabled = !giaTri;

            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }

        private void dgvRoute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                TuyenXe row = (TuyenXe)dgvRoute.SelectedItems[0];
                txtTuyenDuong.Text = row.matuyenxe;
                txtTenTuyenDuong.Text = row.tentuyenxe;
                txtGioBatDau.Text = row.giobatdau;
                txtGioKetThuc.Text = row.gioketthuc;
                txtDiemDau.Text = row.diemdau;
                txtDiemKetThuc.Text = row.diemcuoi;
                txtChiTietTram.Text = row.chitiettram;
                txtTanSuat.Text = row.tansuat.ToString();
                txtSoLuongXe.Text = row.soluongxe.ToString();
            }
            catch (Exception i)
            {

            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            themMoi = true;
            BatTat(false);
            txtTuyenDuong.Text = "";
            txtDiemKetThuc.Text = "";
            txtTenTuyenDuong.Text = "";
            txtGioBatDau.Text = "";
            txtGioKetThuc.Text = "";
            txtDiemDau.Text = "";
            txtChiTietTram.Text = "";
            txtTanSuat.Text = "";
            txtSoLuongXe.Text = "";
            txtTuyenDuong.IsEnabled = false;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tuyến đường " + txtTenTuyenDuong.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                TuyenXe tuxe = new TuyenXe();
                tuxe.matuyenxe = txtTuyenDuong.Text;
                TuyenDuongBUS.Instance.Xoa(tuxe);
                Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            TuyenXe tuxe = new TuyenXe();
            tuxe.tentuyenxe = txtTenTuyenDuong.Text;
            tuxe.giobatdau = txtGioBatDau.Text;
            tuxe.gioketthuc = txtGioKetThuc.Text;
            tuxe.diemdau = txtDiemDau.Text;
            tuxe.diemcuoi = txtDiemKetThuc.Text;
            tuxe.chitiettram = txtChiTietTram.Text;
            tuxe.tansuat = Convert.ToInt32(txtTanSuat.Text);
            tuxe.soluongxe = Convert.ToInt32(txtSoLuongXe.Text);
            if (themMoi)
            {
                TuyenDuongBUS.Instance.Them(tuxe);
            }
            else
            {
                TuyenDuongBUS.Instance.CapNhat(tuxe, maTUXE);
            }
            Load(sender, e);
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            BatTat(false);
            themMoi = false;
            maTUXE = txtTuyenDuong.Text;
            txtTuyenDuong.IsEnabled = false;
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            TuyenDuongBUS.Instance.TimKiem(dgvRoute,txtTimKiem.Text);
        }
    }
}
