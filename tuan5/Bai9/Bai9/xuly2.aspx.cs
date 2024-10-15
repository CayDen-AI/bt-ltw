using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai9
{
    public partial class xuly2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string inputTen = Request.QueryString["name"];
            string inputHang = Request.QueryString["brands"];
            string inputNgay = Request.QueryString["date"];
            string inputGia = Request.QueryString["price"];
            string resXML = "";
            resXML += "<tr>" + "<td>" + inputTen + "</td>" + "<td>" + inputHang + "</td>" + "<td>" + inputNgay + "</td>" + "<td>" + inputGia + "</td>" + "</tr>";

            Response.ContentType = "text/xml";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Write(resXML);
            Response.End();
        }
    }
}