//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Reservas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_asiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_asiento()
        {
            this.Tb_vuelo = new HashSet<Tb_vuelo>();
        }
    
        public int idAsiento { get; set; }
        public string tipo { get; set; }
        public string fila { get; set; }
        public string letra { get; set; }
        public decimal precio { get; set; }
        public Nullable<System.DateTime> F_Registro { get; set; }
        public Nullable<System.DateTime> F_Modificacion { get; set; }
        public Nullable<int> estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_vuelo> Tb_vuelo { get; set; }
    }
}
