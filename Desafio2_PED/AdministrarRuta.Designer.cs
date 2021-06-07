
namespace Desafio2_PED
{
    partial class AdministrarRuta
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCoordenadas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboxDestino = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guiaTuristicoDataSet = new Desafio2_PED.GuiaTuristicoDataSet();
            this.cmboxOrigen = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cmboxPuntoDestino = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cmboxPuntoOrigen = new System.Windows.Forms.ComboBox();
            this.cIUDADBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cIUDADTableAdapter = new Desafio2_PED.GuiaTuristicoDataSetTableAdapters.CIUDADTableAdapter();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.panelMapa = new System.Windows.Forms.Panel();
            this.caminoTableAdapter = new Desafio2_PED.GuiaTuristicoDataSetTableAdapters.CAMINOTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EliminarCamino = new System.Windows.Forms.Button();
            this.comboBoxCaminos = new System.Windows.Forms.ComboBox();
            this.EliminarCiudad = new System.Windows.Forms.Button();
            this.comboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaTuristicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "GUIA TURISTICO DE EL SALVADOR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCoordenadas);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(38, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punto De Referencia";
            // 
            // labelCoordenadas
            // 
            this.labelCoordenadas.AutoSize = true;
            this.labelCoordenadas.Location = new System.Drawing.Point(47, 44);
            this.labelCoordenadas.Name = "labelCoordenadas";
            this.labelCoordenadas.Size = new System.Drawing.Size(24, 13);
            this.labelCoordenadas.TabIndex = 4;
            this.labelCoordenadas.Text = "X,Y";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(191, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.peso);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmboxDestino);
            this.groupBox2.Controls.Add(this.cmboxOrigen);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(38, 590);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Caminos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Peso";
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(294, 42);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(120, 20);
            this.peso.TabIndex = 9;
            this.peso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Origen";
            // 
            // cmboxDestino
            // 
            this.cmboxDestino.DataSource = this.cIUDADBindingSource1;
            this.cmboxDestino.DisplayMember = "nombre";
            this.cmboxDestino.FormattingEnabled = true;
            this.cmboxDestino.Location = new System.Drawing.Point(149, 41);
            this.cmboxDestino.Name = "cmboxDestino";
            this.cmboxDestino.Size = new System.Drawing.Size(121, 21);
            this.cmboxDestino.TabIndex = 6;
            this.cmboxDestino.ValueMember = "codigo_ciudad";
            // 
            // cIUDADBindingSource1
            // 
            this.cIUDADBindingSource1.DataMember = "CIUDAD";
            this.cIUDADBindingSource1.DataSource = this.guiaTuristicoDataSet;
            // 
            // guiaTuristicoDataSet
            // 
            this.guiaTuristicoDataSet.DataSetName = "GuiaTuristicoDataSet";
            this.guiaTuristicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmboxOrigen
            // 
            this.cmboxOrigen.DataSource = this.cIUDADBindingSource;
            this.cmboxOrigen.DisplayMember = "nombre";
            this.cmboxOrigen.FormattingEnabled = true;
            this.cmboxOrigen.Location = new System.Drawing.Point(6, 41);
            this.cmboxOrigen.Name = "cmboxOrigen";
            this.cmboxOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmboxOrigen.TabIndex = 5;
            this.cmboxOrigen.ValueMember = "codigo_ciudad";
            // 
            // cIUDADBindingSource
            // 
            this.cIUDADBindingSource.DataMember = "CIUDAD";
            this.cIUDADBindingSource.DataSource = this.guiaTuristicoDataSet;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(454, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.cmboxPuntoDestino);
            this.groupBox3.Controls.Add(this.cmboxPuntoOrigen);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(797, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 414);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Obtener Ruta";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(24, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Obtener Camino";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmboxPuntoDestino
            // 
            this.cmboxPuntoDestino.DataSource = this.cIUDADBindingSource3;
            this.cmboxPuntoDestino.DisplayMember = "nombre";
            this.cmboxPuntoDestino.FormattingEnabled = true;
            this.cmboxPuntoDestino.Location = new System.Drawing.Point(24, 138);
            this.cmboxPuntoDestino.Name = "cmboxPuntoDestino";
            this.cmboxPuntoDestino.Size = new System.Drawing.Size(121, 21);
            this.cmboxPuntoDestino.TabIndex = 3;
            this.cmboxPuntoDestino.ValueMember = "codigo_ciudad";
            // 
            // cIUDADBindingSource3
            // 
            this.cIUDADBindingSource3.DataMember = "CIUDAD";
            this.cIUDADBindingSource3.DataSource = this.guiaTuristicoDataSet;
            // 
            // cmboxPuntoOrigen
            // 
            this.cmboxPuntoOrigen.DataSource = this.cIUDADBindingSource2;
            this.cmboxPuntoOrigen.DisplayMember = "nombre";
            this.cmboxPuntoOrigen.FormattingEnabled = true;
            this.cmboxPuntoOrigen.Location = new System.Drawing.Point(19, 67);
            this.cmboxPuntoOrigen.Name = "cmboxPuntoOrigen";
            this.cmboxPuntoOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmboxPuntoOrigen.TabIndex = 2;
            this.cmboxPuntoOrigen.ValueMember = "codigo_ciudad";
            // 
            // cIUDADBindingSource2
            // 
            this.cIUDADBindingSource2.DataMember = "CIUDAD";
            this.cIUDADBindingSource2.DataSource = this.guiaTuristicoDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Punto Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Punto Inicial";
            // 
            // cIUDADTableAdapter
            // 
            this.cIUDADTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Location = new System.Drawing.Point(44, 714);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.ReadOnly = true;
            this.textBoxRuta.Size = new System.Drawing.Size(100, 20);
            this.textBoxRuta.TabIndex = 6;
            // 
            // panelMapa
            // 
            this.panelMapa.BackgroundImage = global::Desafio2_PED.Properties.Resources.MapaElSalvador1;
            this.panelMapa.Location = new System.Drawing.Point(38, 50);
            this.panelMapa.Name = "panelMapa";
            this.panelMapa.Size = new System.Drawing.Size(753, 414);
            this.panelMapa.TabIndex = 0;
            this.panelMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMapa_Paint);
            this.panelMapa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMapa_MouseClick);
            // 
            // caminoTableAdapter
            // 
            this.caminoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EliminarCamino);
            this.groupBox4.Controls.Add(this.comboBoxCaminos);
            this.groupBox4.Controls.Add(this.EliminarCiudad);
            this.groupBox4.Controls.Add(this.comboBoxCiudades);
            this.groupBox4.Location = new System.Drawing.Point(596, 590);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gestion Caminos y Ciudades";
            // 
            // EliminarCamino
            // 
            this.EliminarCamino.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarCamino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarCamino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EliminarCamino.Location = new System.Drawing.Point(220, 61);
            this.EliminarCamino.Name = "EliminarCamino";
            this.EliminarCamino.Size = new System.Drawing.Size(75, 23);
            this.EliminarCamino.TabIndex = 3;
            this.EliminarCamino.Text = "Eliminar";
            this.EliminarCamino.UseVisualStyleBackColor = false;
            this.EliminarCamino.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBoxCaminos
            // 
            this.comboBoxCaminos.FormattingEnabled = true;
            this.comboBoxCaminos.Location = new System.Drawing.Point(29, 63);
            this.comboBoxCaminos.Name = "comboBoxCaminos";
            this.comboBoxCaminos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCaminos.TabIndex = 2;
            // 
            // EliminarCiudad
            // 
            this.EliminarCiudad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EliminarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarCiudad.Location = new System.Drawing.Point(220, 28);
            this.EliminarCiudad.Name = "EliminarCiudad";
            this.EliminarCiudad.Size = new System.Drawing.Size(75, 23);
            this.EliminarCiudad.TabIndex = 1;
            this.EliminarCiudad.Text = "Eliminar";
            this.EliminarCiudad.UseVisualStyleBackColor = false;
            this.EliminarCiudad.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // comboBoxCiudades
            // 
            this.comboBoxCiudades.DataSource = this.cIUDADBindingSource;
            this.comboBoxCiudades.DisplayMember = "nombre";
            this.comboBoxCiudades.FormattingEnabled = true;
            this.comboBoxCiudades.Location = new System.Drawing.Point(29, 25);
            this.comboBoxCiudades.Name = "comboBoxCiudades";
            this.comboBoxCiudades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCiudades.TabIndex = 0;
            this.comboBoxCiudades.ValueMember = "codigo_ciudad";
            // 
            // AdministrarRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 779);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdministrarRuta";
            this.Text = "AdministrarRuta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministrarRuta_FormClosing);
            this.Load += new System.EventHandler(this.AdministrarRuta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaTuristicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIUDADBindingSource2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelCoordenadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboxDestino;
        private System.Windows.Forms.ComboBox cmboxOrigen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown peso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmboxPuntoDestino;
        private System.Windows.Forms.ComboBox cmboxPuntoOrigen;
        private GuiaTuristicoDataSet guiaTuristicoDataSet;
        private System.Windows.Forms.BindingSource cIUDADBindingSource;
        private GuiaTuristicoDataSetTableAdapters.CIUDADTableAdapter cIUDADTableAdapter;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.Panel panelMapa;
        private GuiaTuristicoDataSetTableAdapters.CAMINOTableAdapter caminoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button EliminarCiudad;
        private System.Windows.Forms.ComboBox comboBoxCiudades;
        private System.Windows.Forms.Button EliminarCamino;
        private System.Windows.Forms.ComboBox comboBoxCaminos;
        private System.Windows.Forms.BindingSource cIUDADBindingSource1;
        private System.Windows.Forms.BindingSource cIUDADBindingSource2;
        private System.Windows.Forms.BindingSource cIUDADBindingSource3;
    }
}