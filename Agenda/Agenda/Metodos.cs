using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Agenda {
    class Metodos {
        string telefone;

        string[,] telefones = new string[10, 2];

        public void Digitar(int posicao) {
            Console.WriteLine("Digite o telefone");
            try {
                telefone = Console.ReadLine();
              
                if (telefone.ValidarTelefone()) {
                    telefones[posicao, 1] = telefone;
                }
                else {
                    throw new FormatException();
                }
                
            }
            catch(FormatException){
                Console.WriteLine("Valor invalido!");
                
                

            }
        }

        public void Escrever(int posicao) {
            Console.WriteLine(telefones[posicao, 1]);
        }

        public String Adicionar(String numero) {
            StringBuilder sb = new StringBuilder();

            string sharp = "#";
            sb.AppendFormat(sharp + numero);

            return sb.ToString();
        }

    }
}
