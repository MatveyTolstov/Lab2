//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab1Kokoro
{
    using System;
    using System.Collections.Generic;
    
    public partial class EVENTS_CLIENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVENTS_CLIENTS()
        {
            this.TABLEBOOKING = new HashSet<TABLEBOOKING>();
        }
    
        public int ID_EVENTS_CLIENTS { get; set; }
        public string EVENT_NAME { get; set; }
        public Nullable<System.DateTime> EVENT_DATE { get; set; }
        public string EVENT_DESCRIPTION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABLEBOOKING> TABLEBOOKING { get; set; }
    }
}
