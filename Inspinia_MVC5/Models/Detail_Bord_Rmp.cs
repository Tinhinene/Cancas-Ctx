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
    
    public partial class Detail_Bord_Rmp
    {
        public int N_Ordre { get; set; }
        public int N_Bord { get; set; }
        public Nullable<int> Annee { get; set; }
        public System.DateTime Date_Recep { get; set; }
        public string NSS { get; set; }
        public Nullable<int> NDec { get; set; }
        public string NEmployeur { get; set; }
        public string Nom_Latin { get; set; }
        public string Prenom_Latin { get; set; }
        public decimal Net { get; set; }
        public string Motif_Retour { get; set; }
        public string N_Emiss { get; set; }
        public string Adresse { get; set; }
        public string Type_Paie { get; set; }
        public string Mode_Paie { get; set; }
        public string Observ { get; set; }
        public string Code_User { get; set; }
        public Nullable<System.DateTime> C_Session { get; set; }
        public Nullable<System.DateTime> Date_Reimput { get; set; }
        public string NSS_Rmp { get; set; }
        public string NLatin_Rmp { get; set; }
        public string NPrenom_Rmp { get; set; }
        public string NCompte_Rmp { get; set; }
        public string NAdresse_Rmp { get; set; }
        public string Etat { get; set; }
        public string Id_Agence { get; set; }
    }
}