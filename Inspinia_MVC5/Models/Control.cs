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
    
    public partial class Control
    {
        public string N_Cotisant { get; set; }
        public System.DateTime D_Control { get; set; }
        public string C_User { get; set; }
        public string Observation { get; set; }
        public string Control1 { get; set; }
        public string Id_Agence { get; set; }
        public string Utilisateur { get; set; }
    
        public virtual Cotisant Cotisant { get; set; }
    }
}