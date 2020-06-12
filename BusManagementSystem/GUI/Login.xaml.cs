using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using DAO;
using BUS;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window, INotifyPropertyChanged
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private bool isLoggedIn = false;
        private bool isJustStarted = true;
        TaiKhoan tk;
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsLoggedIn
        {
            get => isLoggedIn;
            set
            {
                isLoggedIn = value;
                NotifyPropertyChanged();
            }

        }

        public bool IsJustStarted
        {
            get => isJustStarted;
            set
            {
                isJustStarted = value;
                NotifyPropertyChanged();
            }
        }

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Login()
        {
            InitializeComponent();
        }
        private void dragMe(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

            }
        }

        private async Task<bool> ValidateCreds()
        {
            TaiKhoan currentTKhoan = taiKhoanBUS.ValidateAccount(NameTextBox.Text, PasswordBox.Password);
            if (currentTKhoan.NhanVien != null)
            {
                tk = currentTKhoan;
                await Task.Delay(2000);
                return true;
            }
            await Task.Delay(2000);
            return false;
        }

        public async void openCB(object sender, MaterialDesignThemes.Wpf.DialogOpenedEventArgs eventArgs)
        {
            try
            {
                IsLoggedIn = await ValidateCreds();
                if (IsLoggedIn)
                {
                    eventArgs.Session.Close(true);
                    await Task.Delay(2000);
                    MainWindow main = new MainWindow(tk);
                    this.Close();
                    main.ShowDialog();
                }
                else
                {

                    eventArgs.Session.Close(false);
                }
            }
            catch (Exception)
            {

            }
        }

        private void closingCB(object sender, MaterialDesignThemes.Wpf.DialogClosingEventArgs eventArgs)
        {
            if (eventArgs.Parameter != null)
            {
                if (((bool)eventArgs.Parameter) == true)
                {
                    IsJustStarted = false;
                    IsLoggedIn = true;
                }
                else if ((bool)eventArgs.Parameter == false)
                {
                    IsJustStarted = false;
                    IsLoggedIn = false;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
