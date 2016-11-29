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
    
    public partial class Cotisant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cotisant()
        {
            this.Affiliations = new HashSet<Affiliation>();
            this.Chantiers = new HashSet<Chantier>();
            this.Contentieux = new HashSet<Contentieu>();
            this.Contraintes = new HashSet<Contrainte>();
            this.Controls = new HashSet<Control>();
            this.Cot_Classe = new HashSet<Cot_Classe>();
            this.Cotisant_Account = new HashSet<Cotisant_Account>();
            this.Cotisant_History = new HashSet<Cotisant_History>();
            this.Declarats = new HashSet<Declarat>();
            this.Ecrit_Enc = new HashSet<Ecrit_Enc>();
            this.Ecrit_Fact = new HashSet<Ecrit_Fact>();
            this.Encaisses = new HashSet<Encaiss>();
            this.Ent_Fact = new HashSet<Ent_Fact>();
            this.ENTREPRISEs = new HashSet<ENTREPRISE>();
            this.Exploitations = new HashSet<Exploitation>();
            this.Ligne_Fact = new HashSet<Ligne_Fact>();
            this.Main_Levee = new HashSet<Main_Levee>();
            this.Mise_Demeure = new HashSet<Mise_Demeure>();
            this.Mise_Demeure_Detail = new HashSet<Mise_Demeure_Detail>();
            this.Mise_Jour = new HashSet<Mise_Jour>();
            this.Notif_Contrainte = new HashSet<Notif_Contrainte>();
            this.Oppositions = new HashSet<Opposition>();
            this.Opposition_Detail = new HashSet<Opposition_Detail>();
            this.Positions = new HashSet<Position>();
            this.Proc_Penale = new HashSet<Proc_Penale>();
            this.PvInfractions = new HashSet<PvInfraction>();
            this.RapportVisites = new HashSet<RapportVisite>();
            this.Reglement_Chq = new HashSet<Reglement_Chq>();
        }
    
        public string Numero { get; set; }
        public string Rais_Soc_Fr { get; set; }
        public string Nom_Comm_Fr { get; set; }
        public string Adresse_Fr { get; set; }
        public string Ville_Fr { get; set; }
        public string C_Nap { get; set; }
        public string C_Nation { get; set; }
        public string Rais_Soc_Ar { get; set; }
        public string Nom_Comm_Ar { get; set; }
        public string Adresse_Ar { get; set; }
        public string Ville_Ar { get; set; }
        public string N_Teleph { get; set; }
        public string N_Telex { get; set; }
        public string N_Fax { get; set; }
        public string E_Mail { get; set; }
        public string N_Cpt { get; set; }
        public string C_Banque { get; set; }
        public string C_Ag_Banq { get; set; }
        public string N_Reg_Comm { get; set; }
        public Nullable<System.DateTime> D_Delivre { get; set; }
        public string N_Fiscal { get; set; }
        public Nullable<System.DateTime> D_Depot_Dos { get; set; }
        public System.DateTime D_Debut_Act { get; set; }
        public Nullable<System.DateTime> D_Recrut { get; set; }
        public int Effect_P { get; set; }
        public Nullable<int> Effect_CP { get; set; }
        public Nullable<int> Effect_CI { get; set; }
        public string Der_Periode { get; set; }
        public bool Exonere_MR { get; set; }
        public bool Exonere_PR { get; set; }
        public string Classe { get; set; }
        public string Position { get; set; }
        public string C_Postal { get; set; }
        public string C_Geogr { get; set; }
        public string C_Statut { get; set; }
        public Nullable<System.DateTime> D_Creat { get; set; }
        public string Code_User { get; set; }
        public string Sous_Control { get; set; }
        public string Sous_Content { get; set; }
        public string Id_Agence { get; set; }
        public string Sous_Exploit { get; set; }
        public string Num_Caco { get; set; }
        public string Wil_Chantier { get; set; }
        public short Wil_Seq { get; set; }
        public byte Type { get; set; }
        public short Wil_Deliv_Reg { get; set; }
        public string B { get; set; }
        public string TP { get; set; }
        public string Hyd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Affiliation> Affiliations { get; set; }
        public virtual Agence_Banq Agence_Banq { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chantier> Chantiers { get; set; }
        public virtual Classe Classe1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contentieu> Contentieux { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrainte> Contraintes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control> Controls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cot_Classe> Cot_Classe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotisant_Account> Cotisant_Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotisant_History> Cotisant_History { get; set; }
        public virtual Nap Nap { get; set; }
        public virtual Nationalite Nationalite { get; set; }
        public virtual Statut Statut { get; set; }
        public virtual TabGeogr TabGeogr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Declarat> Declarats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ecrit_Enc> Ecrit_Enc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ecrit_Fact> Ecrit_Fact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Encaiss> Encaisses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ent_Fact> Ent_Fact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTREPRISE> ENTREPRISEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exploitation> Exploitations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ligne_Fact> Ligne_Fact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Main_Levee> Main_Levee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mise_Demeure> Mise_Demeure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mise_Demeure_Detail> Mise_Demeure_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mise_Jour> Mise_Jour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notif_Contrainte> Notif_Contrainte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opposition> Oppositions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opposition_Detail> Opposition_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Position> Positions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proc_Penale> Proc_Penale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PvInfraction> PvInfractions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RapportVisite> RapportVisites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reglement_Chq> Reglement_Chq { get; set; }
    }
}