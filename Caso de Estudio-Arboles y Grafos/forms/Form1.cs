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


       /// Lista para almacenar los nodos resaltados
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

            tvArbol.Invalidate();  ///forzar el redibujado del TreeView
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

            tvArbol.Invalidate(); // Forzar el redibujado del TreeView para actualizar el resaltado

            await Task.Delay(500); // Pausa de 500 ms para visualización
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
        




    }
}
    
