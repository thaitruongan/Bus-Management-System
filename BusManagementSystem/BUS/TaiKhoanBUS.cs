using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();
        public bool ValidateAccount(string tendangnhap, string matkhau)
        {
            int taikhoan = (from tk in db.TaiKhoans where tk.tendangnhap == tendangnhap && tk.matkhau == matkhau select tk).Count();
            if (taikhoan == 1)
                return true;
            else
                return false;
        } 
    }
}
