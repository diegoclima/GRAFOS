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

        public int grauSaida(string v) {
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
                    default:
                        break;
                }
            }
            catch (Exception) {

                throw;
            }
        }
    }
}
