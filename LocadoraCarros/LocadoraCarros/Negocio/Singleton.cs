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
        private RepositorioAluguel repositorioAluguel;

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
            repositorioAluguel = new RepositorioAluguel();
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
       
        public void RemoverCarro(Aluguel aluguel) {
            repositorioAluguel.Deletar(aluguel);
        }

        public void InserirAluguel(Aluguel aluguel) {
            repositorioAluguel.Inserir(aluguel);
        }
        public void RemoverAluguel(Aluguel aluguel) {
            repositorioAluguel.Deletar(aluguel);
        }

        public List<Aluguel> BuscarTodosAlugueis() {
            return repositorioAluguel.BuscarTodos();
        }
        public Aluguel ProcurarAluguel(string codigo) {
            return repositorioAluguel.Procurar(codigo);
        }
    }
}
