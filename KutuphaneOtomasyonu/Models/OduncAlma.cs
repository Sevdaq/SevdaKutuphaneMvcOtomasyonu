//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyonu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OduncAlma
    {
        public int oduncID { get; set; }
        public int uyeID { get; set; }
        public int kitapID { get; set; }
        public System.DateTime oduncAlmaTarihi { get; set; }
        public System.DateTime oduncTeslimTarihi { get; set; }
        public int gecikmeSuresi { get; set; }
        public decimal cezaBedeli { get; set; }
    
        public virtual Kitap Kitap { get; set; }
        public virtual Uye Uye { get; set; }
    }
}
