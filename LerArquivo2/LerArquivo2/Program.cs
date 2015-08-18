using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerArquivo2 {
    class Program {
        static void Main(string[] args) {


            try {
                Console.WriteLine("Digite \"Sair\" para sair do programa");
                Console.WriteLine("Digite o caminho de um arquivo txt: ");
                string arquivo = Console.ReadLine();

                while (!arquivo.Equals("sair")) {

                    if (System.IO.File.Exists(arquivo)) {
                        LerArquivo(arquivo);

                    }
                    else {
                        Console.WriteLine("o arquivo não existe, digite outro caminho!");
                        arquivo = Console.ReadLine();
                    }

                    Console.WriteLine("Digite o caminho de um arquivo txt: ");
                    arquivo = Console.ReadLine();
                }
            }
            catch (System.IO.FileNotFoundException) {

                Console.WriteLine("O arquivo não existe!");





            }
        }

        private static void LerArquivo(string arquivo) {

            string[] lines = System.IO.File.ReadAllLines(@arquivo);
            int qtd = lines.Length;

            int count = 0;

            if (qtd < 5) {
                Console.WriteLine("Seu arquivo não contem no minimo 5 linhas, digite o caminho para outro arquivo!");
                arquivo = Console.ReadLine();
            }
            else {

                while (count < 5) {

                    if (lines[count] != null) {

                        Console.WriteLine(lines[count]);

                        count++;

                    }
                }
            }
        }
    }
}




