using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LocadoraCarros.Repositorios {
    class RepositorioCliente : IRepositorio<Cliente> {

        public List<Cliente> Repositorio;

        public RepositorioCliente() {

            Repositorio = new List<Cliente>();

        }

      
        public void Atualizar(Cliente entidade) {
            Cliente aux = Procurar(entidade.Documento);
            int index = Repositorio.IndexOf(aux);
            Repositorio.Insert(index, entidade);
        }

        public Cliente[] BuscarTodos() {
            //return Repositorio;
            throw new NotImplementedException();
        }

        public void Deletar(Cliente entidade) {
            Repositorio.Remove(entidade);
        }

        public void Inserir(Cliente entidade) {
            Repositorio.Add(entidade);


            using (StreamWriter sw = new StreamWriter(@"C:\Users\NataliaVitória\Desktop\teste1.txt")) {
                sw.WriteLine("nome: "+ entidade.Nome.ToString() + " - Documento: " + entidade.Documento.ToString());
            }
     

        }

        public Cliente Procurar(string codigo) {
            foreach (Cliente cliente in Repositorio) {
                if (cliente.Documento.Equals(codigo)) {
                    
                    return cliente;
                }
                
            }
            return null;

        }

    }
}
