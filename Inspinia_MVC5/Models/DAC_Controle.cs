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
    
    public partial class DAC_Controle
    {
        public int N_DAC { get; set; }
        public int N_Encaiss { get; set; }
        public string N_Cotisant { get; set; }
        public string C_Periode { get; set; }
        public string C_Operation { get; set; }
        public System.DateTime Date_Op { get; set; }
        public string Libelle { get; set; }
        public string C_Nature { get; set; }
        public string Etat { get; set; }
        public string Type_Cotis { get; set; }
        public decimal Assiette { get; set; }
        public float Taux { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public int Nb_SalarieCp { get; set; }
        public decimal Solde { get; set; }
        public decimal Mont_Vent { get; set; }
        public string Id_Agence { get; set; }
        public string Utilisateur { get; set; }
        public Nullable<int> Nb_SalarieCi { get; set; }
    }
}
