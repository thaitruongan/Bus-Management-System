using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiaVeBUS
    {
        private static GiaVeBUS instance;

        public static GiaVeBUS Instance
        {
            get { if (instance == null) instance = new GiaVeBUS(); return GiaVeBUS.instance; }
            private set { GiaVeBUS.instance = value; }
        }

        public GiaVeNgay get_giave()
        {
            return GiaVeDAO.Instance.get_giave();
        }
    }
}
