//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Type_obr
    {
        public Type_obr()
        {
            this.Set_Obr = new HashSet<Set_Obr>();
        }
    
        public int id { get; set; }
        public string nazv { get; set; }
    
        public virtual ICollection<Set_Obr> Set_Obr { get; set; }
    }
}
