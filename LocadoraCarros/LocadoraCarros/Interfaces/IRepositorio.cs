using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros {
    public interface IRepositorio<T> {

       // IEnumerable<T> List { get; }
        void Inserir(T entidade);
        void Deletar(T entidade);
        void Atualizar(T entidade);
        T Procurar(string codigo);
        List<T> BuscarTodos();

    }
}
