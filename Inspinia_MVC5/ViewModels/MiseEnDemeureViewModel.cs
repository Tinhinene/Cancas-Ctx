using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspinia_MVC5.ViewModels
{
    public class MiseEnDemeureViewModel
    {
       

            public string N_Cotisant { get; set; }

            public int N_Piece { get; set; }

            public DateTime D_Etab { get; set; }

            public decimal Mt_Du { get; set; }

            public decimal Mt_Simul { get; set; }

            public string Etat { get; set; }

            public string Observ { get; set; }

            public DateTime? D_Accus { get; set; }

            public string T_Accus { get; set; }


            public string Code_User { get; set; }


            public string Id_Agence { get; set; }



        }

    


   
}