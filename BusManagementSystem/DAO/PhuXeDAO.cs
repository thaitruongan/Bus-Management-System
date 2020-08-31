using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhuXeDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();

        private static PhuXeDAO instance;

        public static PhuXeDAO Instance
        {
            get { if (instance == null) instance = new PhuXeDAO(); return PhuXeDAO.instance; }
            private set { PhuXeDAO.instance = value; }
        }

        public IEnumerable<PhuXe> Xem()
        {
            List<PhuXe> Details = new List<PhuXe>();
            var result = db.Get_PhuXe().ToList();
            for (int j = 0; j < result.Count; j++)
            {
                PhuXe px = new PhuXe();
                px.mapx = Convert.ToString(result[j].mapx);
                px.anh = AppDomain.CurrentDomain.BaseDirectory + @"image\avatar\" + Convert.ToString(result[j].anh);
                px.hoten = Convert.ToString(result[j].hoten);
                px.ngaysinh = Convert.ToDateTime(result[j].ngaysinh);
                px.diachi = Convert.ToString(result[j].diachi);
                px.gioitinh = Convert.ToString(result[j].gioitinh);
                px.dienthoai = Convert.ToString(result[j].dienthoai);
                px.cmnd = Convert.ToString(result[j].cmnd);
                Details.Add(px);
            }
            return Details;
        }

        public void Them(PhuXe px)
        {
            var result = db.Insert_PhuXe(px.anh, px.hoten, px.ngaysinh, px.diachi, px.gioitinh, px.dienthoai, px.cmnd);

        }

        public void CapNhat(PhuXe px, string maPX)
        {
            var result = db.Update_PhuXe(maPX, px.anh, px.hoten, px.ngaysinh, px.diachi, px.gioitinh, px.dienthoai, px.cmnd);
        }

        public void CapNhatKoImg(PhuXe px, string maPX)
        {
            var result = db.Update_PhuXe_No_IMG(maPX, px.hoten, px.ngaysinh, px.diachi, px.gioitinh, px.dienthoai, px.cmnd);
        }


        public void Xoa(PhuXe px)
        {
            var result = db.Delete_PhuXe(px.mapx);
        }

        public IEnumerable<PhuXe> TimKiem(string search)
        {
            List<PhuXe> Details = new List<PhuXe>();
            var result = db.Search_PhuXe(search).ToList();
            for (int j = 0; j < result.Count; j++)
            {
                PhuXe px = new PhuXe();
                px.mapx = Convert.ToString(result[j].mapx);
                px.anh = AppDomain.CurrentDomain.BaseDirectory + @"image\avatar\" + Convert.ToString(result[j].anh);
                px.hoten = Convert.ToString(result[j].hoten);
                px.ngaysinh = Convert.ToDateTime(result[j].ngaysinh);
                px.diachi = Convert.ToString(result[j].diachi);
                px.gioitinh = Convert.ToString(result[j].gioitinh);
                px.dienthoai = Convert.ToString(result[j].dienthoai);
                px.cmnd = Convert.ToString(result[j].cmnd);
                Details.Add(px);
            }
            return Details;
        }
    }
}
