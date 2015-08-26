using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public class Cliente : Pessoa{

        public int ClienteID { get; set; }
        public Endereco Endereco { get; set; }
        public string DadosCartao { get; set; }
        public string CodigoAluguel { get; set; }

        public virtual Carro Carro { get; set; }
        

        public Cliente(string nome, string documento, string codigoAluguel = null) {
            Nome = nome;
            Documento = documento;
            CodigoAluguel = codigoAluguel;

        }

        public override string ToString() {
            return string.Format("Nome: {0}- Documento: {1}", Nome, Documento);
        }








    }


}
