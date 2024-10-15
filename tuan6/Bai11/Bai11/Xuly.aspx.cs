using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai11
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Nhanvien> ds = (List<Nhanvien>)Session["danhsach"];
            if (!IsPostBack)
            {
                Nhanvien themnv = new Nhanvien();
                themnv.HoTen = Request.Form["hoten"];
                themnv.NamSinh = int.Parse(Request.Form["namsinh"]);
                themnv.QueQuan = Request.Form["quequan"];
                ds.Add(themnv);
                Session["danhsach"] = ds;
            }
            string chuoi = "";
            chuoi += "<table><tr><td>Họ tên</td><td>Năm sinh</td><td>Quê quán</td></tr>";
            foreach (Nhanvien nv in ds)
            {
                chuoi += "<tr><td>" + nv.HoTen + "</td><td>" + nv.NamSinh + "</td><td>" + nv.QueQuan + "</td></tr>";
            }
            chuoi += "</table>";
            bang.InnerHtml = chuoi;
        }
    }
}