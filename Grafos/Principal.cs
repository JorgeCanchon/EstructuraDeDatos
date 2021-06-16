using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    /// <summary>
    /// grafos
    /// conjunto de vertices y aristas
    /// g = (v, a)
    /// dirigidos y no dirigidos
    /// bfs busqueda ancha
    /// dfs búsqueda profunda
    /// se usan para optimización
    /// búsqueda de caminos con el menor costo,
    /// Sistemas de Información Geográfica
    /// conjunto de nodos y un conjunto de arcos que establecen relaciones entre los nodos.
    /// ejemplo la memoria heap (memoria dinamica que almacena los datos en la ejecución de un programa)
    /// https://www.youtube.com/watch?v=BFq-Y73NBS8&list=RDCMUCDUdeFslCNoM29MAlZOfdWQ&start_radio=1&t=703s&ab_channel=hdeleon.net
    /// </summary>
    public class Principal
    {
 
        public Principal()
        {
            Vertice oVertice1 = new Vertice(1);
            Vertice oVertice2 = new Vertice(2);
            Vertice oVertice3 = new Vertice(3);
            Vertice oVertice4 = new Vertice(4);
            Vertice oVertice5 = new Vertice(5);
            Vertice oVertice6 = new Vertice(6);

            oVertice6.Aristas.Add(oVertice4);
            oVertice4.Aristas.Add(oVertice5);
            oVertice4.Aristas.Add(oVertice3);
            oVertice3.Aristas.Add(oVertice2);
            oVertice5.Aristas.Add(oVertice2);
            oVertice5.Aristas.Add(oVertice1);
            oVertice2.Aristas.Add(oVertice1);

            Road(oVertice6);
        }
        
        public void Road(Vertice oVertice, string sangria = "")
        {
            if(oVertice != null)
            {
                Console.WriteLine($"{sangria}{oVertice.Valor}");
                oVertice.Aristas.ForEach(vertice => Road(vertice, sangria + "\t"));
            }
        } 
    }
}
