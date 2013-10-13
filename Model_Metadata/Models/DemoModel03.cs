using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Model_Metadata.Models
{
    public class DemoModel03
    {
        [Display(Name = "FooName", Prompt = "This is foo.")]
        public string Foo { get; set; }

        [DisplayName("Bar's Name")]
        public string Bar { get; set; }

        [DataType(DataType.Date)]
        public DateTime Baz { get; set; }

        [UIHint("Collection")]
        public object[] ObjectArray { get; set; }
    }
}