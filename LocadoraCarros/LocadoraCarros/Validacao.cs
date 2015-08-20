using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public static class Validacao {

        public static bool ValidarTelefone(this string telefone) {

            string regextelefone = @"^\(\d{2}\)\d{4}-\d{4}$";

            if (Regex.IsMatch(telefone, regextelefone)) {
                return true;
            }
            else {
                return false;
            }

        }

        public static bool ValidarBrankSpace(this string espaco) {
            if (espaco.Equals("") || espaco == null) {
                return false;
            }else{
                return true;
            }
        }
    }
}
