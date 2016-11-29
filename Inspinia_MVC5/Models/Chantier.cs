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
    
    public partial class Chantier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chantier()
        {
            this.Convocations = new HashSet<Convocation>();
            this.FicheVisites = new HashSet<FicheVisite>();
            this.PvInfractions = new HashSet<PvInfraction>();
            this.RapportVisites = new HashSet<RapportVisite>();
            this.RapportVisiteRas = new HashSet<RapportVisiteRa>();
        }
    
        public string Id_Agence { get; set; }
        public int Id_CotisantNonAff { get; set; }
        public int N_OrdreCh { get; set; }
        public string N_Cotisant { get; set; }
        public string NatureTravauxCh { get; set; }
        public string MaitreOuvrageCh { get; set; }
        public string AdresseCh { get; set; }
        public System.DateTime DateDebutCh { get; set; }
        public string EtatDeControleCh { get; set; }
        public string N_PV_Ch { get; set; }
        public string DelaiCh { get; set; }
        public Nullable<System.DateTime> ModifierLe { get; set; }
        public string ModifierPar { get; set; }
        public string CodeUserCh { get; set; }
        public string Etat { get; set; }
        public string Wilaya_ { get; set; }
        public string CodeGeo { get; set; }
        public string AdresseChantierArabe { get; set; }
    
        public virtual Cotisant Cotisant { get; set; }
        public virtual CotisantNonAff CotisantNonAff { get; set; }
        public virtual Wilaya Wilaya { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Convocation> Convocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FicheVisite> FicheVisites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PvInfraction> PvInfractions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RapportVisite> RapportVisites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RapportVisiteRa> RapportVisiteRas { get; set; }
    }
}