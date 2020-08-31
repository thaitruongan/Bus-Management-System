using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class PhuXeBUS
    {
        private static PhuXeBUS instance;

        public static PhuXeBUS Instance
        {
            get { if (instance == null) instance = new PhuXeBUS(); return PhuXeBUS.instance; }
            private set { PhuXeBUS.instance = value; }
        }

        public void Xem(DataGrid data)
        {
            data.ItemsSource = PhuXeDAO.Instance.Xem();
        }

        public void Them(PhuXe px)
        {
            PhuXeDAO.Instance.Them(px);
        }
        public void CapNhat(PhuXe px, string maPX)
        {
            PhuXeDAO.Instance.CapNhat(px, maPX);
        }

        public void CapNhatNoImg(PhuXe px, string maPX)
        {
            PhuXeDAO.Instance.CapNhatKoImg(px, maPX);
        }
        public void Xoa(PhuXe px)
        {
            PhuXeDAO.Instance.Xoa(px);
        }

        public void TimKiem(DataGrid data, string search)
        {
            data.ItemsSource = PhuXeDAO.Instance.TimKiem(search);
        }
    }
}
