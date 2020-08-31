using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        TaiKhoan tk = new TaiKhoan();
        public MainWindow(TaiKhoan tk)
        {
            InitializeComponent();
            DisplayName.Text = tk.NhanVien.hoten;
            DisplayImage.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"image\avatar\" + tk.NhanVien.anh));
            current_taikhoan = tk;          

        }


        TaiKhoan current_taikhoan;
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
            current_taikhoan = TaiKhoanBUS.Instance.get_quyen(Login.Instance.Tk.tendangnhap, Login.Instance.Tk.matkhau);
            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCMain());
                    break;
                case 1:
                    if(current_taikhoan.quyen == "Admin")
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UCStaff());
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền truy cập vào tab này");
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UCMain());
                    }
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCDriver());
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCAssistantDriver());
                    break;
                case 4:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCBus());
                    break;
                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCRoute());
                    break;
                case 6:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCShift());
                    break;
                case 7:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCPassengerMonth());
                    break;
                case 8:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCMonthTicket());
                    break;
                case 9:
                    if (current_taikhoan.quyen == "Admin")
                    {
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UCRevenue());
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền truy cập vào tab này");
                        GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new UCMain());
                    }                    
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            TransitionContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (150 + (56 * index)), 0, 0);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đóng chương trình!", "Cảnh báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }

        }

        private void Load(object sender, RoutedEventArgs e)
        {
            if(current_taikhoan.quyen =="Admin")
            {
                btnTaikhoan.IsEnabled = true;
            }
            else
            {
                btnTaikhoan.IsEnabled = false;
            }
        }

        private void User(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }
    }
}
