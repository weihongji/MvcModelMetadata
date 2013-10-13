using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Model_Metadata.Models;

namespace Model_Metadata.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            var model = new ModelMetadataInfo(typeof(DemoModel), x => x.TemplateHint);
            return View(model);
        }

        public ActionResult Index01() {
            var model = new DemoModel01() { Foo = "Foo01", Bar = "Bar01", Baz = "Baz01" };
            return View(model);
        }

        public ActionResult Index02() {
            var model = new ModelMetadataInfo(typeof(DemoModel02), x => x.DataTypeName);
            return View("Index", model);
        }

        public ActionResult Index03() {
            var model = new DemoModel03() {
                Foo = "Foo03",
                Bar = "Bar03",
                Baz = DateTime.Today,
                ObjectArray = new object[] {1.234, "Dummy text ...", true}
            };
            return View(model);
        }

        public ActionResult Index04() {
            var model = new Employee() {
                Name = "张三",
                Gender = "M", //Male
                Education = "M", //Master
                Departments = new string[] {"HR", "AD"},
                Skills = new string[] { "CSharp", "AdoNet" }
            };
            return View(model);
        }

    }
}
