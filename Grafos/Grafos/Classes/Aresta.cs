using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grafos.Classes.System;
namespace Grafos.Classes.System {
   public class Aresta {
        private double peso;
        private Vertice verticeInicial;
        private Vertice verticeFinal;
        private int direcao = 0;

        public Aresta(Vertice v1, Vertice v2, double peso) {
            this.verticeInicial = v1;
            this.verticeFinal = v2;
            this.peso = peso;
        }

        public Aresta(Vertice v1, Vertice v2, double peso, int direcao) {
            this.direcao = direcao;
            this.verticeFinal = v2;
            this.verticeInicial = v1;
        }

        public double Peso() {
            return this.peso;
        }

        public Vertice getIniVertice() {
            return this.verticeInicial;
        }
        public Vertice getFimVertice() {
            return this.verticeFinal;
         
        }

        public int getDirecao() {
            return this.direcao;
        }
    }
}
