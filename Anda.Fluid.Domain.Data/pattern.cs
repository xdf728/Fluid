//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anda.Fluid.Domain.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class pattern
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pattern()
        {
            this.patternsetting = new HashSet<patternsetting>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> RunMode { get; set; }
        public string LotNum { get; set; }
        public string Operator { get; set; }
        public string Barcode { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> Result { get; set; }
        public Nullable<double> Mark1X { get; set; }
        public Nullable<double> Mark1Y { get; set; }
        public Nullable<double> Mark2X { get; set; }
        public Nullable<double> Mark2Y { get; set; }
        public Nullable<double> Height { get; set; }
        public int WorkpieceId { get; set; }
    
        public virtual workpiece workpiece { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patternsetting> patternsetting { get; set; }
    }
}
