﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model_Metadata.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ListAttribute : Attribute, IMetadataAware
    {
        public string ListName { get; private set; }

        public ListAttribute(string listName) {
            this.ListName = listName;
        }

        public virtual void OnMetadataCreated(ModelMetadata metadata) {
            metadata.AdditionalValues.Add("ListName", this.ListName);
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class DropDownListAttribute : ListAttribute
    {
        public DropDownListAttribute(string listName)
            : base(listName) {
        }

        public override void OnMetadataCreated(ModelMetadata metadata) {
            base.OnMetadataCreated(metadata);
            metadata.TemplateHint = "DropDownList";
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ListBoxAttribute : ListAttribute
    {
        public ListBoxAttribute(string listName)
            : base(listName) {
        }

        public override void OnMetadataCreated(ModelMetadata metadata) {
            base.OnMetadataCreated(metadata);
            metadata.TemplateHint = "ListBox";
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class RadioButtonListAttribute : ListAttribute
    {
        public RadioButtonListAttribute(string listName)
            : base(listName) {
        }

        public override void OnMetadataCreated(ModelMetadata metadata) {
            base.OnMetadataCreated(metadata);
            metadata.TemplateHint = "RadioButtonList";
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class CheckBoxListAttribute : ListAttribute
    {
        public CheckBoxListAttribute(string listName)
            : base(listName) {
        }

        public override void OnMetadataCreated(ModelMetadata metadata) {
            base.OnMetadataCreated(metadata);
            metadata.TemplateHint = "CheckBoxList";
        }
    }
}