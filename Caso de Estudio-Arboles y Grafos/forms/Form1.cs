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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jerarquíaOrganizativaToolStripMenuItem_Click(object sender, EventArgs e)
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
            if (e.Node == tvArbol.SelectedNode)
            {
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, tvArbol.Font, e.Bounds, Color.White, TextFormatFlags.Default);
            }
            else
            {
                e.DrawDefault = true;
            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (tvArbol.SelectedNode != null)
            {
                tvArbol.SelectedNode.Remove();
            }

        }
    }
    
}
