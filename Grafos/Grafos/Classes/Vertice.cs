using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grafos.Classes.System;

namespace Grafos.Classes.System {
    public class Vertice {
        private string Nome;
        private List<Aresta> adjacentes = new List<Aresta>();

        public Vertice(string dados) {
            this.Nome = dados;
        }
        public string getNome() {
            return this.Nome;
        }
    }
}
