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
    
    public partial class Pracownicy
    {
        public Pracownicy()
        {
            this.Zamowienia = new HashSet<Zamowienia>();
        }
    
        public int Pr_ID { get; set; }
        public string Pr_Imie { get; set; }
        public string Pr_Nazwisko { get; set; }
        public string Pr_AdresPracy { get; set; }
    
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
    }
}
