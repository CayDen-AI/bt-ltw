using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai9
{
    public partial class xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string inputTen = Request.Form["txtTenVXL"];
            string inputHang = Request.Form["txtHang"];
            string inputNgay = Request.Form["txtNgayramat"];
            string inputGia = Request.Form["txtGia"];
            string resXML = "";
            resXML += "<tr>" + "<td>" + inputTen + "</td>" + "<td>" + inputHang + "</td>" + "<td>" + inputNgay + "</td>" + "<td>" + inputGia + "</td>" + "</tr>";

            Response.ContentType = "text/xml";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Write(resXML);
            Response.End();

        }
    }
}