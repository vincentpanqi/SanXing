﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SanXing.Data.Models
{
    using System;
    using System.Collections.Generic;
    using Mt.Core;
    using System.ComponentModel;

    [Description("联系人类型")]
    public partial class ContactType : BaseEntity
    {
        public ContactType()
        {
            this.Contact = new HashSet<Contact>();
            this.ChildCates = new HashSet<ContactType>();
        }

        public string CateName { get; set; }
        public int? PID { get; set; }
        public string Code { get; set; }
        public int Level { get; set; }
        public bool Deleted { get; set; }


        public virtual ContactType PCate { get; set; }
        public virtual ICollection<ContactType> ChildCates { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }

    }
}
