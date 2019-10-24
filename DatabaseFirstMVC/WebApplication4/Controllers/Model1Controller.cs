using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class Model1Controller : Controller
    {
        DB_09_10Entities db = new DB_09_10Entities();
        // GET: Model1
        public ActionResult DisplayDonors()
        {

            var l = db.tblDonors.Where(x => x.City == "Mumbai").ToList();
            //var l = from d in db.tblDonors
            //         where d.City == "Mumbai"
            //         select d;
            return View(l);
        }

    }
}