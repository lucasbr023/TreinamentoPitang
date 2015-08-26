using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using LocadoraCarros.Repositorios;
using LocadoraCarros.Negocio;

namespace LocadoraCarros {
    class ArquivoXMLCliente {

        private static ArquivoXMLCliente instancia;

        private ArquivoXMLCliente() {
        }

        public static ArquivoXMLCliente GetInstancia() {
            if (instancia == null) {
                instancia = new ArquivoXMLCliente();

            }
            return instancia;
        }

        Singleton singleton = Singleton.GetInstancia();


        public void Gravar(string Nome, string Documento, string DataNascimento, string Telefone) {
            XmlTextWriter arquivo;
            arquivo = new XmlTextWriter(@"C:\Users\Administrator\Desktop\cliente.txt", Encoding.UTF8);
            var clientes = singleton.BuscarTodosClientes();

            foreach (Cliente item in clientes) {
                arquivo.WriteStartElement("Cliente");
                arquivo.WriteElementString("Nome", Nome);
                arquivo.WriteElementString("Documento", Documento);
                arquivo.WriteElementString("DataNascimento", DataNascimento);
                arquivo.WriteElementString("Telefone", Telefone);
                arquivo.WriteEndElement();
                
            }
            arquivo.Close();
        }


        public String Ler() {
            string textoFinal = "";

            try {
                string arquivo = @"C: \Users\Lucas\Desktop\cliente.txt";
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
