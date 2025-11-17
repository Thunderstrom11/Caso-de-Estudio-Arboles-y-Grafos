using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_de_Estudio_Arboles_y_Grafos
{
    public partial class Form1 : Form
    {
        private List<TreeNode> nodosRecorridos = new List<TreeNode>(); /// Lista para almacenar los nodos resaltados
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tvArbol.SelectedNode != null)
            {
                tvArbol.SelectedNode.Nodes.Add(new TreeNode(tbElemento.Text));
                tvArbol.ExpandAll();
            }
            else
            {
                tvArbol.Nodes.Add(new TreeNode(tbElemento.Text));
                tvArbol.ExpandAll();
            }
        }

        private void tvArbol_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (nodosRecorridos.Contains(e.Node))
            {
                e.Graphics.FillRectangle(Brushes.LightGoldenrodYellow, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, tvArbol.Font, e.Bounds, Color.Black, TextFormatFlags.Default);
            }
            else if (e.Node == tvArbol.SelectedNode)
            {
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, tvArbol.Font, e.Bounds, Color.White, TextFormatFlags.Default);
            }
            else
            {
                e.DrawDefault = true;
            }

        }

        private void LimpiarResultados()
        {
            lstbResultados.Items.Clear();

            nodosRecorridos.Clear();

            tvArbol.Invalidate();  //forzar el redibujado del TreeView
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (tvArbol.SelectedNode != null)
            {
                tvArbol.SelectedNode.Remove();
            }

        }

        private async Task VisitarNodo(TreeNode nodo)
        {
            nodosRecorridos.Add(nodo);

            lstbResultados.Items.Add(nodo.Text);

            tvArbol.Invalidate(); // Forzar el redibujado del TreeView 

            await Task.Delay(500); // Pausa para visualización
        }

        private async Task RecorrerPreOrden(TreeNode nodo)
        {
            if (nodo == null) return;
            await VisitarNodo(nodo);
            foreach (TreeNode hijo in nodo.Nodes)
            {
                await RecorrerPreOrden(hijo);
            }
        }

        private async Task RecorrerInOrden(TreeNode nodo)
        {
            if (nodo == null) return;

            if (nodo.Nodes.Count > 0)
            {
                await RecorrerInOrden(nodo.Nodes[0]);
            }
            await VisitarNodo(nodo);
            for (int i = 1; i < nodo.Nodes.Count; i++)
            {
                await RecorrerInOrden(nodo.Nodes[i]);
            }
        }



        private async Task RecorrerPostOrden(TreeNode nodo)
        {
            if (nodo == null) return;
            foreach (TreeNode hijo in nodo.Nodes)
            {
                await RecorrerPostOrden(hijo);
            }
            await VisitarNodo(nodo);
        }



        private async void btnRecPreorden_Click(object sender, EventArgs e)
        {
            LimpiarResultados();
            TreeNode nodoInicio = tvArbol.SelectedNode;

            if (nodoInicio != null)
            {
                await RecorrerPreOrden(nodoInicio);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un nodo para iniciar el recorrido.", "Nodo no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private async void btnRecInOrden_Click(object sender, EventArgs e)
        {
            LimpiarResultados();
            TreeNode nodoInicio = tvArbol.SelectedNode;

            if (nodoInicio != null)
            {
                await RecorrerInOrden(nodoInicio);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un nodo para iniciar el recorrido.", "Nodo no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private async void btnPostOrden_Click(object sender, EventArgs e)
        {
            LimpiarResultados();
            TreeNode nodoInicio = tvArbol.SelectedNode;

            if (nodoInicio != null)
            {
                await RecorrerPostOrden(nodoInicio);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un nodo para iniciar el recorrido.", "Nodo no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            lstbResultados.Items.Clear();

            lstbResultados.Items.Add($"Se ha encontrado un total de {tvArbol.GetNodeCount(true)} nodos");
        }


        private TreeNode BuscarNodo(TreeNodeCollection nodos, string texto)
        {
            foreach (TreeNode nodoActual in nodos)
            {
                if (nodoActual.Text.Equals(texto, StringComparison.OrdinalIgnoreCase))
                {
                    return nodoActual;
                }

                TreeNode nodoEncontrado = BuscarNodo(nodoActual.Nodes, texto);

                if (nodoEncontrado != null)
                {
                    return nodoEncontrado;
                }

            }
            return null; // Nodo no encontrado
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string elementoABuscar = tbElemento.Text;

            if (string.IsNullOrWhiteSpace(elementoABuscar))
            {
                MessageBox.Show("Por favor, ingrese un elemento para buscar.", "Elemento no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TreeNode nodoEncontrado = BuscarNodo(tvArbol.Nodes, elementoABuscar);

            if (nodoEncontrado != null)
            {
                tvArbol.SelectedNode = nodoEncontrado;
                nodoEncontrado.EnsureVisible();
                tvArbol.Focus();
                MessageBox.Show($"Elemento '{elementoABuscar}' encontrado.", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Elemento '{elementoABuscar}' no encontrado.", "Búsqueda fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        ///Pagina Ruta

        private Grafo parqueTecnologico = new Grafo();
        // Diccionario para guardar las coordenadas de cada edificio 
        private Dictionary<string, Point> posicionesVertices = new Dictionary<string, Point>();
        // Lista para guardar el camino a resaltar
        private List<string> rutaResaltada = new List<string>();
        private Random random = new Random();


        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            string nombreEdificio = tbEdificio.Text;
            if (string.IsNullOrEmpty(nombreEdificio))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el edificio.", "Entrada vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (posicionesVertices.ContainsKey(nombreEdificio))
            {
                MessageBox.Show("Ya existe un edificio con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            parqueTecnologico.AgregarVertice(nombreEdificio);

            //Añadir una posición aleatoria en el mapa
            int margen = 30;
            int x = random.Next(margen, pbGrafo.Width - margen);
            int y = random.Next(margen, pbGrafo.Height - margen);
            posicionesVertices[nombreEdificio] = new Point(x, y);

            ActualizarComboBoxesEdificios();
            tbEdificio.Clear();
            pbGrafo.Refresh(); // Fuerza el redibujado del PictureBox
        }


        private void btnCalcularRuta_Click(object sender, EventArgs e)
        {
            if (cmbRutaInicio.SelectedItem == null || cmbRutaFin.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un inicio y fin para la ruta.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inicio = cmbRutaInicio.SelectedItem.ToString();
            string fin = cmbRutaFin.SelectedItem.ToString();

            var resultado = parqueTecnologico.EncontrarRutaMasCorta_Dijkstra(inicio, fin);
            rutaResaltada = resultado.Item1; // Guarda el camino para resaltarlo en el dibujo
            int distanciaTotal = resultado.Item2;

            lstbResultadosGrafo.Items.Clear();

            if (distanciaTotal != -1 && rutaResaltada.Count > 0)
            {
                lstbResultadosGrafo.Items.Add("--- Ruta Más Corta Encontrada ---");
                lstbResultadosGrafo.Items.Add($"Distancia total: {distanciaTotal} metros.");
                lstbResultadosGrafo.Items.Add("Camino: " + string.Join(" -> ", rutaResaltada));
            }
            else
            {
                rutaResaltada.Clear(); // Limpia la ruta si no se encontró
                lstbResultadosGrafo.Items.Add("No se encontró una ruta entre los edificios seleccionados.");
            }

            pbGrafo.Refresh(); 
        }



        private void pbGrafo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var g = e.Graphics;
            g.Clear(Color.White); 

            Pen penAristaNormal = new Pen(Color.SlateGray, 2);
            Pen penAristaResaltada = new Pen(Color.LimeGreen, 4);
            SolidBrush brushVerticeNormal = new SolidBrush(Color.SkyBlue);
            SolidBrush brushVerticeResaltado = new SolidBrush(Color.LimeGreen);
            Font fuenteNormal = new Font("Arial", 9, FontStyle.Bold);
            Font fuentePeso = new Font("Arial", 8);
            StringFormat formatoCentro = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            int radioVertice = 22;

            var listaAdy = parqueTecnologico.ObtenerListaAdyacencia();

            // 1. DIBUJAR LAS LÍNEAS
            foreach (var origen in listaAdy)
            {
                Point p1 = posicionesVertices[origen.Key];
                foreach (var arista in origen.Value)
                {
                    Point p2 = posicionesVertices[arista.Destino];
                    bool esParteDeRuta = EsAristaEnRuta(origen.Key, arista.Destino, rutaResaltada);

 
                    g.DrawLine(esParteDeRuta ? penAristaResaltada : penAristaNormal, p1, p2);


                    Point puntoMedio = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
                    g.FillRectangle(Brushes.White, new Rectangle(puntoMedio.X - 10, puntoMedio.Y - 7, 20, 14));
                    g.DrawString(arista.Peso.ToString(), fuentePeso, Brushes.Black, puntoMedio, formatoCentro);
                }
            }

            // 2. DIBUJAR LOS CÍRCULOS
            foreach (var vertice in posicionesVertices)
            {
                Rectangle rect = new Rectangle(vertice.Value.X - radioVertice, vertice.Value.Y - radioVertice, radioVertice * 2, radioVertice * 2);
                bool esParteDeRuta = rutaResaltada.Contains(vertice.Key);


                g.FillEllipse(esParteDeRuta ? brushVerticeResaltado : brushVerticeNormal, rect);
                g.DrawEllipse(Pens.Black, rect);


                g.DrawString(vertice.Key, fuenteNormal, Brushes.Black, vertice.Value, formatoCentro);
            }
        }



        private void ActualizarComboBoxesEdificios()
        {
            List<string> edificios = parqueTecnologico.ObtenerVertices();
            cmbOrigen.DataSource = new List<string>(edificios);
            cmbDestino.DataSource = new List<string>(edificios);
            cmbRutaInicio.DataSource = new List<string>(edificios);
            cmbRutaFin.DataSource = new List<string>(edificios);
        }

        private bool EsAristaEnRuta(string u, string v, List<string> ruta)
        {
            for (int i = 0; i < ruta.Count - 1; i++)
            {
                if ((ruta[i] == u && ruta[i + 1] == v) || (ruta[i] == v && ruta[i + 1] == u))
                    return true;
            }
            return false;
        }

        private void btnCrearRuta_Click(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedItem == null || cmbDestino.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un edificio de origen y destino.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();

            if (!int.TryParse(tbDistancia.Text, out int distancia) || distancia <= 0)
            {
                MessageBox.Show("Por favor, ingrese una distancia numérica válida y mayor que cero.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (origen == destino)
            {
                MessageBox.Show("No se puede crear una ruta de un edificio a sí mismo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                parqueTecnologico.AgregarArista(origen, destino, distancia);
                pbGrafo.Refresh(); // Redibuja el grafo con la nueva conexión
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la ruta: {ex.Message}");
            }

        }

        private void btnMostrarConexiones_Click(object sender, EventArgs e)
        {

            lstbResultadosGrafo.Items.Clear();
            lstbResultadosGrafo.Items.Add("Lista de Conexiones");

            var conexiones = parqueTecnologico.ObtenerTodasLasAristas();

            if (conexiones.Count == 0)
            {
                lstbResultadosGrafo.Items.Add("No hay conexiones en el grafo.");
                return;
            }

            foreach (var conexion in conexiones)
            {
                lstbResultadosGrafo.Items.Add(conexion);
            }

        }

        private void btnVerificarConexiones_Click(object sender, EventArgs e)
        {
            bool esConexo = parqueTecnologico.EsConexo();

            if (esConexo)
            {
                MessageBox.Show("El grafo es CONEXO.\n(Es posible llegar desde cualquier edificio a cualquier otro).","Validación",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El grafo NO es conexo.\n(Existen edificios aislados que no se pueden alcanzar desde otros puntos).","Validación",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
    
