using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Model_Metadata.Models
{
    public class Employee
    {
        [DisplayName("姓名")]
        public string Name { get; set; }

        [RadioButtonList("Gender")]
        [DisplayName("性别")]
        public string Gender { get; set; }

        [DropDownList("Education")]
        [DisplayName("学历")]
        public string Education { get; set; }

        [ListBox("Department")]
        [DisplayName("所在部门")]
        public IEnumerable<string> Departments { get; set; }

        [CheckBoxList("Skill")]
        [DisplayName("擅长技能")]
        public IEnumerable<string> Skills { get; set; }
    }


    public class ListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }

    public interface IListProvider
    {
        IEnumerable<ListItem> GetListItems(string listName);
    }

    public class DefaultListProvider : IListProvider
    {
        private static Dictionary<string, IEnumerable<ListItem>> listItems = new Dictionary<string, IEnumerable<ListItem>>();

        static DefaultListProvider() {
            var items = new ListItem[] {
                new ListItem {Text = "男", Value = "M"},
                new ListItem {Text = "女", Value = "F"}
            };
            listItems.Add("Gender", items);

            items = new ListItem[] {
                new ListItem {Text = "高中", Value = "H"},
                new ListItem {Text = "大学本科", Value = "B"},
                new ListItem {Text = "硕士", Value = "M"},
                new ListItem {Text = "博士", Value = "D"}
            };
            listItems.Add("Education", items);

            items = new ListItem[] {
                new ListItem {Text = "人事部", Value = "HR"},
                new ListItem {Text = "行政部", Value = "AD"},
                new ListItem {Text = "IT部", Value = "IT"}
            };
            listItems.Add("Department", items);

            items = new ListItem[] {
                new ListItem {Text = "C#", Value = "CSharp"},
                new ListItem {Text = "ASP.NET", Value = "AspNet"},
                new ListItem {Text = "ADO.NET", Value = "AdoNet"}
            };
            listItems.Add("Skill", items);
        }

        public IEnumerable<ListItem> GetListItems(string listName) {
            IEnumerable<ListItem> items;
            if (listItems.TryGetValue(listName, out items)) {
                return items;
            }
            return new ListItem[0];
        }
    }

    public class ListProviders
    {
        public static IListProvider Current { get; set; }

        static ListProviders() {
            Current = new DefaultListProvider();
        }

        public static void SetListProvider(Func<IListProvider> providerAccessor) {
            Current = providerAccessor();
        }
    }
}