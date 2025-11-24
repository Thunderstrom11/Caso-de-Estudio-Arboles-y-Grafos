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

            // valores iniciales para el ComboBox de departamentos
            cmbDepartamento.Items.Add("Estelí");
            cmbDepartamento.Items.Add("Matagalpa");
            cmbDepartamento.Items.Add("León");
            cmbDepartamento.Items.Add("Managua");
            cmbDepartamento.SelectedIndex = 0; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarResultados();
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

            await Task.Delay(500); 
        }

        private async Task RecorrerPreOrden(TreeNode nodo)
        {
            if (nodo == null) return;

            await VisitarNodo(nodo); //Visitar Raiz
            foreach (TreeNode hijo in nodo.Nodes) //Recorrer Hijos
            {
                await RecorrerPreOrden(hijo);
            }
        }

        private async Task RecorrerInOrden(TreeNode nodo)
        {
            if (nodo == null) return;

            if (nodo.Nodes.Count > 0) //Recorrer primer hijo
            {
                await RecorrerInOrden(nodo.Nodes[0]);
            }

            await VisitarNodo(nodo); //Visitar Raiz


            for (int i = 1; i < nodo.Nodes.Count; i++) //Recorrer demas hijos
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
            LimpiarResultados();

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
            LimpiarResultados();
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





        ///GRAFO

        private Grafo parqueTecnologico = new Grafo();
        // Diccionario para guardar las coordenadas de cada edificio 
        private Dictionary<string, Point> posicionesVertices = new Dictionary<string, Point>();
        // Lista para guardar el camino a resaltar
        private List<string> rutaResaltada = new List<string>();
        private Random random = new Random(); // Numero aleatorio para posiciones
        private string vertice_A_Mover = null;
        private string vertice_A_Eliminar = null;

        // Dimensiones del mapa (Managua, León, Matagalpa, Estelí)
        private const double ANCHO_IZQUIERDO_KM = 55.0;
        private const double ANCHO_DERECHO_KM = 93.0;
        private const double ALTO_SUPERIOR_KM = 120.0;
        private const double ALTO_INFERIOR_KM = 130.0;

        private const double ANCHO_TOTAL_KM = ANCHO_IZQUIERDO_KM + ANCHO_DERECHO_KM; // 148 km
        private const double ALTO_TOTAL_KM = ALTO_SUPERIOR_KM + ALTO_INFERIOR_KM;   // 250 km


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

            if (cmbDepartamento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un departamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            parqueTecnologico.AgregarVertice(nombreEdificio);

            //Añadir una posición aleatoria en el mapa
            Point nuevaPosicion;
            int intentos = 0;
            do
            {
                nuevaPosicion = GenerarPosicion(cmbDepartamento.SelectedItem.ToString());
                intentos++;
                // Si después de 20 intentos no se encuentra un lugar
                if (intentos > 20) break;
            } while (!PosicionValida(nuevaPosicion));

            posicionesVertices[nombreEdificio] = nuevaPosicion;

            ActualizarComboBoxesEdificios();
            tbEdificio.Clear();
            pbGrafo.Refresh();
        }

        private Point GenerarPosicion(string departamento)
        {
            int margen = 30;
            int mitadAncho = pbGrafo.Width / 2;
            int mitadAlto = pbGrafo.Height / 2;
            int x = 0, y = 0;

            switch (departamento)
            {
                case "Estelí": // Arriba-Izquierda
                    x = random.Next(margen, mitadAncho - margen);
                    y = random.Next(margen, mitadAlto - margen);
                    break;
                case "Matagalpa": // Arriba-Derecha
                    x = random.Next(mitadAncho + margen, pbGrafo.Width - margen);
                    y = random.Next(margen, mitadAlto - margen);
                    break;
                case "León": // Abajo-Izquierda
                    x = random.Next(margen, mitadAncho - margen);
                    y = random.Next(mitadAlto + margen, pbGrafo.Height - margen);
                    break;
                case "Managua": // Abajo-Derecha
                    x = random.Next(mitadAncho + margen, pbGrafo.Width - margen);
                    y = random.Next(mitadAlto + margen, pbGrafo.Height - margen);
                    break;
            }
            return new Point(x, y);
        }

        private bool PosicionValida(Point nuevaPosicion)
        {
            int distanciaMinima = 50; 
            foreach (var pos in posicionesVertices.Values)
            {
                int dx = pos.X - nuevaPosicion.X;
                int dy = pos.Y - nuevaPosicion.Y;
                double distancia = Math.Sqrt(dx * dx + dy * dy); //operacion de distancia que sirve para calcular la distancia entre dos puntos
                if (distancia < distanciaMinima)
                {
                    return false; // Demasiado cerca
                }
            }
            return true; // Posición aceptada
        }



        private void btnCalcularRuta_Click(object sender, EventArgs e)
        {
            rutaResaltada.Clear(); 
            pbGrafo.Refresh(); 

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
                lstbResultadosGrafo.Items.Add("Ruta Más Corta:");
                lstbResultadosGrafo.Items.Add($"Distancia total: {distanciaTotal} km.");
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
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            //DIBUJAR EL FONDO CON DEPARTAMENTOS 

            // Calcular las posiciones de las líneas divisorias basadas en las proporciones de KM
            float lineaVerticalX = (float)(pbGrafo.Width * (ANCHO_IZQUIERDO_KM / ANCHO_TOTAL_KM));
            float lineaHorizontalY = (float)(pbGrafo.Height * (ALTO_SUPERIOR_KM / ALTO_TOTAL_KM));

            // Definir herramientas de dibujo para el mapa
            Pen penDivisor = new Pen(Color.LightGray, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            Font fuenteDepartamento = new Font("Arial", 12, FontStyle.Bold);
            StringFormat formatoCentro = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            SolidBrush brushDepartamento = new SolidBrush(Color.FromArgb(50, Color.Black)); // Texto semitransparente

            // Dibujar las líneas divisorias
            g.DrawLine(penDivisor, lineaVerticalX, 0, lineaVerticalX, pbGrafo.Height);
            g.DrawLine(penDivisor, 0, lineaHorizontalY, pbGrafo.Width, lineaHorizontalY);

            // Dibujar los nombres de los departamentos en el centro de cada cuadrante
            g.DrawString("ESTELÍ", fuenteDepartamento, brushDepartamento, new PointF(lineaVerticalX / 2, lineaHorizontalY / 2), formatoCentro);
            g.DrawString("MATAGALPA", fuenteDepartamento, brushDepartamento, new PointF(lineaVerticalX + (pbGrafo.Width - lineaVerticalX) / 2, lineaHorizontalY / 2), formatoCentro);
            g.DrawString("LEÓN", fuenteDepartamento, brushDepartamento, new PointF(lineaVerticalX / 2, lineaHorizontalY + (pbGrafo.Height - lineaHorizontalY) / 2), formatoCentro);
            g.DrawString("MANAGUA", fuenteDepartamento, brushDepartamento, new PointF(lineaVerticalX + (pbGrafo.Width - lineaVerticalX) / 2, lineaHorizontalY + (pbGrafo.Height - lineaHorizontalY) / 2), formatoCentro);


            //DIBUJAR LAS ARISTAS Y VÉRTICES

            Pen penAristaNormal = new Pen(Color.SlateGray, 2);
            Pen penAristaResaltada = new Pen(Color.LimeGreen, 4);
            SolidBrush brushVerticeNormal = new SolidBrush(Color.SkyBlue);
            SolidBrush brushVerticeResaltado = new SolidBrush(Color.LimeGreen);
            Font fuenteNormal = new Font("Arial", 9, FontStyle.Bold);
            Font fuentePeso = new Font("Arial", 8);
            int radioVertice = 22;

            var listaAdy = parqueTecnologico.ObtenerListaAdyacencia();

            //ARISTAS
            foreach (var origen in listaAdy)
            {
                // Asegurarse de que el origen tiene una posición asignada antes de intentar dibujarlo
                if (!posicionesVertices.ContainsKey(origen.Key)) continue;

                Point p1 = posicionesVertices[origen.Key];
                foreach (var arista in origen.Value)
                {
                    // Asegurarse de que el destino también tiene una posición
                    if (!posicionesVertices.ContainsKey(arista.Destino)) continue;

                    Point p2 = posicionesVertices[arista.Destino];
                    bool esParteDeRuta = RutadeArista(origen.Key, arista.Destino, rutaResaltada);

                    // Dibujar la línea de conexión
                    g.DrawLine(esParteDeRuta ? penAristaResaltada : penAristaNormal, p1, p2);

                    // Dibujar el peso (distancia en KM) en el medio de la línea
                    Point puntoMedio = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2); 
                    g.FillRectangle(Brushes.White, new Rectangle(puntoMedio.X - 12, puntoMedio.Y - 8, 24, 16)); 
                    g.DrawString(arista.Peso + "km", fuentePeso, Brushes.Black, puntoMedio, formatoCentro);
                }
            }

            //VÉRTICES
            foreach (var vertice in posicionesVertices)
            {
                Rectangle rect = new Rectangle(vertice.Value.X - radioVertice, vertice.Value.Y - radioVertice, radioVertice * 2, radioVertice * 2);
                bool esParteDeRuta = rutaResaltada.Contains(vertice.Key);

                // Dibujar el círculo
                g.FillEllipse(esParteDeRuta ? brushVerticeResaltado : brushVerticeNormal, rect);
                g.DrawEllipse(Pens.Black, rect);

                // Dibujar el nombre del edificio
                g.DrawString(vertice.Key, fuenteNormal, Brushes.Black, vertice.Value, formatoCentro);
            }
        }


        private int CalcularDistanciaReal(Point p1, Point p2)
        {
            // Calcular cuántos KM son por cada píxel
            double kmPorPixelX = ANCHO_TOTAL_KM / pbGrafo.Width;
            double kmPorPixelY = ALTO_TOTAL_KM / pbGrafo.Height;

            // Calcular la diferencia 
            double diffX_px = p1.X - p2.X;
            double diffY_px = p1.Y - p2.Y;

            // Convertir la diferencia de píxeles a KM
            double diffX_km = diffX_px * kmPorPixelX;
            double diffY_km = diffY_px * kmPorPixelY;

            // Calcular la distancia con dimensiones en KM
            double distanciaReal = Math.Sqrt(Math.Pow(diffX_km, 2) + Math.Pow(diffY_km, 2)); // Teorema de Pitágoras

            return (int)distanciaReal;
        }


        private void ActualizarComboBoxesEdificios()
        {
            List<string> edificios = parqueTecnologico.ObtenerVertices();
            cmbOrigen.DataSource = new List<string>(edificios);
            cmbDestino.DataSource = new List<string>(edificios);
            cmbRutaInicio.DataSource = new List<string>(edificios);
            cmbRutaFin.DataSource = new List<string>(edificios);
        }

        private bool RutadeArista(string orig, string dest, List<string> ruta)  
        {
            for (int i = 0; i < ruta.Count - 1; i++)
            {
                if ((ruta[i] == orig && ruta[i + 1] == dest) || (ruta[i] == dest && ruta[i + 1] == orig)) 
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

            //Validar que no sean el mismo edificio
            if (origen == destino)
            {
                MessageBox.Show("No se puede crear una ruta de un edificio a sí mismo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //CALCULO LA DISTANCIA REAL ENTRE PUNTOS
            int distanciaCalculadaEnKm = CalcularDistanciaReal(posicionesVertices[origen], posicionesVertices[destino]);

            try
            {
                parqueTecnologico.AgregarArista(origen, destino, distanciaCalculadaEnKm);

                pbGrafo.Refresh();
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

        private void pbGrafo_MouseDown(object sender, MouseEventArgs e)
        {
            // Limpiar el vertice selecciónado
            vertice_A_Mover = null;

            // Revisar si el mouse está sobre algún vértice
            foreach (var vertice in posicionesVertices)
            {
                int radioVertice = 22;
                Point centro = vertice.Value;
                if (Math.Pow(e.X - centro.X, 2) + Math.Pow(e.Y - centro.Y, 2) <= Math.Pow(radioVertice, 2))
                {

                    if (e.Button == MouseButtons.Left)
                    {
                        //clic izquierdo = mover
                        vertice_A_Mover = vertice.Key;
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        //clic derecho = eliminar
                        vertice_A_Eliminar = vertice.Key;
                    }

                    // Actualizar el TextBox de posición
                    string depto = ObtenerDepartamento(e.Location);
                    tbPosicionActual.Text = $"{vertice.Key} | {depto} | X ({e.Location.X}) Y ({e.Location.Y})";
                    break; //Romper el bucle una vez se encuentre el vértice
                }
            }
        }

        private void pbGrafo_MouseMove(object sender, MouseEventArgs e)
        {
            if (vertice_A_Mover != null)
            {
                //Limpiar resultados previos
                int radioVertice = 22;
                Point nuevaPosicion = e.Location;

                // Asegurarse de que la nueva posición X no se salga de los bordes
                if (nuevaPosicion.X < radioVertice) nuevaPosicion.X = radioVertice;
                if (nuevaPosicion.X > pbGrafo.Width - radioVertice) nuevaPosicion.X = pbGrafo.Width - radioVertice;

                // Asegurarse de que la nueva posición Y no se salga de los bordes
                if (nuevaPosicion.Y < radioVertice) nuevaPosicion.Y = radioVertice;
                if (nuevaPosicion.Y > pbGrafo.Height - radioVertice) nuevaPosicion.Y = pbGrafo.Height - radioVertice;

                //Mover el vértice a la nueva posición validada
                posicionesVertices[vertice_A_Mover] = nuevaPosicion;

                //Actualizar valor de aristas conectadas usando la distancia real
                var vecinos = parqueTecnologico.ObtenerListaAdyacencia()[vertice_A_Mover];
                foreach (var aristaVecina in vecinos)
                {
                    int nuevaDistancia = CalcularDistanciaReal(posicionesVertices[vertice_A_Mover], posicionesVertices[aristaVecina.Destino]);
                    parqueTecnologico.ActualizarPesoArista(vertice_A_Mover, aristaVecina.Destino, nuevaDistancia);
                }

                //Refrescar la posición en el TextBox
                string depto = ObtenerDepartamento(nuevaPosicion);
                tbPosicionActual.Text = $"{vertice_A_Mover} | {depto} | X ({nuevaPosicion.X}) Y ({nuevaPosicion.Y})";
                pbGrafo.Refresh();
            }
        }

        private void pbGrafo_MouseUp(object sender, MouseEventArgs e)
        {
            vertice_A_Mover = null;
        }

        private string ObtenerDepartamento(Point coords)
        {
            float lineaVerticalX = (float)(pbGrafo.Width * (ANCHO_IZQUIERDO_KM / ANCHO_TOTAL_KM));
            float lineaHorizontalY = (float)(pbGrafo.Height * (ALTO_SUPERIOR_KM / ALTO_TOTAL_KM));

            //Comparar la coordenada del punto con las líneas para determinar el departamento
            if (coords.X < lineaVerticalX)
            {
                // El punto está en la sección izquierda 
                if (coords.Y < lineaHorizontalY)
                {
                    return "Estelí"; // Izquierda y Arriba
                }
                else
                {
                    return "León"; // Izquierda y Abajo
                }
            }
            else
            {
                // El punto está en la sección derecha
                if (coords.Y < lineaHorizontalY)
                {
                    return "Matagalpa"; // Derecha y Arriba
                }
                else
                {
                    return "Managua"; // Derecha y Abajo
                }
            }
        }

        private void tsmiEliminarVertice_Click(object sender, EventArgs e)
        {
            // Asegurarse de que un vértice fue seleccionado con el clic derecho
            if (vertice_A_Eliminar != null)
            {
                var confirmResult = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el edificio '{vertice_A_Eliminar}' y todas sus conexiones?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    parqueTecnologico.EliminarVertice(vertice_A_Eliminar);

                    posicionesVertices.Remove(vertice_A_Eliminar);

                    ActualizarComboBoxesEdificios();
                    pbGrafo.Refresh();

                    vertice_A_Eliminar = null;
                }
            }

        }
    }
}
    
