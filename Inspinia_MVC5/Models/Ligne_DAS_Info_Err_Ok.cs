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
    
    public partial class Ligne_DAS_Info_Err_Ok
    {
        public string Annee_DAS { get; set; }
        public string Empl_DAS { get; set; }
        public int N_Ordre { get; set; }
        public string Salarie_DAS { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string Sit_Fam { get; set; }
        public string Date_Naiss { get; set; }
        public string Lieu_Naiss { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string C_Postal { get; set; }
        public string Presume { get; set; }
        public string Etranger { get; set; }
        public string N_Compte_CCP { get; set; }
        public string N_Compte_Banque { get; set; }
        public string Banque { get; set; }
        public string Agence_Banque { get; set; }
        public string Profession { get; set; }
        public string Sal_Annuel { get; set; }
        public string Nbj_Travail { get; set; }
        public string Type_Nbj_Travail { get; set; }
        public string Date_E_S { get; set; }
        public string Type_E_S { get; set; }
        public string Code_User { get; set; }
        public string Id_Agence { get; set; }
        public string CinNumber { get; set; }
        public string IdNat { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    
        public virtual Annee_CP Annee_CP { get; set; }
    }
}