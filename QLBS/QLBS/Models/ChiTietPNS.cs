//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPNS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietPNS()
        {
            this.PhieuNhap = new HashSet<PhieuNhap>();
        }
    
        public string SoCTPNS { get; set; }
        public int SoLuongNhapS { get; set; }
        public decimal GiaNhapS { get; set; }
        public string MaSach { get; set; }
    
        public virtual Sach Sach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhap { get; set; }
    }
}