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
    
    public partial class RapportHistorique
    {
        public int Id { get; set; }
        public string N_Rapport { get; set; }
        public System.DateTime DateRapport { get; set; }
        public string N_cotisant { get; set; }
        public int Id_CotisantNonAff { get; set; }
        public int N_OrdreCh { get; set; }
        public System.DateTime DatePv { get; set; }
        public string Id_Agence { get; set; }
        public string Adresse { get; set; }
        public string NomEntreprise { get; set; }
        public string NatureRepresentant { get; set; }
        public string NomRepresentant { get; set; }
        public Nullable<System.DateTime> DateEffDebutActivite { get; set; }
        public Nullable<double> MontantTotalPenalite { get; set; }
        public string DateDebutPriodes { get; set; }
        public string DateFinPriodes { get; set; }
        public Nullable<int> EffectifTravailleursNonDeclaresTtPeriodeConfondues { get; set; }
        public Nullable<double> MasseSalarileTotaleNonDeclare { get; set; }
        public Nullable<double> CotisantionsPrincipalesTotalesNonVersees { get; set; }
        public Nullable<double> MajorationsDeRetardArretees { get; set; }
        public Nullable<double> S_MajorationsDeRetardArretees { get; set; }
        public Nullable<int> NombreSalariersSousDeclares { get; set; }
        public Nullable<double> MasseSalarialeComplementaireNonDeclareeDE { get; set; }
        public Nullable<System.DateTime> ComagnesDesCongéPayes { get; set; }
        public Nullable<int> EffectifsTravailleursNonDeclares { get; set; }
        public Nullable<System.DateTime> DateReelleArretDeChantier { get; set; }
        public Nullable<System.DateTime> DateDeclarerArretDeChantier { get; set; }
        public string DureeReelleArretChantier { get; set; }
        public string DureeDeclarerArretChantier { get; set; }
        public Nullable<System.DateTime> DateReellRepriseDeChantier { get; set; }
        public Nullable<System.DateTime> DateDeclarerlRepriseDeChantier { get; set; }
        public Nullable<int> EffectifReelConcerner { get; set; }
        public Nullable<int> EffectifDeclarerConcerner { get; set; }
        public Nullable<double> MontantIndemniser { get; set; }
        public Nullable<double> MontantReel { get; set; }
        public Nullable<double> MontantRembourserParEntreprise { get; set; }
        public Nullable<bool> RefusAccesAuChantier { get; set; }
        public Nullable<bool> ControleNonEffectuerPar { get; set; }
        public Nullable<bool> IntimidationParForce { get; set; }
        public Nullable<bool> RefusDePresentationDesDocumentsRelatifsAlaGestionPersonnel { get; set; }
        public Nullable<bool> RefusDeControlerLesTravailleursPresentsSurChantier { get; set; }
        public Nullable<double> CotisantionsPrincipalesNonVerseesDe { get; set; }
        public Nullable<bool> DefautDeclarationActivite { get; set; }
        public Nullable<bool> DefautPaiementdesCotisants { get; set; }
        public Nullable<bool> SalriersSousDeclares { get; set; }
        public Nullable<bool> FausseDeclarationSurLesPriodesEtLesEffectifsEnChomageIntemperie { get; set; }
        public string Agence { get; set; }
        public string AdresseAgence { get; set; }
        public string TelephoneAgence { get; set; }
        public Nullable<System.DateTime> ModifierLe { get; set; }
        public string ModifierPar { get; set; }
        public string AdresseAgenceA { get; set; }
        public string AdresseChantierArabe { get; set; }
        public string NomSocArabe { get; set; }
        public string NomPrenomControleurAr { get; set; }
        public string Agencear { get; set; }
        public string NatureRepresentantAr { get; set; }
        public string NomRepresentantAR { get; set; }
        public string Commentaire { get; set; }
        public string Commentairear { get; set; }
        public string Codeuser { get; set; }
    }
}
