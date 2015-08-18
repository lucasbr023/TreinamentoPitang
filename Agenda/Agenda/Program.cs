using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda {
    class Program {
        static void Main(string[] args) {

            string[,] telefones = new string[10, 2];

            Metodos m = new Metodos();
            string condicao = Console.ReadLine();
            while (!condicao.Equals("#100")) {
                //for (int i = 0; i < 2; i++) {
                Console.WriteLine("Digite uma posição que você deseja adicionar um telefone");
                try {
                    string posicao = Console.ReadLine();
                    if (posicao.Equals("#100")){
                        condicao = posicao;
                    }else if(posicao.ValidarPosicao()) {

                        m.Adicionar(posicao);

                        if (m.Adicionar(posicao).Equals("#01")) {
                            m.Digitar(0);
                        }
                        else if (m.Adicionar(posicao).Equals("#02")) {
                            m.Digitar(1);
                        }
                        else if (m.Adicionar(posicao).Equals("#03")) {
                            m.Digitar(2);
                        }
                        else if (m.Adicionar(posicao).Equals("#04")) {
                            m.Digitar(3);
                        }
                        else if (m.Adicionar(posicao).Equals("#05")) {
                            m.Digitar(4);
                        }
                        else if (m.Adicionar(posicao).Equals("#06")) {
                            m.Digitar(5);
                        }
                        else if (m.Adicionar(posicao).Equals("#07")) {
                            m.Digitar(6);
                        }
                        else if (m.Adicionar(posicao).Equals("#08")) {
                            m.Digitar(7);
                        }
                        else if (m.Adicionar(posicao).Equals("#09")) {
                            m.Digitar(8);
                        }
                        else if (m.Adicionar(posicao).Equals("#10")) {
                            m.Digitar(9);
                        }
                        else if (m.Adicionar(posicao).Equals("#100")) {
                            condicao = "#100";
                        }

                        Console.WriteLine("Qual codigo você deseja saber o numero de #01 - #10");
                        string pesquisa = Console.ReadLine();

                        switch (m.Adicionar(pesquisa)) {

                            case "#01":
                                m.Escrever(0);
                                break;
                            case "#02":
                                m.Escrever(1);
                                break;
                            case "#03":
                                m.Escrever(2);
                                break;
                            case "#04":
                                m.Escrever(3);
                                break;
                            case "#05":
                                m.Escrever(4);
                                break;
                            case "#06":
                                m.Escrever(5);
                                break;
                            case "#07":
                                m.Escrever(6);
                                break;
                            case "#08":
                                m.Escrever(7);
                                break;
                            case "#09":
                                m.Escrever(8);
                                break;
                            case "#10":
                                m.Escrever(9);
                                break;
                            default:
                                Console.WriteLine("Você digitou um codigo errado!!");
                                break;
                        }
                    }
                    else {
                        Console.WriteLine("Digite um valor valido");
                    }
                }
                catch (FormatException e) {
                    Console.WriteLine("Valor invalido!!");

                }








            }


        }
    }
}
