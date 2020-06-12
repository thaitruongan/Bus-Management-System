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
        public MainWindow(TaiKhoan tk)
        {
            InitializeComponent();
            DisplayName.Text = tk.NhanVien.hoten;
            DisplayImage.Source = new BitmapImage(new Uri(tk.NhanVien.anh));
            current_taikhoan = tk;
        }
        TaiKhoan current_taikhoan;
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCMain());
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UCStaff());
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
            if(MessageBox.Show("Bạn có thực sự muốn đóng chương trình!","Cảnh báo",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }

        }

        private void Load(object sender, RoutedEventArgs e)
        {
        }
    }
}
