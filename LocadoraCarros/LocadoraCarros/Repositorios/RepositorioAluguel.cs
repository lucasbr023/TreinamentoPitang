using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros.Repositorios {
    class RepositorioAluguel : IRepositorio<Aluguel> {

        private List<Aluguel> repositorio = new List<Aluguel>();

        public RepositorioAluguel() {

        }

        public void Atualizar(Aluguel entidade) {
            throw new NotImplementedException();
        }

        public List<Aluguel> BuscarTodos() {
            return repositorio;
        }

        public void Deletar(Aluguel entidade) {
            repositorio.Remove(entidade);
        }

        public void Inserir(Aluguel entidade) {
            repositorio.Add(entidade);
        }

        public Aluguel Procurar(string codigo) {
            var procurar = repositorio.Where(x=>x.Codigo == codigo);
            foreach (Aluguel item in procurar) {
                return item;
            }
            return null;

        }
    }
}
