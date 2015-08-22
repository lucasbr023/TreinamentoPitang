using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public class Cliente : Pessoa{
      
        public Endereco Endereco { get; set; }
        public string DadosCartao { get; set; }
        

        public Cliente(string nome, string documento) {
            Nome = nome;
            Documento = documento;

        }

        public override string ToString() {
            return string.Format("{0}-{1}", Nome, Documento);
        }








    }


}
