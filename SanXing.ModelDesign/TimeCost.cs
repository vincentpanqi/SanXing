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
    
    public partial class TimeCost
    {
        public int ID { get; set; }
        public string Hour { get; set; }
        public int TimeCostTypeID { get; set; }
        public int UserID { get; set; }
    
        public virtual TimeCostType TimeCostType { get; set; }
        public virtual User User { get; set; }
    }
}
