using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Prac1.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult studentView()
        {

            List<Models.StudentModel> student = new List<Models.StudentModel>();
            student.Add(new Models.StudentModel { StudentNumber = "24623815", Name = "Kamohelo", Surname = "Nkomo", Email = "u24623815@tuks.co.za", myLink="~/HTML/Kamohelo.html"});
            student.Add(new Models.StudentModel { StudentNumber = "24579280", Name = "Arielle", Surname = "Tshiswaka", Email = "u2479280@tuks.co.za" , myLink="~/HTML/Arielle.html"});
            student.Add(new Models.StudentModel { StudentNumber = "21233815", Name = "Lynn", Surname = "Ngara", Email = "u21233815@tuks.co.za" , myLink="~/HTML/Lynn.html"});
            student.Add(new Models.StudentModel { StudentNumber = "24623246", Name = "Pietru", Surname = "Brown", Email = "u246238246@tuks.co.za", myLink="~/HTML/Pietrus.html" });
            student.Add(new Models.StudentModel { StudentNumber = "23623819", Name = "Koketso", Surname = "Kobese", Email = "u23623819@tuks.co.za" , myLink="~/HTML/Koketso.html"});
            return View(student);
        }
    }
}