using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public static class Validacao {

        public static bool ValidarCPF(this string documento) {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;
            int soma;
            int resto;

            documento = documento.Trim();
            documento = documento.Replace(".", "").Replace("-", "");


            if (documento.Length != 11) {
                return false;
            }

            tempCpf = documento.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return documento.EndsWith(digito);

        }

        public static bool ValidarCNPJ(this string documento) {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };


            int soma;
            int resto;
            string digito;
            string tempCnpj;

            documento = documento.Trim();
            documento = documento.Replace(".", "").Replace("-", "").Replace("/", "");


            if (documento.Length != 14)
                return false;
            tempCnpj = documento.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();

            return documento.EndsWith(digito);
        }

        public static bool ValidarTelefone(this string telefone) {

            string regextelefone = @"^\(\d{2}\)\d{4}-\d{4}$";

            if (Regex.IsMatch(telefone, regextelefone)) {
                return true;
            }
            else {
                return false;
            }

        }

        public static bool ValidarData(this string dataNascimento) {
            string regex = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/[12][0-9]{3}$";

            if (Regex.IsMatch(dataNascimento, regex)) {
                return true;

            }
            else {
                return false;
            }
        }

        public static bool ValidarBrankSpace(this string espaco) {
            if (espaco.Equals("") || espaco == null) {
                return false;
            }
            else {
                return true;
            }
        }

        public static bool ValidarPlacaVeiculo(this string placa) {
            Regex regex = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");
            if (regex.IsMatch(placa)) {
                return true;
            }
            return false;

        }

    }

}
