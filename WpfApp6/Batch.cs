//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Batch
    {
        public int codeBatch { get; set; }
        public int master { get; set; }
        public System.DateTime dateProduction { get; set; }
        public bool quality { get; set; }
        public decimal costForBatch { get; set; }
        public int count { get; set; }
        public int idToy { get; set; }
    
        public virtual Employer Employer { get; set; }
        public virtual Toy Toy { get; set; }
    }
}
