using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocadoraCarros {
   
    public class Cliente : Pessoa{

        public int ClienteID { get; set; }
        public Endereco Endereco { get; set; }
        public string CodigoAluguel { get; set; }

        public virtual ICollection<Aluguel> Alugueis { get; set; }
        

        public Cliente(string codigoAluguel = null) {
         

        }

        public override string ToString() {
            return string.Format("Nome: {0}- Documento: {1}", Nome, Documento);
        }








    }


}
