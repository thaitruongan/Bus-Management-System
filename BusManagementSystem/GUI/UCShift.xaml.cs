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
    /// Interaction logic for UCShift.xaml
    /// </summary>
    public partial class UCShift : UserControl
    {
        private bool themMoi = true;
        private string maCaTruc = "";
        public UCShift()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            CaTrucBUS.Instance.Xem(dgvShift);
            CaTrucBUS.Instance.HienThiCboPhuXe(cboPhuXe);
            CaTrucBUS.Instance.HienThiCboTuyenDuong(cboTuyenDuong);
            CaTrucBUS.Instance.HienThiCboXe(cboXe);
            CaTrucBUS.Instance.HienThiCboTaiXe(cboTaiXe);
        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtMaCaTruc.IsEnabled = !giaTri;
            dtpNgayTruc.IsEnabled = !giaTri;
            txtCa.IsEnabled = !giaTri;
            cboPhuXe.IsEnabled = !giaTri;
            cboTaiXe.IsEnabled = !giaTri;
            cboXe.IsEnabled = !giaTri;
            cboPhuXe.IsEnabled = !giaTri;
            cboTuyenDuong.IsEnabled = !giaTri;

            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }

        private void dgvShift_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                CaTruc row = (CaTruc)dgvShift.SelectedItems[0];
                txtMaCaTruc.Text = row.matuyenduong;
                dtpNgayTruc.Text = row.ngaytruc.ToString();
                txtCa.Text = row.ca.ToString();
                cboPhuXe.Text = row.PhuXe.hoten;
                cboXe.Text = row.Xe.bienkiemsoat;
                cboTuyenDuong.Text = row.TuyenXe.tentuyenxe;
                cboTaiXe.Text = row.TaiXe.hotentx;
            }
            catch (Exception i)
            {

            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            themMoi = true;
            BatTat(false);
            txtMaCaTruc.Text = "";
            txtCa.Text = "";
            dtpNgayTruc.Text = "";
            cboTuyenDuong.Text = "";
            cboXe.Text = "";
            cboTaiXe.Text = "";
            txtMaCaTruc.IsEnabled = false;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ca trực " + txtMaCaTruc.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                CaTruc ct = new CaTruc();
                ct.matuyenduong = txtMaCaTruc.Text;
                CaTrucBUS.Instance.Xoa(ct);
                Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            BatTat(false);
            themMoi = false;
            maCaTruc = txtMaCaTruc.Text;
            txtMaCaTruc.IsEnabled = false;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            CaTruc ct = new CaTruc();
            ct.ngaytruc = dtpNgayTruc.SelectedDate.Value;
            ct.ca = Convert.ToInt32(txtCa.Text);
            ct.maxe = cboXe.SelectedValue.ToString();
            ct.matuyenxe = cboTuyenDuong.SelectedValue.ToString();
            ct.matx = cboTaiXe.SelectedValue.ToString();
            ct.mapx = cboPhuXe.SelectedValue.ToString();
            if (themMoi)
            {
                CaTrucBUS.Instance.Them(ct);
            }
            else
            {
                CaTrucBUS.Instance.CapNhat(ct, maCaTruc);
            }
            Load(sender, e);
        }
    }
}
