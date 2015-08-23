using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public class Carro {

        public string Modelo { get; private set; }
        public string Ano { get; private set; }
        public string Placa { get; private set; }
        public int Quilometragem { get; set; }
        public string Cor { get; set; }
        public string Chaci { get; private set; }
        public int QtdPortas { get; set; }
        public bool Status { get; set; }
        public string CodigoAluguel { get; set; }





        public Carro(string modelo, string placa, bool status,string codigoAluguel = null) {
            Modelo = modelo;
            Placa = placa;
            Status = status;
            CodigoAluguel = codigoAluguel;
        }

        
        public override string ToString() {
            return string.Format("Modelo: {0}- Placa: {1} - Disponibilidade: {2}", Modelo, Placa, Status ? "Indisponivel": "Disponivel");
        }

        public void GpsCarro(Localizacao localizacao) {
            

        }
    }


}

