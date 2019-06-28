using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grafos.Classes.System;

namespace Grafos.Classes.System {
    public class GrafoDirigidoCopia : Grafo{
        public GrafoDirigidoCopia(List<string> entrada) {
            foreach(string ent in entrada) {
                if (ent.Contains("#")) {
                    this.totalVerticesGrafo = int.Parse(ent.Substring(1, ent.Length - 1));
                }
                else {
                    string[] vet = ent.Split(';');
                    Vertice v1 = vet[0].Equals("") ? null : new Vertice(vet[0]);
                    Vertice v2 = vet[1].Equals("") ? null : new Vertice(vet[1]);
                    double peso = vet[2].Equals("") ? 0 : double.Parse(vet[2]);
                    int dir = vet[3].Equals("") ? 0 : int.Parse(vet[3]);
                    Aresta aresta = null;
                    if (dir ==-1) {
                        aresta = new Aresta(v1, v2, peso);
                    }else if (dir ==1) {
                        aresta = new Aresta(v1, v2, peso);
                    }
                    this.vertices.Add(aresta);
                }
            }
        }

        public int getGrauEntrada(string v1) {
            int grau = 0;
            foreach (Aresta a in vertices) {
                if (a.getVerticeFinal()!=null && (a.getVerticeFinal().getNome().Equals(v1))) {
                    grau++;
                }
            }
            return grau;
        }

        public int getGrauSaida(string v) {
            int grau = 0;
            foreach (Aresta aresta in vertices) {
                if (aresta.getVerticeInicial().getNome().Equals(v)) {
                    grau++;
                }
            }
            return grau;
        }

        public override string setResposta(string respString) {
            try {
                int resp = int.Parse(respString);
                switch (resp) {
                    case 1: return this.preGetGrauEntrada();
                    case 2: return this.preGetGrauSaida();
                    case 3: return this.preHasCiclo();
                    default: return "";
                }
            }
            catch (Exception ex) {

                Console.WriteLine("Erro ao converter resposta" + ex.Message);
                return "0";
            }
        }

        private string preHasCiclo() {
            throw new NotImplementedException();
        }

        private string preGetGrauSaida() {
            Console.Clear();
            Home.getCabecalho();
            Console.WriteLine("|       Quantidade de GRAU SAIDA do vértice.           |");
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("Digite o nome do Vértice: ");
            string v1 = Console.ReadLine();
            int retorno = this.getGrauSaida(v1);
            Console.WriteLine();
            Console.WriteLine("O vértice " + v1 + " possui " + retorno + " graus de Saída");
            Console.WriteLine();
            Console.WriteLine("Pressione 0 (zero) para sair ou qualquer tecla para voltar ao MENU");
            return Console.ReadLine();
        }

        private string preGetGrauEntrada() {
            Console.Clear();
            Home.getCabecalho();
            Console.WriteLine("|       Quantidade de GRAU ENTRADA do vértice.           |");
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("Digite o nome do Vértice: ");
            string v1 = Console.ReadLine();
            int retorno = this.getGrauEntrada(v1);
            Console.WriteLine();
            Console.WriteLine("O vértice " + v1 + " possui " + retorno + " graus de Entrada");
            Console.WriteLine();
            Console.WriteLine("Pressione 0 (zero) para sair ou qualquer tecla para voltar ao MENU");
            return Console.ReadLine();
        }

    }

   

}
