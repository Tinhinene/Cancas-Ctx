//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspinia_MVC5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partiellement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partiellement()
        {
            this.PvHistoriques = new HashSet<PvHistorique>();
            this.PvInfractions = new HashSet<PvInfraction>();
            this.PvInfractionPieces = new HashSet<PvInfractionPiece>();
        }
    
        public int ID { get; set; }
        public string MotifsThird { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PvHistorique> PvHistoriques { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PvInfraction> PvInfractions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PvInfractionPiece> PvInfractionPieces { get; set; }
    }
}
