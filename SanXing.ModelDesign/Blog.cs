//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SanXing.ModelDesign
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Sentiment { get; set; }
        public string CreateTime { get; set; }
        public string LastTime { get; set; }
        public int SublimeTypeID { get; set; }
        public int UserID { get; set; }
        public string Url { get; set; }
    
        public virtual BlogType SublimeType { get; set; }
        public virtual User User { get; set; }
    }
}
