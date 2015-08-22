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
        public int Quilometragem { get; private set; }
        public string Cor { get; set; }
        public string Chaci { get; private set; }
        public int qtdPortas { get; set; }
        



        public Carro(string modelo, string ano, string placa, int quilometragem, string cor, string chaci) {
            Modelo = modelo;
            Ano = ano;
            Placa = placa;
            Quilometragem = quilometragem;
            Cor = cor;
            Chaci = chaci;
          

        
        }
        public override string ToString() {
            return string.Format("{0}-{1}-{2}-{3}-{4}-{5}", Modelo, Ano, Placa, Quilometragem, Cor, Chaci);
        }

        public void GpsCarro(Localizacao localizacao) {


        }
    }


}

