//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModeloBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Solicitudes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solicitudes()
        {
            this.OrdenesCompra = new HashSet<OrdenesCompra>();
        }
    
        public int Id_Solicitud { get; set; }
        public Nullable<int> Id_Usuario { get; set; }
        public Nullable<int> Id_Compra { get; set; }
        public System.DateTime Fecha_Solicitud { get; set; }
        public string Jefe_Aprovado { get; set; }
        public Nullable<System.DateTime> Fecha_Jefe_Apro { get; set; }
        public string Gerencia_Aprovado { get; set; }
        public Nullable<System.DateTime> Fecha_Gerencia_Apro { get; set; }
    
        public virtual Compras Compras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenesCompra> OrdenesCompra { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
