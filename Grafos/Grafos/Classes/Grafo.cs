using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grafos.Classes.System;
namespace Grafos.Classes.System {
    public class Grafo {
        protected List<Aresta> vertices = new List<Aresta>();
        protected int totalVerticesGrafo = 0;

        public Grafo() { }

        public override string ToString() {
            string retorno = " ";
            foreach(Aresta a in this.vertices) {
                retorno += "| " + a.getVerticeInicial().getNome() + "-> " + (a.getVerticeFinal() == null ? " " : a.getVerticeFinal().getNome())
            }
            return retorno;
        }

        public virtual string setReposta(string resp) {
            return resp;
        }
    }
}
