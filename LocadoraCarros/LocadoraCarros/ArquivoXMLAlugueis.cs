using LocadoraCarros.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LocadoraCarros {
    class ArquivoXMLAlugueis {

        private static ArquivoXMLAlugueis instancia;

        private ArquivoXMLAlugueis() {
        }

        public static ArquivoXMLAlugueis GetInstancia() {
            if (instancia == null) {
                instancia = new ArquivoXMLAlugueis();

            }
            return instancia;
        }

        Singleton singleton = Singleton.GetInstancia();

        public void Gravar(string Modelo, string Ano, string Placa, string Quilometragem, string Cor, string Chaci, string QtdPortas, string status) {
            XmlTextWriter arquivo;
            arquivo = new XmlTextWriter(@"C:\Users\Lucas\Desktop\Aluguel.txt", Encoding.UTF8);


            var carros = singleton.BuscarTodosCarros();
            foreach (var item in carros) {
                arquivo.WriteStartElement("Carro");
                arquivo.WriteElementString("Modelo", Modelo);
                arquivo.WriteElementString("Ano", Ano);
                arquivo.WriteElementString("Placa", Placa);
                arquivo.WriteElementString("Quilometragem", Quilometragem);
                arquivo.WriteElementString("Cor", Cor);
                arquivo.WriteElementString("Chaci", Chaci);
                arquivo.WriteElementString("QtdPortas", QtdPortas);
                arquivo.WriteElementString("Status", status);
                arquivo.WriteEndElement();
            }

            arquivo.Close();
        }


        public String Ler() {
            string textoFinal = "";

            try {
                string arquivo = @"C:\Users\Lucas\Desktop\Aluguel.txt";
                XElement XML = XElement.Load(arquivo);

                foreach (XElement item in XML.Elements()) {
                    textoFinal += item.Name + ":" + item.Value + " \r\n";

                }

                XML = null;

            }
            catch (Exception e) {
                textoFinal = e.Message;

            }

            return textoFinal;
        }
    }
}
