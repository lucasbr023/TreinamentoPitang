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

        public void Gravar(Aluguel aluguel) {
            XmlTextWriter arquivo;
            arquivo = new XmlTextWriter(@"C:\Users\Lucas\Desktop\Aluguel.txt", Encoding.UTF8);


            var carros = singleton.BuscarTodosCarros();
            var clientes = singleton.BuscarTodosClientes();

            foreach (var item in clientes) {
                arquivo.WriteStartElement("Cliente");
                arquivo.WriteElementString("Nome", item.Nome);
                arquivo.WriteElementString("Documento", item.Documento);
                arquivo.WriteElementString("Codigo", item.CodigoAluguel);
                arquivo.WriteEndElement();
            }
            foreach (var item in carros) {
                arquivo.WriteStartElement("Carro");
                arquivo.WriteElementString("Modelo", item.Modelo);
                arquivo.WriteElementString("Placa", item.Placa);
                arquivo.WriteElementString("Codigo", item.CodigoAluguel);
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
