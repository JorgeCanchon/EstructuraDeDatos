using System;
using System.Collections.Generic;

namespace Grafos
{
    public class Vertice
    {
        public int Valor { get; set; }
        public List<Vertice> Aristas { get; set; }

        public Vertice(int valor)
        {
            Valor = valor;
            Aristas = new List<Vertice>();
        }
    }
}
