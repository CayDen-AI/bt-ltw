using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Bai11
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["danhsach"] = new List<Nhanvien>();
            Nhanvien nv = new Nhanvien();
            nv.HoTen = "Nguyễn Hải Đăng";
            nv.NamSinh = 2004;
            nv.QueQuan = "Bắc Ninh";

            List<Nhanvien> ds = (List<Nhanvien>)Session["danhsach"];
            ds.Add(nv);
            Session["danhsach"] = ds;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}