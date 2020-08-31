using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Interaction logic for UCRevenue.xaml
    /// </summary>
    public partial class UCRevenue : UserControl
    {
        private bool themMoi = true;
        private string maDTN = "";
        GiaVeNgay gvn = new GiaVeNgay();
        public UCRevenue()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            DoanhThuNgayBUS.Instance.Xem(dgvRevenueDay);
            DoanhThuNgayBUS.Instance.HienThiCboPhuXe(cboPhuXe);
            gvn = GiaVeBUS.Instance.get_giave();

        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtMa.IsEnabled = !giaTri;
            txtTenVeNgay.IsEnabled = !giaTri;
            dtpNgay.IsEnabled = !giaTri;
            cboPhuXe.IsEnabled = !giaTri;
            txtSoluong1.IsEnabled = !giaTri;
            txtSoluong2.IsEnabled = !giaTri;
            txtSoluong3.IsEnabled = !giaTri;
            txtDoanhThu.IsEnabled = !giaTri;

            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            themMoi = true;
            BatTat(false);
            txtMa.Text = "";
            txtTenVeNgay.Text = "";
            dtpNgay.Text = "";
            cboPhuXe.Text = "";
            txtSoluong2.Text = "";
            txtSoluong2.Text = "";
            txtSoluong3.Text = "";
            txtDoanhThu.Text = "";
            txtDoanhThu.IsEnabled = false;
            txtMa.IsEnabled = false;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void dgvRevenueDay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DoanhThuNgay row = (DoanhThuNgay)dgvRevenueDay.SelectedItems[0];
                txtMa.Text = row.madtngay;
                txtTenVeNgay.Text = row.tenvengay.ToString();
                dtpNgay.Text = row.ngay.ToString();
                cboPhuXe.Text = row.PhuXe.hoten;
                txtSoluong1.Text = row.soluongveloai1.ToString();
                txtSoluong2.Text = row.soluongveloai2.ToString();
                txtSoluong3.Text = row.soluongveloai3.ToString();
                txtDoanhThu.Text = row.dtngay.ToString();
            }
            catch (Exception i)
            {

            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa doanh thu ngày " + dtpNgay.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                DoanhThuNgay dtn = new DoanhThuNgay();
                dtn.madtngay = txtMa.Text;
                DoanhThuNgayBUS.Instance.Xoa(dtn);
                Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            BatTat(false);
            themMoi = false;
            maDTN = txtMa.Text;
            txtMa.IsEnabled = false;
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {            
            DoanhThuNgay dtn = new DoanhThuNgay();
            dtn.mapx = cboPhuXe.SelectedValue.ToString();
            dtn.tenvengay = txtTenVeNgay.Text;
            dtn.ngay = dtpNgay.SelectedDate.Value;
            dtn.soluongveloai1 = Convert.ToInt32(txtSoluong1.Text);
            dtn.soluongveloai2 = Convert.ToInt32(txtSoluong2.Text);
            dtn.soluongveloai3 = Convert.ToInt32(txtSoluong3.Text);
            dtn.dtngay = Convert.ToDouble(txtDoanhThu.Text);
            if (themMoi)
            {
                DoanhThuNgayBUS.Instance.Them(dtn);
            }
            else
            {
                DoanhThuNgayBUS.Instance.CapNhat(dtn, maDTN);
            }
            Load(sender, e);
        }

        private void txtSoluong3_TextChanged(object sender, TextChangedEventArgs e)
        {
            double doanhthungay = 0;
            doanhthungay = Convert.ToInt32(txtSoluong1.Text) * gvn.giaveloai1 + Convert.ToInt32(txtSoluong2.Text) * gvn.giaveloai2 + Convert.ToInt32(txtSoluong3.Text) * gvn.giaveloai3;
            txtDoanhThu.Text = doanhthungay.ToString();
        }
    }
}
