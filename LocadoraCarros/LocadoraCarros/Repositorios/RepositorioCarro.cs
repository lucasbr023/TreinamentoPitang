using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros.Repositorios {
    class RepositorioCarro : IRepositorio<Carro> {

        List<Carro> Repositorio = new List<Carro>();

        public void Inserir(Carro entidade) {
            Repositorio.Add(entidade);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\NataliaVitória\Desktop\teste2.txt")) {
                sw.WriteLine("nome: " + entidade.Modelo.ToString() + " - Documento: " + entidade.Chaci.ToString());
            }
        }

        public void Deletar(Carro entidade) {
            Repositorio.Remove(entidade);
        }

        public void Atualizar(Carro entidade) {
            throw new NotImplementedException();
        }

        public Carro Procurar(string codigo) {
            throw new NotImplementedException();
        }

        public Carro[] BuscarTodos() {
            throw new NotImplementedException();
        }
    }
}
