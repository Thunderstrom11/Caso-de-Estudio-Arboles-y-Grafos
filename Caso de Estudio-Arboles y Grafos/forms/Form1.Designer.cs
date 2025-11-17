namespace Caso_de_Estudio_Arboles_y_Grafos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpJerarquia = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecPreorden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnborrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbElemento = new System.Windows.Forms.TextBox();
            this.tbpRutas = new System.Windows.Forms.TabPage();
            this.btnRecInOrden = new System.Windows.Forms.Button();
            this.lstbResultados = new System.Windows.Forms.ListBox();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpJerarquia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpJerarquia);
            this.tabControl1.Controls.Add(this.tbpRutas);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpJerarquia
            // 
            this.tbpJerarquia.Controls.Add(this.btnContar);
            this.tbpJerarquia.Controls.Add(this.btnBuscar);
            this.tbpJerarquia.Controls.Add(this.lstbResultados);
            this.tbpJerarquia.Controls.Add(this.groupBox1);
            this.tbpJerarquia.Controls.Add(this.label2);
            this.tbpJerarquia.Controls.Add(this.tvArbol);
            this.tbpJerarquia.Controls.Add(this.btnAgregar);
            this.tbpJerarquia.Controls.Add(this.label1);
            this.tbpJerarquia.Controls.Add(this.tbElemento);
            this.tbpJerarquia.Location = new System.Drawing.Point(4, 25);
            this.tbpJerarquia.Name = "tbpJerarquia";
            this.tbpJerarquia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpJerarquia.Size = new System.Drawing.Size(1054, 420);
            this.tbpJerarquia.TabIndex = 0;
            this.tbpJerarquia.Text = "Jerarquía Organizativa ";
            this.tbpJerarquia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPostOrden);
            this.groupBox1.Controls.Add(this.btnRecInOrden);
            this.groupBox1.Controls.Add(this.btnRecPreorden);
            this.groupBox1.Location = new System.Drawing.Point(521, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos:";
            // 
            // btnRecPreorden
            // 
            this.btnRecPreorden.Location = new System.Drawing.Point(6, 22);
            this.btnRecPreorden.Name = "btnRecPreorden";
            this.btnRecPreorden.Size = new System.Drawing.Size(90, 44);
            this.btnRecPreorden.TabIndex = 2;
            this.btnRecPreorden.Text = "PreOrden";
            this.btnRecPreorden.UseVisualStyleBackColor = true;
            this.btnRecPreorden.Click += new System.EventHandler(this.btnRecPreorden_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // tvArbol
            // 
            this.tvArbol.ContextMenuStrip = this.contextMenuStrip1;
            this.tvArbol.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvArbol.Location = new System.Drawing.Point(20, 72);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(487, 319);
            this.tvArbol.TabIndex = 3;
            this.tvArbol.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.tvArbol_DrawNode);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnborrar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 28);
            // 
            // btnborrar
            // 
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(119, 24);
            this.btnborrar.Text = "borrar";
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(417, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 44);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elemento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbElemento
            // 
            this.tbElemento.Location = new System.Drawing.Point(90, 30);
            this.tbElemento.Name = "tbElemento";
            this.tbElemento.Size = new System.Drawing.Size(307, 22);
            this.tbElemento.TabIndex = 0;
            // 
            // tbpRutas
            // 
            this.tbpRutas.Location = new System.Drawing.Point(4, 25);
            this.tbpRutas.Name = "tbpRutas";
            this.tbpRutas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRutas.Size = new System.Drawing.Size(1054, 420);
            this.tbpRutas.TabIndex = 1;
            this.tbpRutas.Text = "Rutas";
            this.tbpRutas.UseVisualStyleBackColor = true;
            // 
            // btnRecInOrden
            // 
            this.btnRecInOrden.Location = new System.Drawing.Point(6, 72);
            this.btnRecInOrden.Name = "btnRecInOrden";
            this.btnRecInOrden.Size = new System.Drawing.Size(90, 44);
            this.btnRecInOrden.TabIndex = 3;
            this.btnRecInOrden.Text = "InOrden";
            this.btnRecInOrden.UseVisualStyleBackColor = true;
            this.btnRecInOrden.Click += new System.EventHandler(this.btnRecInOrden_Click);
            // 
            // lstbResultados
            // 
            this.lstbResultados.FormattingEnabled = true;
            this.lstbResultados.ItemHeight = 16;
            this.lstbResultados.Location = new System.Drawing.Point(639, 67);
            this.lstbResultados.Name = "lstbResultados";
            this.lstbResultados.Size = new System.Drawing.Size(360, 324);
            this.lstbResultados.TabIndex = 0;
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(6, 122);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(90, 44);
            this.btnPostOrden.TabIndex = 4;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(528, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 44);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(528, 72);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(90, 44);
            this.btnContar.TabIndex = 8;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpJerarquia.ResumeLayout(false);
            this.tbpJerarquia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpJerarquia;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbElemento;
        private System.Windows.Forms.TabPage tbpRutas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnborrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecPreorden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstbResultados;
        private System.Windows.Forms.Button btnRecInOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnContar;
    }
}

