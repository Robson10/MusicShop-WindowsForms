//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zamowienia
    {
        public Zamowienia()
        {
            this.ListaTowarow = new HashSet<ListaTowarow>();
        }
    
        public int Za_ID { get; set; }
        public int Pr_ID { get; set; }
        public int Kl_ID { get; set; }
        public System.DateTime Za_NaKiedy { get; set; }
        public System.DateTime Za_KiedyKupione { get; set; }
        public bool Za_CzyZrealizowano { get; set; }
    
        public virtual Klienci Klienci { get; set; }
        public virtual ICollection<ListaTowarow> ListaTowarow { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
    }
}