using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO
    {
        QLXEBUSDataContext db = new QLXEBUSDataContext();

        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        public IEnumerable<NhanVien> Xem()
        {
            List<NhanVien> Details = new List<NhanVien>();
            var result = db.uspGetStaff().ToList();            
            for (int j = 0; j < result.Count; j++)
            {
                NhanVien nv = new NhanVien();
                Quyen q = new Quyen();
                nv.manv = Convert.ToString(result[j].manv);
                nv.anh = Convert.ToString(result[j].anh);
                nv.hoten = Convert.ToString(result[j].hoten);
                nv.ngaysinh = Convert.ToDateTime(result[j].ngaysinh);
                nv.diachi = Convert.ToString(result[j].diachi);
                nv.gioitinh = Convert.ToString(result[j].gioitinh);
                nv.dienthoai = Convert.ToString(result[j].dienthoai);
                nv.cmnd = Convert.ToString(result[j].cmnd);
                nv.bangcap = Convert.ToString(result[j].bangcap);
                nv.taikhoan = Convert.ToString(result[j].ten);
                nv.phongban = Convert.ToString(result[j].phongban);
                Details.Add(nv);
            }
            return Details;

        }

        public IEnumerable<Quyen> LoadComboBox()
        {
            List<Quyen> Details = new List<Quyen>();
            var result = db.uspGetRole().ToList();            
            for (int j = 0; j < result.Count; j++)
            {
                Quyen q = new Quyen();
                q.maquyen = Convert.ToString(result[j].maquyen);
                q.ten = Convert.ToString(result[j].ten);
                Details.Add(q);
            }
            return Details;
        }
    }
}
