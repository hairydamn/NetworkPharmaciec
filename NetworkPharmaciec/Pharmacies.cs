//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetworkPharmaciec
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pharmacies
    {
        public int ID { get; set; }
        public string TitlePharm { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Hours { get; set; }
    
        public virtual Avail Avail { get; set; }
        public virtual Pharmacies Pharmacies1 { get; set; }
        public virtual Pharmacies Pharmacies2 { get; set; }
    }
}
