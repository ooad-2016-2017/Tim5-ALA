using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frms.Views;
using System.Text.RegularExpressions;
using Windows.UI.Xaml.Controls;

namespace frms.Helper
{
    public static class FormDataValidator
    {

        public static bool ValidacijaSale(String brMjesta, String brRacunara )
        {
            return true;
        }
       
        public static Boolean validacijaKorisnika(String ime, String prezime)
        {
            if (ime == null) return false;
            if (prezime == null) return false;

            if (Regex.IsMatch(ime, @"^[a-zA-Z]+$") && Regex.IsMatch(prezime, @"^[a-zA-Z]+$"))
                return true;
            return false;          
        }

        public static bool KarticaAdmin(String val)
        {
            return val == "0009912295";
        }

        public static bool KarticaRegular(String val)
        {
            return val == "0009910712";
        }

       

       
    }
}
