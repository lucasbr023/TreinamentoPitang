using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda {
    public static class UtilValidacoes {

        public static bool ValidarTelefone(this string telefone) {

            if (telefone.All(char.IsDigit) || telefone.Equals("-") || telefone.Equals(" ") || telefone.Equals("(") || telefone.Equals(")") || telefone.Equals("+")) {
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
