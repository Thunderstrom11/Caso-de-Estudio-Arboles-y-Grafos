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
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnborrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbElemento = new System.Windows.Forms.TextBox();
            this.lstbResultados = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnRecInOrden = new System.Windows.Forms.Button();
            this.btnRecPreorden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpRutas = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPosicionActual = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarConexiones = new System.Windows.Forms.Button();
            this.btnVerificarConexiones = new System.Windows.Forms.Button();
            this.lstbResultadosGrafo = new System.Windows.Forms.ListBox();
            this.gbCalcularRuta = new System.Windows.Forms.GroupBox();
            this.btnCalcularRuta = new System.Windows.Forms.Button();
            this.cmbRutaFin = new System.Windows.Forms.ComboBox();
            this.cmbRutaInicio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbConexiones = new System.Windows.Forms.GroupBox();
            this.btnCrearRuta = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbEdificio = new System.Windows.Forms.GroupBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEdificio = new System.Windows.Forms.TextBox();
            this.pbGrafo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEliminarVertice = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tbpJerarquia.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpRutas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCalcularRuta.SuspendLayout();
            this.gbConexiones.SuspendLayout();
            this.gbEdificio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpJerarquia);
            this.tabControl1.Controls.Add(this.tbpRutas);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpJerarquia
            // 
            this.tbpJerarquia.Controls.Add(this.gbAcciones);
            this.tbpJerarquia.Controls.Add(this.groupBox4);
            this.tbpJerarquia.Controls.Add(this.lstbResultados);
            this.tbpJerarquia.Controls.Add(this.groupBox1);
            this.tbpJerarquia.Controls.Add(this.label2);
            this.tbpJerarquia.Location = new System.Drawing.Point(4, 25);
            this.tbpJerarquia.Name = "tbpJerarquia";
            this.tbpJerarquia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpJerarquia.Size = new System.Drawing.Size(1150, 420);
            this.tbpJerarquia.TabIndex = 0;
            this.tbpJerarquia.Text = "Jerarquía Organizativa ";
            this.tbpJerarquia.UseVisualStyleBackColor = true;
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnContar);
            this.gbAcciones.Controls.Add(this.btnBuscar);
            this.gbAcciones.Location = new System.Drawing.Point(582, 21);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(102, 120);
            this.gbAcciones.TabIndex = 8;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones:";
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(6, 71);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(90, 44);
            this.btnContar.TabIndex = 6;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(6, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 44);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tvArbol);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbElemento);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(507, 411);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Árbol General:";
            // 
            // tvArbol
            // 
            this.tvArbol.ContextMenuStrip = this.contextMenuStrip1;
            this.tvArbol.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvArbol.Location = new System.Drawing.Point(12, 65);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(487, 342);
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
            this.btnAgregar.Location = new System.Drawing.Point(409, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 44);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elemento:";
            // 
            // tbElemento
            // 
            this.tbElemento.Location = new System.Drawing.Point(82, 23);
            this.tbElemento.Name = "tbElemento";
            this.tbElemento.Size = new System.Drawing.Size(307, 22);
            this.tbElemento.TabIndex = 5;
            // 
            // lstbResultados
            // 
            this.lstbResultados.FormattingEnabled = true;
            this.lstbResultados.ItemHeight = 16;
            this.lstbResultados.Location = new System.Drawing.Point(752, 21);
            this.lstbResultados.Name = "lstbResultados";
            this.lstbResultados.Size = new System.Drawing.Size(382, 388);
            this.lstbResultados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPostOrden);
            this.groupBox1.Controls.Add(this.btnRecInOrden);
            this.groupBox1.Controls.Add(this.btnRecPreorden);
            this.groupBox1.Location = new System.Drawing.Point(582, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recorridos:";
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(6, 122);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(90, 44);
            this.btnPostOrden.TabIndex = 7;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnRecInOrden
            // 
            this.btnRecInOrden.Location = new System.Drawing.Point(6, 72);
            this.btnRecInOrden.Name = "btnRecInOrden";
            this.btnRecInOrden.Size = new System.Drawing.Size(90, 44);
            this.btnRecInOrden.TabIndex = 6;
            this.btnRecInOrden.Text = "InOrden";
            this.btnRecInOrden.UseVisualStyleBackColor = true;
            this.btnRecInOrden.Click += new System.EventHandler(this.btnRecInOrden_Click);
            // 
            // btnRecPreorden
            // 
            this.btnRecPreorden.Location = new System.Drawing.Point(6, 22);
            this.btnRecPreorden.Name = "btnRecPreorden";
            this.btnRecPreorden.Size = new System.Drawing.Size(90, 44);
            this.btnRecPreorden.TabIndex = 5;
            this.btnRecPreorden.Text = "PreOrden";
            this.btnRecPreorden.UseVisualStyleBackColor = true;
            this.btnRecPreorden.Click += new System.EventHandler(this.btnRecPreorden_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // tbpRutas
            // 
            this.tbpRutas.Controls.Add(this.groupBox3);
            this.tbpRutas.Controls.Add(this.groupBox2);
            this.tbpRutas.Controls.Add(this.lstbResultadosGrafo);
            this.tbpRutas.Controls.Add(this.gbCalcularRuta);
            this.tbpRutas.Controls.Add(this.gbConexiones);
            this.tbpRutas.Controls.Add(this.gbEdificio);
            this.tbpRutas.Location = new System.Drawing.Point(4, 25);
            this.tbpRutas.Name = "tbpRutas";
            this.tbpRutas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRutas.Size = new System.Drawing.Size(1150, 420);
            this.tbpRutas.TabIndex = 1;
            this.tbpRutas.Text = "Rutas";
            this.tbpRutas.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPosicionActual);
            this.groupBox3.Location = new System.Drawing.Point(596, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 77);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coordenadas";
            // 
            // tbPosicionActual
            // 
            this.tbPosicionActual.Location = new System.Drawing.Point(8, 32);
            this.tbPosicionActual.Name = "tbPosicionActual";
            this.tbPosicionActual.ReadOnly = true;
            this.tbPosicionActual.Size = new System.Drawing.Size(241, 22);
            this.tbPosicionActual.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarConexiones);
            this.groupBox2.Controls.Add(this.btnVerificarConexiones);
            this.groupBox2.Location = new System.Drawing.Point(903, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 77);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnMostrarConexiones
            // 
            this.btnMostrarConexiones.Location = new System.Drawing.Point(6, 21);
            this.btnMostrarConexiones.Name = "btnMostrarConexiones";
            this.btnMostrarConexiones.Size = new System.Drawing.Size(90, 44);
            this.btnMostrarConexiones.TabIndex = 11;
            this.btnMostrarConexiones.Text = "Mostrar Conexiones";
            this.btnMostrarConexiones.UseVisualStyleBackColor = true;
            this.btnMostrarConexiones.Click += new System.EventHandler(this.btnMostrarConexiones_Click);
            // 
            // btnVerificarConexiones
            // 
            this.btnVerificarConexiones.Location = new System.Drawing.Point(98, 21);
            this.btnVerificarConexiones.Name = "btnVerificarConexiones";
            this.btnVerificarConexiones.Size = new System.Drawing.Size(90, 44);
            this.btnVerificarConexiones.TabIndex = 13;
            this.btnVerificarConexiones.Text = "Verificar Conexión";
            this.btnVerificarConexiones.UseVisualStyleBackColor = true;
            this.btnVerificarConexiones.Click += new System.EventHandler(this.btnVerificarConexiones_Click);
            // 
            // lstbResultadosGrafo
            // 
            this.lstbResultadosGrafo.FormattingEnabled = true;
            this.lstbResultadosGrafo.ItemHeight = 16;
            this.lstbResultadosGrafo.Location = new System.Drawing.Point(596, 259);
            this.lstbResultadosGrafo.Name = "lstbResultadosGrafo";
            this.lstbResultadosGrafo.Size = new System.Drawing.Size(500, 148);
            this.lstbResultadosGrafo.TabIndex = 12;
            // 
            // gbCalcularRuta
            // 
            this.gbCalcularRuta.Controls.Add(this.btnCalcularRuta);
            this.gbCalcularRuta.Controls.Add(this.cmbRutaFin);
            this.gbCalcularRuta.Controls.Add(this.cmbRutaInicio);
            this.gbCalcularRuta.Controls.Add(this.label8);
            this.gbCalcularRuta.Controls.Add(this.label9);
            this.gbCalcularRuta.Location = new System.Drawing.Point(903, 16);
            this.gbCalcularRuta.Name = "gbCalcularRuta";
            this.gbCalcularRuta.Size = new System.Drawing.Size(193, 167);
            this.gbCalcularRuta.TabIndex = 11;
            this.gbCalcularRuta.TabStop = false;
            this.gbCalcularRuta.Text = "Calculo de Ruta";
            // 
            // btnCalcularRuta
            // 
            this.btnCalcularRuta.Location = new System.Drawing.Point(54, 111);
            this.btnCalcularRuta.Name = "btnCalcularRuta";
            this.btnCalcularRuta.Size = new System.Drawing.Size(90, 44);
            this.btnCalcularRuta.TabIndex = 10;
            this.btnCalcularRuta.Text = "Calcular";
            this.btnCalcularRuta.UseVisualStyleBackColor = true;
            this.btnCalcularRuta.Click += new System.EventHandler(this.btnCalcularRuta_Click);
            // 
            // cmbRutaFin
            // 
            this.cmbRutaFin.FormattingEnabled = true;
            this.cmbRutaFin.Location = new System.Drawing.Point(66, 73);
            this.cmbRutaFin.Name = "cmbRutaFin";
            this.cmbRutaFin.Size = new System.Drawing.Size(121, 24);
            this.cmbRutaFin.TabIndex = 7;
            // 
            // cmbRutaInicio
            // 
            this.cmbRutaInicio.FormattingEnabled = true;
            this.cmbRutaInicio.Location = new System.Drawing.Point(66, 25);
            this.cmbRutaInicio.Name = "cmbRutaInicio";
            this.cmbRutaInicio.Size = new System.Drawing.Size(121, 24);
            this.cmbRutaInicio.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Fin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Inicio:";
            // 
            // gbConexiones
            // 
            this.gbConexiones.Controls.Add(this.btnCrearRuta);
            this.gbConexiones.Controls.Add(this.cmbDestino);
            this.gbConexiones.Controls.Add(this.cmbOrigen);
            this.gbConexiones.Controls.Add(this.label5);
            this.gbConexiones.Controls.Add(this.label4);
            this.gbConexiones.Location = new System.Drawing.Point(595, 16);
            this.gbConexiones.Name = "gbConexiones";
            this.gbConexiones.Size = new System.Drawing.Size(250, 167);
            this.gbConexiones.TabIndex = 2;
            this.gbConexiones.TabStop = false;
            this.gbConexiones.Text = "Conexiones";
            // 
            // btnCrearRuta
            // 
            this.btnCrearRuta.Location = new System.Drawing.Point(85, 111);
            this.btnCrearRuta.Name = "btnCrearRuta";
            this.btnCrearRuta.Size = new System.Drawing.Size(90, 44);
            this.btnCrearRuta.TabIndex = 10;
            this.btnCrearRuta.Text = "Conectar";
            this.btnCrearRuta.UseVisualStyleBackColor = true;
            this.btnCrearRuta.Click += new System.EventHandler(this.btnCrearRuta_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(66, 73);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(164, 24);
            this.cmbDestino.TabIndex = 7;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(66, 25);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(164, 24);
            this.cmbOrigen.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Origen:";
            // 
            // gbEdificio
            // 
            this.gbEdificio.Controls.Add(this.cmbDepartamento);
            this.gbEdificio.Controls.Add(this.label7);
            this.gbEdificio.Controls.Add(this.btnAgregarEdificio);
            this.gbEdificio.Controls.Add(this.label3);
            this.gbEdificio.Controls.Add(this.tbEdificio);
            this.gbEdificio.Controls.Add(this.pbGrafo);
            this.gbEdificio.Location = new System.Drawing.Point(6, 6);
            this.gbEdificio.Name = "gbEdificio";
            this.gbEdificio.Size = new System.Drawing.Size(539, 411);
            this.gbEdificio.TabIndex = 1;
            this.gbEdificio.TabStop = false;
            this.gbEdificio.Text = "Añadir Edificios:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(111, 59);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(128, 24);
            this.cmbDepartamento.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Departamento:";
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Location = new System.Drawing.Point(409, 20);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(90, 44);
            this.btnAgregarEdificio.TabIndex = 5;
            this.btnAgregarEdificio.Text = "Agregar";
            this.btnAgregarEdificio.UseVisualStyleBackColor = true;
            this.btnAgregarEdificio.Click += new System.EventHandler(this.btnAgregarEdificio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // tbEdificio
            // 
            this.tbEdificio.Location = new System.Drawing.Point(82, 31);
            this.tbEdificio.Name = "tbEdificio";
            this.tbEdificio.Size = new System.Drawing.Size(307, 22);
            this.tbEdificio.TabIndex = 4;
            // 
            // pbGrafo
            // 
            this.pbGrafo.ContextMenuStrip = this.contextMenuStrip2;
            this.pbGrafo.Location = new System.Drawing.Point(9, 98);
            this.pbGrafo.Name = "pbGrafo";
            this.pbGrafo.Size = new System.Drawing.Size(520, 310);
            this.pbGrafo.TabIndex = 0;
            this.pbGrafo.TabStop = false;
            this.pbGrafo.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGrafo_Paint);
            this.pbGrafo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbGrafo_MouseDown);
            this.pbGrafo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbGrafo_MouseMove);
            this.pbGrafo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbGrafo_MouseUp);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEliminarVertice});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(187, 28);
            // 
            // tsmiEliminarVertice
            // 
            this.tsmiEliminarVertice.Name = "tsmiEliminarVertice";
            this.tsmiEliminarVertice.Size = new System.Drawing.Size(186, 24);
            this.tsmiEliminarVertice.Text = "Eliminar Edificio";
            this.tsmiEliminarVertice.Click += new System.EventHandler(this.tsmiEliminarVertice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpJerarquia.ResumeLayout(false);
            this.tbpJerarquia.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tbpRutas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbCalcularRuta.ResumeLayout(false);
            this.gbCalcularRuta.PerformLayout();
            this.gbConexiones.ResumeLayout(false);
            this.gbConexiones.PerformLayout();
            this.gbEdificio.ResumeLayout(false);
            this.gbEdificio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpJerarquia;
        private System.Windows.Forms.TabPage tbpRutas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnborrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecPreorden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstbResultados;
        private System.Windows.Forms.Button btnRecInOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.GroupBox gbEdificio;
        private System.Windows.Forms.Button btnAgregarEdificio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEdificio;
        private System.Windows.Forms.PictureBox pbGrafo;
        private System.Windows.Forms.GroupBox gbConexiones;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrearRuta;
        private System.Windows.Forms.GroupBox gbCalcularRuta;
        private System.Windows.Forms.Button btnCalcularRuta;
        private System.Windows.Forms.ComboBox cmbRutaFin;
        private System.Windows.Forms.ComboBox cmbRutaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstbResultadosGrafo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerificarConexiones;
        private System.Windows.Forms.Button btnMostrarConexiones;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPosicionActual;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbElemento;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarVertice;
    }
}

