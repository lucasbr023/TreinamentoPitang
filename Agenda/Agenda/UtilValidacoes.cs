using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Agenda {
    public static class UtilValidacoes {

        public static bool ValidarTelefone(this string telefone) {

            string regextelefone = @"^\(\d{2}\)\d{4}-\d{4}$";

            if (Regex.IsMatch(telefone, regextelefone)) {
                return true;
            }
            else {
                return false;
            }


        }

        public static bool ValidarPosicao(this string posicao) {

            if (posicao.Length == 2 && posicao.All(char.IsDigit)) {
                return true;
            }
            else {
                return false;
            }
           

        }
    }
}
