using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        
        public TaiKhoan ValidateAccount(string tendangnhap, string matkhau)
        {
            return TaiKhoanDAO.Instance.Login(tendangnhap, matkhau);
        }
    }
}
