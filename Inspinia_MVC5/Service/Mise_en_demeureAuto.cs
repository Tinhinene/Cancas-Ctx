using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Inspinia_MVC5.ViewModels;
using Inspinia_MVC5.Models;

namespace Inspinia_MVC5.Service
{
    public class Mise_en_demeureAuto
    {

        private CacobatphEntities db = new CacobatphEntities();
       
        //Créance auto
        public IEnumerable<EcritFactViewModel> CalculeCreance()
        {

            //  IEnumerable<EcritFactViewModel> result = CalculeSelective();
            using (var context = new CacobatphEntities())
            {
                int mont = DateTime.Now.Month;
                String anneeMD = String.Empty;
                String moisMD = String.Empty;
                String trimMD = String.Empty;
                String perdideMaxMD = String.Empty;
                DateTime date = new DateTime(2010, 01, 01);
                var filtered = context.Ecrit_Fact.Where(x => x.Date_Op >= date && x.Solde > 2000);
                // var MD = context.Mise_Demeure.Where(x => x.D_Etab >= date);
                //var filtered = fact.Where(x => MD.Any(y => y.N_Cotisant == x.N_Cotisant));

                #region


                switch (mont)
                {
                    case 1:
                        anneeMD = (DateTime.Now.Year - 1).ToString();
                        moisMD = anneeMD + "11";
                        trimMD = anneeMD + "T1" + "," + anneeMD + "T2" + "," + anneeMD + "T3" + ',' + "999999";
                        string[] words = trimMD.Split(',');
                        var T1 = words[0].ToString();
                        var T2 = words[1].ToString();
                        var T3 = words[2].ToString();
                        var T4 = words[3].ToString();

                        return (from a in filtered

                                where
                               (a.C_Periode == T1.ToString() || a.C_Periode == T2.ToString() || a.C_Periode == T3.ToString() || a.C_Periode == T4.ToString()
                               || a.C_Periode == moisMD || a.C_Periode != moisMD)

                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();



                    case 2:

                        if ((DateTime.Now.Month == 2) ||
                            (DateTime.Now.Month == 3 && (DateTime.Now.Day == 1 || (DateTime.Now.Day == 2 && (DateTime.Now.Year % 4) == 0))))
                        {
                            anneeMD = (DateTime.Now.Year - 1).ToString();
                            moisMD = anneeMD + "T4";
                            return (from a in filtered

                                    where
                                     (a.C_Periode == moisMD || a.C_Periode != moisMD) || (a.C_Periode) == "999999"

                                    group a by new { NumCotisant = a.N_Cotisant } into g

                                    select new EcritFactViewModel
                                    {
                                        N_Cotisant = g.Key.NumCotisant,
                                        solde = g.Sum(p => p.Solde)
                                    }).ToList();


                        }



                        else
                        {
                            moisMD = anneeMD + "01";
                        }
                        break;



                    case 3:
                        if ((DateTime.Now.Month == 2) ||
                            (DateTime.Now.Month == 3 && DateTime.Now.Day == 1 || (DateTime.Now.Day == 2 && (DateTime.Now.Year % 4) == 0)))
                        {
                            anneeMD = (DateTime.Now.Year - 1).ToString();
                            moisMD = anneeMD + "T4";
                            return (from a in filtered

                                    where
                                     (a.C_Periode == moisMD || a.C_Periode != moisMD) || (a.C_Periode) == "999999"

                                    group a by new { NumCotisant = a.N_Cotisant } into g

                                    select new EcritFactViewModel
                                    {
                                        N_Cotisant = g.Key.NumCotisant,
                                        solde = g.Sum(p => p.Solde)
                                    }).ToList();
                        }
                        else
                        {
                            moisMD = anneeMD + "01";
                        }


                        break;


                    case 4:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "02";
                        return (from a in filtered

                                where
                                 (a.C_Periode == moisMD || a.C_Periode != moisMD) || (a.C_Periode) == "999999"

                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();




                    case 5:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();

                        return (from a in filtered

                                where int.Parse(a.C_Periode) <= int.Parse(moisMD) || a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2


                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();




                    case 6:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();

                        return (from a in filtered

                                where int.Parse(a.C_Periode) <= int.Parse(moisMD) || a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2


                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();

                    case 7:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();

                        return (from a in filtered

                                where int.Parse(a.C_Periode) <= int.Parse(moisMD) || a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2


                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();



                    case 8:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();


                        return (from a in filtered

                                where a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2 || a.C_Periode.ToString() == T3

                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();



                    case 9:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();


                        return (from a in filtered

                                where a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2 || a.C_Periode.ToString() == T3

                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();



                    case 10:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();


                        return (from a in filtered

                                where a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2 || a.C_Periode.ToString() == T3

                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();



                    case 11:
                        anneeMD = (DateTime.Now.Year).ToString();
                        if (DateTime.Now.Month == 11)
                        {
                            moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);

                        }

                        else
                        {

                            moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);

                        }


                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + anneeMD + "T3" + "," + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();
                        T4 = words[3].ToString();


                        //  var enc = context.Ecrit_Enc.Where(x => x.Date_Encaiss >= date && x.N_Cotisant == "06502578").ToList();

                        //aotu   var fact1 = context.Ecrit_Fact.Where(x => x.Solde >= 2000 && x.Date_Op >= new DateTime(2010, 01, 01));
                        //auto       var MD1 = context.Mise_Demeure_Detail.Where(x => x.Montant_Simul >= 0);
                        //auto            //   var filtered1 = fact1.Where(x => !MD1.Any(y => y.N_Cotisant == x.N_Cotisant && y.C_Periode == x.C_Periode && y.C_Nature == x.C_Nature)).ToList();



                        return (from a in filtered
                                    //  from c in enc
                                    //from b in MD
                                    // from k in context.Competences
                                where
                      //   ( (a.N_Cotisant).ToString().Substring(0,2).Contains(k.Indice.ToString()) &&
                      //     a.N_Cotisant != b.N_Cotisant &&
                      //! (b.N_Cotisant.ToString().Contains(a.N_Cotisant.ToString())) &&

                      // a.N_Cotisant != b.N_Cotisant &&
                      (a.C_Periode == T1.ToString() || a.C_Periode == T2.ToString() || a.C_Periode == T3.ToString() || a.C_Periode == T4.ToString()
                                 || a.C_Periode == moisMD || a.C_Periode != moisMD)
                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();


                    //var rr = from a in result
                    //         group a by new { a.N_Cotisant } into g
                    //         select new
                    //         {
                    //             solde = g.Sum(p => p.solde)
                    //         };
                    //var end = (
                    //            from a in result
                    //            where a.C_Periode == T1.ToString() || a.C_Periode == T2.ToString() || a.C_Periode == T3.ToString() || a.C_Periode == T4.ToString()
                    //              || Convert.ToInt32(a.C_Periode) <= Convert.ToInt32(moisMD)
                    //            group a by new { solde = a.solde, numCot = a.N_Cotisant } into g



                    //            select new EcritFactViewModel
                    //            {
                    //                N_Cotisant = g.Key.numCot,

                    //                solde = g.Sum(p => p.solde)


                    //            });






                    case 12:
                        anneeMD = (DateTime.Now.Year).ToString();
                        if (DateTime.Now.Month == 11)
                        {
                            moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);

                        }

                        else
                        {

                            moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);

                        }


                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + anneeMD + "T3" + "," + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();
                        T4 = words[3].ToString();

                        return (from a in filtered
                                where
                               (a.C_Periode == T1.ToString() || a.C_Periode == T2.ToString() || a.C_Periode == T3.ToString() || a.C_Periode == T4.ToString()
                                      || a.C_Periode == moisMD || a.C_Periode != moisMD)
                                group a by new { NumCotisant = a.N_Cotisant } into g

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = g.Key.NumCotisant,
                                    solde = g.Sum(p => p.Solde)
                                }).ToList();


                    default:

                        break;


                }
            }
            #endregion

            return null;
        }

        public IEnumerable<EcritFactViewModel> CalculeCreancePeriode(string numcotisant)
        {

            //  IEnumerable<EcritFactViewModel> result = CalculeSelective();
            using (var context = new CacobatphEntities())
            {
                int mont = DateTime.Now.Month;
                String anneeMD = String.Empty;
                String moisMD = String.Empty;
                String trimMD = String.Empty;
                String perdideMaxMD = String.Empty;
                DateTime date = new DateTime(2010, 01, 01);
                var fact = context.Ecrit_Fact.Where(x => x.Date_Op >= date && x.Solde > 2000 && x.N_Cotisant == numcotisant);
                var MD = context.Mise_Demeure.Where(x => x.D_Etab >= date);
                var filtered = fact.Where(x => MD.Any(y => y.N_Cotisant == x.N_Cotisant));

                #region


                switch (mont)
                {
                    case 1:
                        anneeMD = (DateTime.Now.Year - 1).ToString();
                        moisMD = anneeMD + "11";
                        trimMD = anneeMD + "T1" + "," + anneeMD + "T2" + "," + anneeMD + "T3" + ',' + "999999";
                        string[] words = trimMD.Split(',');
                        var T1 = words[0].ToString();
                        var T2 = words[1].ToString();
                        var T3 = words[2].ToString();
                        var T4 = words[3].ToString();

                        return (from a in filtered

                                where
                               (a.C_Periode == T1.ToString() || a.C_Periode == T2.ToString() || a.C_Periode == T3.ToString() || a.C_Periode == T4.ToString()
                               || a.C_Periode == moisMD || a.C_Periode != moisMD)



                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();



                    case 2:

                        if ((DateTime.Now.Month == 2) ||
                            (DateTime.Now.Month == 3 && (DateTime.Now.Day == 1 || (DateTime.Now.Day == 2 && (DateTime.Now.Year % 4) == 0))))
                        {
                            anneeMD = (DateTime.Now.Year - 1).ToString();
                            moisMD = anneeMD + "T4";
                            return (from a in filtered

                                    where
                                     (a.C_Periode == moisMD || a.C_Periode != moisMD) || (a.C_Periode) == "999999"

                                    select new EcritFactViewModel
                                    {
                                        N_Cotisant = a.N_Cotisant,
                                        C_Periode = a.C_Periode,
                                        Nature = a.C_Nature,
                                        solde = a.Solde
                                    }).ToList();


                        }



                        else
                        {
                            moisMD = anneeMD + "01";
                        }
                        break;



                    case 3:
                        if ((DateTime.Now.Month == 2) ||
                            (DateTime.Now.Month == 3 && DateTime.Now.Day == 1 || (DateTime.Now.Day == 2 && (DateTime.Now.Year % 4) == 0)))
                        {
                            anneeMD = (DateTime.Now.Year - 1).ToString();
                            moisMD = anneeMD + "T4";
                            return (from a in filtered

                                    where
                                     (a.C_Periode == moisMD || a.C_Periode != moisMD) || (a.C_Periode) == "999999"

                                    select new EcritFactViewModel
                                    {
                                        N_Cotisant = a.N_Cotisant,
                                        C_Periode = a.C_Periode,
                                        Nature = a.C_Nature,
                                        solde = a.Solde
                                    }).ToList();

                        }
                        else
                        {
                            moisMD = anneeMD + "01";
                        }


                        break;


                    case 4:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "02";
                        return (from a in filtered

                                where
                                 (a.C_Periode == moisMD || a.C_Periode != moisMD) || (a.C_Periode) == "999999"

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();





                    case 5:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();

                        return (from a in filtered

                                where int.Parse(a.C_Periode) <= int.Parse(moisMD) || a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2


                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();





                    case 6:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();

                        return (from a in filtered

                                where int.Parse(a.C_Periode) <= int.Parse(moisMD) || a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2


                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();


                    case 7:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();

                        return (from a in filtered

                                where int.Parse(a.C_Periode) <= int.Parse(moisMD) || a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2


                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();




                    case 8:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();


                        return (from a in filtered

                                where a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2 || a.C_Periode.ToString() == T3

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();




                    case 9:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();


                        return (from a in filtered

                                where a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2 || a.C_Periode.ToString() == T3

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();



                    case 10:
                        anneeMD = (DateTime.Now.Year).ToString();
                        moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);
                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();


                        return (from a in filtered

                                where a.C_Periode.ToString() == T1 || a.C_Periode.ToString() == T2 || a.C_Periode.ToString() == T3

                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();



                    case 11:
                        anneeMD = (DateTime.Now.Year).ToString();
                        if (DateTime.Now.Month == 11)
                        {
                            moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);

                        }

                        else
                        {

                            moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);

                        }


                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + anneeMD + "T3" + "," + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();
                        T4 = words[3].ToString();


                        //  var enc = context.Ecrit_Enc.Where(x => x.Date_Encaiss >= date && x.N_Cotisant == "06502578").ToList();

                        //aotu   var fact1 = context.Ecrit_Fact.Where(x => x.Solde >= 2000 && x.Date_Op >= new DateTime(2010, 01, 01));
                        //auto       var MD1 = context.Mise_Demeure_Detail.Where(x => x.Montant_Simul >= 0);
                        //auto            //   var filtered1 = fact1.Where(x => !MD1.Any(y => y.N_Cotisant == x.N_Cotisant && y.C_Periode == x.C_Periode && y.C_Nature == x.C_Nature)).ToList();



                        return (from a in filtered
                                    //  from c in enc
                                    //from b in MD
                                    // from k in context.Competences
                                where
                      //   ( (a.N_Cotisant).ToString().Substring(0,2).Contains(k.Indice.ToString()) &&
                      //     a.N_Cotisant != b.N_Cotisant &&
                      //! (b.N_Cotisant.ToString().Contains(a.N_Cotisant.ToString())) &&

                      // a.N_Cotisant != b.N_Cotisant &&
                      (a.C_Periode == T1.ToString() || a.C_Periode == T2.ToString() || a.C_Periode == T3.ToString() || a.C_Periode == T4.ToString()
                                 || a.C_Periode == moisMD || a.C_Periode != moisMD)
                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();


                    //var rr = from a in result
                    //         group a by new { a.N_Cotisant } into g
                    //         select new
                    //         {
                    //             solde = g.Sum(p => p.solde)
                    //         };
                    //var end = (
                    //            from a in result
                    //            where a.C_Periode == T1.ToString() || a.C_Periode == T2.ToString() || a.C_Periode == T3.ToString() || a.C_Periode == T4.ToString()
                    //              || Convert.ToInt32(a.C_Periode) <= Convert.ToInt32(moisMD)
                    //            group a by new { solde = a.solde, numCot = a.N_Cotisant } into g



                    //            select new EcritFactViewModel
                    //            {
                    //                N_Cotisant = g.Key.numCot,

                    //                solde = g.Sum(p => p.solde)


                    //            });






                    case 12:
                        anneeMD = (DateTime.Now.Year).ToString();
                        if (DateTime.Now.Month == 11)
                        {
                            moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);

                        }

                        else
                        {

                            moisMD = anneeMD + "0" + (DateTime.Now.Month - 2);

                        }


                        trimMD = anneeMD + "T1" + ',' + anneeMD + "T2" + ',' + anneeMD + "T3" + "," + "999999";
                        words = trimMD.Split(',');
                        T1 = words[0].ToString();
                        T2 = words[1].ToString();
                        T3 = words[2].ToString();
                        T4 = words[3].ToString();

                        return (from a in filtered
                                where
                               (a.C_Periode == T1.ToString() || a.C_Periode == T2.ToString() || a.C_Periode == T3.ToString() || a.C_Periode == T4.ToString()
                                      || a.C_Periode == moisMD || a.C_Periode != moisMD)
                                select new EcritFactViewModel
                                {
                                    N_Cotisant = a.N_Cotisant,
                                    C_Periode = a.C_Periode,
                                    Nature = a.C_Nature,
                                    solde = a.Solde
                                }).ToList();



                    default:

                        break;


                }
            }
            #endregion

            return null;
        }
        //Entéte des mise en demeure
        public List<Mise_Demeure> MiseEnDemeure(string numcotisant)
        {
            using (var context = new CacobatphEntities())
            {
                var Md = context.Mise_Demeure.Where(x => x.N_Cotisant == numcotisant).ToList();

                return Md;
            }
            return null;
        }
        //Lignes des mise en demeure
        public List<Mise_Demeure_Detail> LignesMD(int piece)
        {
            using (var context = new CacobatphEntities())
            {
                var pc = context.Mise_Demeure_Detail.Where(x => x.N_Piece == piece).ToList();

                return pc;
            }
            return null;
        }

        
        //Creation des MD pour cotisant
        public void AddMD(MiseEnDemeureViewModel entete, List<MiseEnDemeureDetailViewModel> lignes)
        {
            
                if (entete != null && lignes != null)
                {
                    using (var context = new CacobatphEntities())
                    {

                    MiseEnDemeureDetailViewModel detail = new MiseEnDemeureDetailViewModel();

                        if ( lignes.Count() != 0)
                      
                        {
                        foreach( MiseEnDemeureDetailViewModel element in lignes)
                        {
                            detail.N_Cotisant = element.N_Cotisant;
                            detail.N_Piece = element.N_Piece;
                            detail.C_Periode = element.C_Periode;
                            detail.C_Nature = element.C_Nature;
                            detail.Montant = element.Montant;
                            detail.Mt_Simul = element.Mt_Simul;
                            // detail.Code_User = element.Code_User;
                            detail.Id_Agence = getId_agence();




                        }


                    }
                    }

                }
           
            }




        public string getId_agence()
        {
            return db.Agences.SingleOrDefault().Id_Agence;



        }

    }
}