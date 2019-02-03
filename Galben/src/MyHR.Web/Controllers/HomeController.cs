using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Microsoft.Office.Interop.Word;

namespace MyHR.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       /* public void ExportToWord(string Name, string Surname, string PIN, string Adresa, string Manager, string Vechime, string PositionName, string DepartmentName, string Salary)
        {
            
            string savePath = Server.MapPath("~/result/result.docx");
            string templatePath = Server.MapPath("~/template/WordTemplate.docx");
           Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
           Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
            doc = app.Documents.Open(templatePath);
            doc.Activate();
            if (doc.Bookmarks.Exists("Name"))
            {
                doc.Bookmarks["Name"].Range.Text = Name;
            }
            if (doc.Bookmarks.Exists("Prenume"))
            {
                doc.Bookmarks["Prenume"].Range.Text = Surname;
            }
            if (doc.Bookmarks.Exists("CNP"))
            {
                doc.Bookmarks["CNP"].Range.Text = PIN;
            }
            if (doc.Bookmarks.Exists("Adresa"))
            {
                doc.Bookmarks["Adresa"].Range.Text = Adresa;
            }
            if (doc.Bookmarks.Exists("Manager"))
            {
                doc.Bookmarks["Manager"].Range.Text = Manager;
            }
            if (doc.Bookmarks.Exists("Data"))
            {
                doc.Bookmarks["Data"].Range.Text = Vechime;
            }
            if (doc.Bookmarks.Exists("Functie"))
            {
                doc.Bookmarks["Functie"].Range.Text = PositionName;
            }
            if (doc.Bookmarks.Exists("Departament"))
            {
                doc.Bookmarks["Departament"].Range.Text = DepartmentName;
            }
            if (doc.Bookmarks.Exists("S_RON"))
            {
                doc.Bookmarks["S_RON"].Range.Text = Salary;
            }

            doc.Bookmarks["S_EUR"].Range.Text = (Int32.Parse(Salary)/4.59).ToString();

            doc.SaveAs2(savePath);
            app.Application.Quit();
            Response.Write("Success");
           
        }*/
    }
}