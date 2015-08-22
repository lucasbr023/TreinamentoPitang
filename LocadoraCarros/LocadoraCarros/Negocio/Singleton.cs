using LocadoraCarros.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros.Negocio {
    public class Singleton {
        private static Singleton instancia;

        private RepositorioCliente repositorioCliente;
        private RepositorioCarro repositorioCarro;

        private Singleton()  {
            Init();
        }

        public static Singleton GetInstancia() {

            if (instancia == null) {
                instancia = new Singleton();
            }
            return instancia;

        }

        public void Init() {
            repositorioCliente = new RepositorioCliente();
            repositorioCarro = new RepositorioCarro();
        }

        public void InserirCliente(Cliente cliente) {
            repositorioCliente.Inserir(cliente);
        }
        public void RemoverCliente(Cliente cliente) {
            repositorioCliente.Deletar(cliente);
        }

        public List<Cliente> BuscarTodosClientes() {
            return repositorioCliente.BuscarTodos();
        }
        public Cliente ProcurarCliente(string codigo) {
            return repositorioCliente.Procurar(codigo);
        }
        public void InserirCarro(Carro carro) {
            repositorioCarro.Inserir(carro);
        }
        public void RemoverCarro(Carro carro) {
            repositorioCarro.Deletar(carro);
        }

        public List<Carro> BuscarTodosCarros() {
            return repositorioCarro.BuscarTodos();
        }
        public Carro ProcurarCarro(string codigo) {
            return repositorioCarro.Procurar(codigo);
        }
    }
}
