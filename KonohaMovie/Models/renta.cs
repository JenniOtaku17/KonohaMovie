//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KonohaMovie.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class renta
    {
        public int id { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public string estado { get; set; }
        public Nullable<int> id_movie { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> id_admin { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual movie movie { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
