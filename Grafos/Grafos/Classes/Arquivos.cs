using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grafos.Classes.System;
using System.IO;

namespace Grafos.Classes.System {
    public class Arquivos {
              
        public static List<string> carregarArquivo() {
            List<string> dados = new List<string>();
            // cria uma lista para armazenar os dados encontrados
            string arqText = "Arquivo.txt";
            // variavel que ira receber linha por linha do arquivo.
            string linha;
            if (File.Exists(arqText)) {
                StreamReader leitura = new StreamReader(arqText);
                while((linha = leitura.ReadLine()) != null) {
                    dados.Add(linha);

                }
                return dados;
            }
            else {
                Console.WriteLine("Nenhum registro encontrado!!");
                return null;
            }
           
        }
    }
}
