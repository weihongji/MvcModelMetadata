using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Model_Metadata.Models
{
    public class DemoModel02
    {
        [DataType(DataType.EmailAddress)]
        public string Foo { get; set; }

        [DataType("Barcode")]
        public string Bar { get; set; }

        public string Baz { get; set; }

        [DisplayFormat(HtmlEncode = false)]
        public string Qux { get; set; }
    }
}