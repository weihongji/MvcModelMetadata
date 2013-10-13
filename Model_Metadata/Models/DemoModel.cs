using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Model_Metadata.Models
{
    public class DemoModel
    {
        public string Foo { get; set; }

        [UIHint("Template A")]
        [UIHint("Template B", "Mvc")]
        public string Bar { get; set; }

        [UIHint("Template A")]
        [UIHint("Template B")]
        public string Baz { get; set; }
    }
}