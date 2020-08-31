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
    /// Interaction logic for UCBus.xaml
    /// </summary>
    public partial class UCBus : UserControl
    {
        private bool themMoi = true;
        private string maXE = "";

        public UCBus()
        {
            InitializeComponent();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            BatTat(true);
            BusBUS.Instance.Xem(dgvBus);
        }

        public void BatTat(bool giaTri)
        {
            btnLuu.IsEnabled = !giaTri;
            txtMaXe.IsEnabled = !giaTri;
            txtBienKiemSoat.IsEnabled = !giaTri;
            txtHangSX.IsEnabled = !giaTri;
            txtNamSX.IsEnabled = !giaTri;
            txtSoGhe.IsEnabled = !giaTri;


            btnThem.IsEnabled = giaTri;
            btnSua.IsEnabled = giaTri;
            btnXoa.IsEnabled = giaTri;
            btnHuy.IsEnabled = !giaTri;
        }

        private void dgvBus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Xe row = (Xe)dgvBus.SelectedItems[0];
                txtMaXe.Text = row.maxe;
                txtBienKiemSoat.Text = row.bienkiemsoat;
                txtHangSX.Text = row.hangsanxuat;
                txtNamSX.Text = row.namsanxuat.ToString();
                txtSoGhe.Text = row.soghe.ToString();
            }
            catch (Exception i)
            {

            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            themMoi = true;
            BatTat(false);
            txtMaXe.Text = "";
            txtBienKiemSoat.Text = "";
            txtHangSX.Text = "";
            txtNamSX.Text = "";
            txtSoGhe.Text = "";
            txtMaXe.IsEnabled = false;
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            BatTat(true);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa xe " + txtBienKiemSoat.Text + " không?", "Xóa", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Xe xe = new Xe();
                xe.maxe = txtMaXe.Text;
                BusBUS.Instance.Xoa(xe);
                Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            Xe xe = new Xe();
            xe.bienkiemsoat = txtBienKiemSoat.Text;
            xe.hangsanxuat = txtHangSX.Text;
            xe.namsanxuat = Convert.ToInt32(txtNamSX.Text);
            xe.soghe = Convert.ToInt32(txtSoGhe.Text);            
            if (themMoi)
            {
                BusBUS.Instance.Them(xe);
            }
            else
            {
                BusBUS.Instance.CapNhat(xe, maXE);
            }
            Load(sender, e);
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            BatTat(false);
            themMoi = false;
            maXE = txtMaXe.Text;
            txtMaXe.IsEnabled = false;
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            BusBUS.Instance.TimKiem(dgvBus, txtTimKiem.Text);
        }
    }
}
