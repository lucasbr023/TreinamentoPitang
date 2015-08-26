using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public class Aluguel {

        public int AluguelID { get; set; }
        public Carro Carro { get; set; }
        public Cliente Cliente { get; set; }
        public string Codigo { get; set; }
        public string DataAluguel { get; set; }
        public string DataDevolucao { get; set; }
        //public string Km_inicial { get; set; }
        //public string Km_final { get; set; }

        public virtual Carro CarroReferencia { get; set; }
        public virtual Cliente ClienteReferencia { get; set; }




        public Aluguel(Cliente cliente, Carro carro, string codigo, string dataAluguel, string dataEntrega) {
            Carro = carro;
            Cliente = cliente;
            Codigo = codigo;
            DataAluguel = dataAluguel;
            DataDevolucao = dataEntrega;

        }



        public override string ToString() {
            return string.Format("Carro[{0}]-Cliente[{1}]-Codigo do Aluguel: {2} - Data do Aluguel: {3} - Data de Entrega{4}", Carro.ToString(), Cliente.ToString(), Codigo, DataAluguel.ToString(), DataDevolucao.ToString());
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
