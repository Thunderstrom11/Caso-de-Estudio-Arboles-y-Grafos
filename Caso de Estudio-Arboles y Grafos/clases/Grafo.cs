using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_de_Estudio_Arboles_y_Grafos
{
    public class Grafo
    {
        public class Arista
        {
            public string Destino { get; }
            public int Peso { get; set; } // Distancia

            public Arista(string destino, int peso)
            {
                Destino = destino;
                Peso = peso;
            }
        }

        private readonly Dictionary<string, List<Arista>> listaAdyacencia;

        public Grafo()
        {
            listaAdyacencia = new Dictionary<string, List<Arista>>();
        }


        public void AgregarVertice(string vertice)
        {
            if (!listaAdyacencia.ContainsKey(vertice))
            {
                listaAdyacencia[vertice] = new List<Arista>();
            }
        }

        public void AgregarArista(string origen, string destino, int peso)
        {
            if (!listaAdyacencia.ContainsKey(origen) || !listaAdyacencia.ContainsKey(destino))
            {
                throw new ArgumentException("Ambos edificios deben existir en el grafo.");
            }
            listaAdyacencia[origen].Add(new Arista(destino, peso));
            listaAdyacencia[destino].Add(new Arista(origen, peso)); // No dirigido
        }

        public void EliminarVertice(string nombreVertice)
        {
            // Si el vértice no existe, no hacer nada
            if (!listaAdyacencia.ContainsKey(nombreVertice))
            {
                return;
            }

            foreach (var otroVertice in listaAdyacencia.Values)
            {
                otroVertice.RemoveAll(arista => arista.Destino == nombreVertice);
            }

            listaAdyacencia.Remove(nombreVertice);
        }





        public void ActualizarPesoArista(string v1, string v2, int nuevoPeso)
        {
            // Actualizar en la lista de adyacencia de v1
            var arista1 = listaAdyacencia[v1].FirstOrDefault(a => a.Destino == v2);
            if (arista1 != null) arista1.Peso = nuevoPeso;

            // Actualizar en la lista de adyacencia de v2
            var arista2 = listaAdyacencia[v2].FirstOrDefault(a => a.Destino == v1);
            if (arista2 != null) arista2.Peso = nuevoPeso;
        }


        public Dictionary<string, List<Arista>> ObtenerListaAdyacencia()
        {
            return listaAdyacencia;
        }

        public List<string> ObtenerVertices()
        {
            return listaAdyacencia.Keys.ToList();
        }


        public Tuple<List<string>, int> EncontrarRutaMasCorta_Dijkstra(string inicio, string fin)
        {
            var distancias = new Dictionary<string, int>();
            var previo = new Dictionary<string, string>();
            var colaPrioridad = new List<string>();

            foreach (var vertice in listaAdyacencia.Keys)
            {
                distancias[vertice] = int.MaxValue;
                previo[vertice] = null;
                colaPrioridad.Add(vertice);
            }
            distancias[inicio] = 0;

            while (colaPrioridad.Count > 0)
            {
                colaPrioridad.Sort((x, y) => distancias[x].CompareTo(distancias[y]));
                var u = colaPrioridad[0];
                colaPrioridad.Remove(u);

                if (u == fin) break;

                if (distancias[u] == int.MaxValue) continue; // No se puede alcanzar este nodo

                foreach (var aristaVecina in listaAdyacencia[u])
                {
                    var v = aristaVecina.Destino;
                    var nuevaDist = distancias[u] + aristaVecina.Peso;

                    if (nuevaDist < distancias[v])
                    {
                        distancias[v] = nuevaDist;
                        previo[v] = u;
                    }
                }
            }

            var camino = new List<string>();
            var actual = fin;
            while (actual != null)
            {
                camino.Add(actual);
                actual = previo[actual];
            }
            camino.Reverse();

            if (camino.Count > 0 && camino[0] == inicio)
            {
                return Tuple.Create(camino, distancias[fin]);
            }

            return Tuple.Create(new List<string>(), -1);
        }


        public List<string> ObtenerTodasLasAristas()
        {
            var aristas = new List<string>();
            
            var aristasVisitadas = new HashSet<string>();

            foreach (var origen in listaAdyacencia)
            {
                foreach (var arista in origen.Value)
                {
                    
                    string clave = string.Compare(origen.Key, arista.Destino) < 0
                                 ? $"{origen.Key}-{arista.Destino}"
                                 : $"{arista.Destino}-{origen.Key}";

                    if (!aristasVisitadas.Contains(clave))
                    {
                        aristas.Add($"{origen.Key} <--> {arista.Destino} ({arista.Peso} km)");
                        aristasVisitadas.Add(clave);
                    }
                }
            }
            return aristas;
        }

        
        public bool EsConexo()
        {
            
            if (listaAdyacencia.Count <= 1) return true;

            var visitados = new HashSet<string>();
            var cola = new Queue<string>();

            
            string verticeInicial = listaAdyacencia.Keys.First();
            cola.Enqueue(verticeInicial);
            visitados.Add(verticeInicial);

            // Recorrido BFS  para encontrar todos los nodos alcanzables
            while (cola.Count > 0)
            {
                string actual = cola.Dequeue();
                foreach (var arista in listaAdyacencia[actual])
                {
                    if (!visitados.Contains(arista.Destino))
                    {
                        visitados.Add(arista.Destino);
                        cola.Enqueue(arista.Destino);
                    }
                }
            }

            // Si el número de nodos que pudimos visitar es igual al total de nodos, el grafo es conexo.
            return visitados.Count == listaAdyacencia.Count;
        }

    }
}