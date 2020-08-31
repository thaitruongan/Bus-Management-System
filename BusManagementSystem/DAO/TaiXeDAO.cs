using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiXeDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();

        private static TaiXeDAO instance;

        public static TaiXeDAO Instance
        {
            get { if (instance == null) instance = new TaiXeDAO(); return TaiXeDAO.instance; }
            private set { TaiXeDAO.instance = value; }
        }

        public IEnumerable<TaiXe> Xem()
        {
            List<TaiXe> Details = new List<TaiXe>();
            var result = db.Xem_TaiXe().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                TaiXe tx = new TaiXe();
                tx.matx = Convert.ToString(result[j].matx);
                tx.anh = AppDomain.CurrentDomain.BaseDirectory + @"image\avatar\" + Convert.ToString(result[j].anh);
                tx.hotentx = Convert.ToString(result[j].hotentx);
                tx.ngaysinh = Convert.ToDateTime(result[j].ngaysinh);
                tx.diachi = Convert.ToString(result[j].diachi);
                tx.gioitinh = Convert.ToString(result[j].gioitinh);
                tx.dienthoai = Convert.ToString(result[j].dienthoai);
                tx.cmnd = Convert.ToString(result[j].cmnd);
                tx.loaibang = Convert.ToString(result[j].loaibang);
                Details.Add(tx);
            }
            return Details;
        }

        public void Them(TaiXe tx)
        {
            var result = db.Insert_TaiXe(tx.anh, tx.hotentx, tx.ngaysinh,tx.gioitinh,tx.diachi, tx.dienthoai, tx.cmnd,tx.loaibang);

        }
        public void Xoa(TaiXe tx)
        {
            var result = db.Delete_TaiXe(tx.matx);
        }

        public void CapNhat(TaiXe tx, string maTX)
        {
            var result = db.Update_TaiXe(maTX, tx.anh, tx.hotentx, tx.ngaysinh, tx.diachi, tx.gioitinh, tx.dienthoai, tx.cmnd, tx.loaibang);
        }

        public void CapNhatKoImg(TaiXe tx, string maTX)
        {
            var result = db.Update_TaiXe_No_IMG(maTX, tx.hotentx, tx.ngaysinh, tx.diachi, tx.gioitinh, tx.dienthoai, tx.cmnd, tx.loaibang);
        }

        public IEnumerable<TaiXe> TimKiem(string search)
        {
            List<TaiXe> Details = new List<TaiXe>();
            var result = db.Search_TaiXe(search).ToList();
            for (int j = 0; j < result.Count; j++)
            {
                TaiXe tx = new TaiXe();
                tx.matx = Convert.ToString(result[j].matx);
                tx.anh = AppDomain.CurrentDomain.BaseDirectory + @"image\avatar\" + Convert.ToString(result[j].anh);
                tx.hotentx = Convert.ToString(result[j].hotentx);
                tx.ngaysinh = Convert.ToDateTime(result[j].ngaysinh);
                tx.diachi = Convert.ToString(result[j].diachi);
                tx.gioitinh = Convert.ToString(result[j].gioitinh);
                tx.dienthoai = Convert.ToString(result[j].dienthoai);
                tx.cmnd = Convert.ToString(result[j].cmnd);
                tx.loaibang = Convert.ToString(result[j].loaibang);
                Details.Add(tx);
            }
            return Details;
        }

    }
}
