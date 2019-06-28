using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grafos.Classes.System;

namespace Grafos.Classes.System {
    public class GrafoDirigido : Grafo {
        public GrafoDirigido(List<string> entrada) {
            foreach(string ent in entrada) {
                if (entrada.Contains("#")) {
                    this.totalVerticesGrafo = int.Parse(ent.Substring(1, ent.Length - 1));
                }
                else {
                    string[] vet = ent.Split(';');
                    Vertice v1 = vet[0].Equals("") ? null : new Vertice(vet[0]);
                    Vertice v2 = vet[1].Equals("") ? null : new Vertice(vet[1]);
                    double peso = vet[2].Equals("") ? 0 : double.Parse(vet[2]);
                    int dir = vet[3].Equals("") ? 0 : int.Parse(vet[3]);
                    Aresta aresta = null;

                    aresta = new Aresta(v1, v2, peso, dir);
                    this.vertices.Add(aresta);
                }
            }
           
        }
        /// <summary>
        /// Calcula o grau de um vertice.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public int getGrauEntrada(string v) {
            int grau = 0;
            foreach (Aresta aresta in vertices) {

                if (aresta.getVerticeFinal()!=null && (aresta.getVerticeInicial().getNome().Equals(v))) {
                    if (aresta.getDirecao().Equals(1)) {
                        grau++;
                    }
                }
                if (aresta.getVerticeFinal()!=null && (aresta.getVerticeFinal().getNome().Equals(v))) {
                    if (aresta.getDirecao().Equals(-1)) {
                        grau++;
                    }
                }
            }

            return grau;
        }

        public int getGrauSaida(string v) {
            int grau = 0;
            foreach(Aresta a in vertices) {
                if (a.getVerticeFinal() != null && (a.getVerticeInicial().getNome().Equals(v))) {
                    if (a.getDirecao().Equals(-1)) {
                        grau++;
                    }
                }
                if (a.getVerticeFinal()!=null &&(a.getVerticeFinal().getNome().Equals(v))) {
                    if (a.getDirecao().Equals(1)) {
                        grau++;
                    }
                }
            }
            return grau;
        }

        public bool getCiclo() {
            bool retorno = false;
            const int BRANCO = -1;
            const int CINZA = 0;
            const int PRETO = 1;
            return retorno;

        }

        public int DFS(string v1) {
            return 0;
        }

        public override string setReposta(string resp) {
            try {
                int resposta = int.Parse(resp);
                switch (resposta) {
                    case 1: return this.preGetGrauEntrada();
                    case 2: return this.preGetGrauSaida();
                    case 3: return this.preHasCiclo();
                    default: return "";
                }
            }
            catch (Exception ex) {

                Console.WriteLine("Erro ao converter a resposta " + ex.Message);
                return "0";
            }
        }
        public string preHasCiclo() {
            Console.Clear();
            Home.getCabecalho();
            Console.WriteLine("|       Verifica se possui CICLO.                |");
            Console.WriteLine("+------------------------------------------------+");
            bool retorno = this.getCiclo();
            Console.WriteLine();
            if (retorno == true) {
                Console.WriteLine("O grafo possui ciclo");
                Console.WriteLine();
            }
            else {
                Console.WriteLine("O grafo é aciclico (Não possui ciclos)");
            }
            return Console.ReadLine();
        }

        private string preGetGrauSaida() {
            Console.Clear();
            Home.getCabecalho();
            Console.WriteLine("|       Quantidade de GRAU SAIDA do vértice.     |");
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
            Console.WriteLine("|       Quantidade de GRAU ENTRADA do vértice.   |");
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
