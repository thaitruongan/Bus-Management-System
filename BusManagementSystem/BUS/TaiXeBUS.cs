using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUS
{
    public class TaiXeBUS
    {
        private static TaiXeBUS instance;

        public static TaiXeBUS Instance
        {
            get { if (instance == null) instance = new TaiXeBUS(); return TaiXeBUS.instance; }
            private set { TaiXeBUS.instance = value; }
        }

        public void Xem(DataGrid data)
        {
            data.ItemsSource = TaiXeDAO.Instance.Xem();
        }

        public void Them(TaiXe tx)
        {
            TaiXeDAO.Instance.Them(tx);
        }

        public void Xoa(TaiXe tx)
        {
            TaiXeDAO.Instance.Xoa(tx);
        }

        public void CapNhat(TaiXe tx, string maTX)
        {
            TaiXeDAO.Instance.CapNhat(tx, maTX);
        }

        public void CapNhatNoImg(TaiXe tx, string maTX)
        {
            TaiXeDAO.Instance.CapNhatKoImg(tx, maTX);
        }

        public void TimKiem(DataGrid data, string search)
        {
            data.ItemsSource = TaiXeDAO.Instance.TimKiem(search);
        }

    }
}
