//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFArenda.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zayavka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zayavka()
        {
            this.Contract = new HashSet<Contract>();
        }
    
        public int ID_Zayavka { get; set; }
        public Nullable<int> ID_Object { get; set; }
        public Nullable<int> ID_User { get; set; }
        public string Message { get; set; }
        public Nullable<int> ID_Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual Object Object { get; set; }
        public virtual Status_Zayavka Status_Zayavka { get; set; }
        public virtual User User { get; set; }
    }
}
