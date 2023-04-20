using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testexportfile.Dao;
//using System.Windows.Controls;
using testexportfile.EF;
using testexportfile.Models;

using System.IO;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClosedXML.Excel;
using System.Text;

//using DocumentFormat.OpenXml.Wordprocessing;
using SautinSoft.Document;
using SautinSoft.Document.MailMerging;

namespace testexportfile.Area.Admin
{
    public class HomeController : Controller
    {

        public ActionResult Index0()
        {
            return View();
        }



        [HttpPost]
        public FileResult ExporttoW()
        {

            var dao = new EmployeeInfoDao();
            //var emplist = dao.ListAll1();

            MVCTutorialEntities entities = new MVCTutorialEntities();
            DataTable dt = new DataTable("Grid");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("CustomerId"),
                                            new DataColumn("ContactName"),
                                            new DataColumn("Phone"),
                                            new DataColumn("Email"),
                                            new DataColumn("Experience")
            });

            StringBuilder sb = new StringBuilder();

            //Table start.
            sb.Append("<html><head><meta charset='UTF-8'></head><body>");
            sb.Append("<a Style='text - align: left; font: 16px Arial; '>Bộ y tế                    Mẫu số</ a ><br></br>");
            sb.Append("<a Style='text - align: left; font: 16px Arial; '>          QĐ số</ a ><br></br>");
            sb.Append("<a Style='text - align: left; font: 16px Arial; '>            Ngày</ a ><br></br>");
            sb.Append("<strong Style='text - align: center; font: 16px Arial; '>Phiếu cấp phát Vắc xin - Vật tư y tế</ strong><br></br>");

            sb.Append("<a Style='text - align: left; font: 16px Arial; '>          Ngày              Số</ a ><br></br>");
            sb.Append("<a Style='text - align: left; font: 16px Arial; '>Họ tên người nhận hàng</ a ><br></br>");
            sb.Append("<a Style='text - align: left; font: 16px Arial; '>Ngày nhận hàng</ a ><br></br>");
            sb.Append("<a Style='text - align: left; font: 16px Arial; '>Nhập kho tại</ a ><br></br>");

            sb.Append("<table border='1' cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-family: Arial; font-size: 10pt;'><br></br>");
            //Building the Header row.
            sb.Append("<tr>");
            sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>CustomerID</th>");
            sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>ContactName</th>");
            sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Exprience</th>");
            sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>Email</th>");
            sb.Append("</tr>");

            //Building the Data rows.


            //Table end.
            sb.Append("</table>");
            sb.Append("<div Style='display:inline; justify-content: space-evenly' >");
            sb.Append("<a Style='text - align: left; font: 16px Arial; margin-right: 10px'>Ngày nhận hàng</a>");
            sb.Append("<a Style='text - align: left; font: 16px Arial; margin-right: 10px'>Người nhận hàng</a>");
            sb.Append("<a Style='text - align: left; font: 16px Arial; margin-right: 10px'>Thủ kho</a>");
            sb.Append("</div>");
            sb.Append("</body></html>");

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "application/vnd.ms-word", "Grid.doc");
        }

    }
}
