using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Text;
  

namespace LocadoraCarros.Repositorios {
    public class RepositorioCliente : IRepositorio<Cliente>{
        //IRepositorio<Cliente> 

        private List<Cliente> repositorio = new List<Cliente>();

        public RepositorioCliente() {


            //repositorio = new List<Cliente>();
        }

        public void Atualizar(Cliente entidade) {
            Cliente aux = Procurar(entidade.Documento);
            int index = repositorio.IndexOf(aux);
            repositorio.Insert(index, entidade);
        }

        public List<Cliente> BuscarTodos() {
            //return Repositorio;
            return repositorio;
        }

        public void Deletar(Cliente entidade) {
            repositorio.Remove(entidade);
        }

        public void Inserir(Cliente entidade) {
            repositorio.Add(entidade);


            //using (StreamWriter sw = new StreamWriter(@"C:\Users\Lucas\Desktop\teste.txt")) {
            //    sw.WriteLine(entidade.ToString());
            //}


        }

        public Cliente Procurar(string codigo) {

            
            foreach (Cliente cliente in repositorio) {
                if (cliente.Documento.Equals(codigo)) {

                    return cliente;
                }

            }
            return null;

        }



    }


}
