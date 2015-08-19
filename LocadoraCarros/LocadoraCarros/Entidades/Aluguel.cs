using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros {
    class Aluguel {
        public Carro Carro { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataAluguel { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Km_inicial { get; set; }
        public string Km_final { get; set; }


        public Aluguel(Cliente cliente, Carro carro) {
            Carro = carro;
            Cliente = cliente;

        }
    }


}
