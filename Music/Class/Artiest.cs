﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public class Artiest
    {
       public void CreateArtist(string artiestennaam, string voornaam, string achternaam, string geboortedatum, string geboorteplaats, string geboorteland)
       {
                    try
            {
                SQLService sqlService = new SQLService();
                
                DateTime geb_dat;
                string format = "dd/MM/yyyy";
                
                if (!DateTime.TryParseExact(geboortedatum, format, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out geb_dat))
                {
                    throw new FormatException("Dit is geen geldige datum: dd/mm/yyyy");
                } 
         
                if (artiestennaam == "" || voornaam == "" || achternaam == "" || geboorteplaats == "")
                {
                    throw new NullReferenceException("Alle velden moeten worden ingevult.");
                }
                    sqlService.Insert("INSERT INTO artiest (artiest_naam,voornaam,achternaam,geb_datum,geb_plaats, geb_land) VALUES ('" + artiestennaam + "','" +
                                      voornaam + "','" + achternaam + "','" + geb_dat + "',  '" + geboorteplaats + "',  '" + geboorteland + "')");
            }

            catch (NullReferenceException obj)
            {
                MessageBox.Show(obj.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (FormatException obj)
            {
                MessageBox.Show(obj.Message);
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
       public int GetArtiestId(string combo)
       {
           SQLService sqlService = new SQLService();
           int artiestid =
               Convert.ToInt32(
                   sqlService.ReturnFirstValue(
                       "SELECT artiest_id FROM artiest WHERE (artiest_naam = '" +
                       combo + "')"));
           return artiestid;
       }
    }
}
