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
    
    public partial class Reviews
    {
        public int ID_Review { get; set; }
        public Nullable<int> ID_Object { get; set; }
        public Nullable<int> ID_User { get; set; }
        public Nullable<int> Rating { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual Object Object { get; set; }
        public virtual User User { get; set; }
    }
}
