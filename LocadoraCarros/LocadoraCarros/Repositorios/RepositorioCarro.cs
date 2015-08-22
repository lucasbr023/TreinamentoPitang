using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros.Repositorios {
    public class RepositorioCarro : IRepositorio<Carro> {
        private List<Carro> repositorio = new List<Carro>();

        public RepositorioCarro() {


        }

        public void Atualizar(Carro entidade) {
            Carro aux = Procurar(entidade.Placa);
            int index = repositorio.IndexOf(aux);
            repositorio.Insert(index, entidade);
        }

        public List<Carro> BuscarTodos() {
            //return Repositorio;
            return repositorio;
        }

        public void Deletar(Carro entidade) {
            repositorio.Remove(entidade);
        }

        public void Inserir(Carro entidade) {
            repositorio.Add(entidade);



            using (StreamWriter sw = new StreamWriter(@"C:\Users\Lucas\Desktop\teste.txt")) {
                sw.WriteLine(entidade.ToString());
            }


        }

        public Carro Procurar(string codigo) {
            foreach (Carro carro in repositorio) {
                if (carro.Placa.Equals(codigo)) {

                    return carro;
                }

            }
            return null;

        }



    }


}
