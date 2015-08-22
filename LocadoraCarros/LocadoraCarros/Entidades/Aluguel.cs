using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public class Aluguel {
        public Carro Carro { get; set; }
        public Cliente Cliente { get; set; }
        public string Codigo { get; set; }
        //public DateTime DataAluguel { get; set; }
        //public DateTime DataDevolucao { get; set; }
        //public string Km_inicial { get; set; }
        //public string Km_final { get; set; }


        public Aluguel(Cliente cliente, Carro carro, string codigo) {
            Carro = carro;
            Cliente = cliente;
            Codigo = codigo;

        }

      

        public override string ToString() {
            return string.Format("Carro[{0}]-Cliente[{1}]-Codigo do Aluguel: {2}",Carro.ToString(), Cliente.ToString(), Codigo);
        }

        //public static bool DisponibilidadeCarro(Carro carro) {
        //    if ((int)carro.Status == 1) {
        //        return true;
        //    }
        //    else {
        //        return false;
        //    }
        // }





    }


}
