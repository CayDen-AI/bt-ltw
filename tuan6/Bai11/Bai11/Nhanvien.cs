using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai11
{
    public class Nhanvien
    {
        string ho_ten;
        int nam_sinh;
        string que_quan;

        public string HoTen
        {
            get
            {
                return ho_ten;
            }
            set
            {
                ho_ten = value;
            }
        }
        public int NamSinh
        {
            get
            {
                return nam_sinh;
            }
            set
            {
                nam_sinh = value;
            }
        }
        public string QueQuan
        {
            get
            {
                return que_quan;
            }
            set
            {
                que_quan = value;
            }
        }
    }
}