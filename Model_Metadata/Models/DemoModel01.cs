using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Model_Metadata.Models
{
    public class DemoModel01
    {
        [HiddenInput]
        public string Foo { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string Bar { get; set; }

        public string Baz { get; set; }
    }
}