﻿namespace SimuladorProcesos
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridViewProcesos = new System.Windows.Forms.DataGridView();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.stripMAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.refernciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMCreditos = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).BeginInit();
            this.mnsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProcesos
            // 
            this.dataGridViewProcesos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.estado,
            this.tiempo,
            this.Prioridad,
            this.Memoria});
            this.dataGridViewProcesos.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewProcesos.Name = "dataGridViewProcesos";
            this.dataGridViewProcesos.Size = new System.Drawing.Size(485, 245);
            this.dataGridViewProcesos.TabIndex = 0;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEjecutar.Image")));
            this.buttonEjecutar.Location = new System.Drawing.Point(12, 278);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(149, 44);
            this.buttonEjecutar.TabIndex = 1;
            this.buttonEjecutar.Text = "INICIAR";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonCorrer_Click);
            // 
            // mnsMain
            // 
            this.mnsMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMAcerca,
            this.stripMCreditos});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(940, 24);
            this.mnsMain.TabIndex = 4;
            this.mnsMain.Text = "menuStrip1";
            // 
            // stripMAcerca
            // 
            this.stripMAcerca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refernciaToolStripMenuItem,
            this.reseñaToolStripMenuItem});
            this.stripMAcerca.Name = "stripMAcerca";
            this.stripMAcerca.Size = new System.Drawing.Size(72, 20);
            this.stripMAcerca.Text = "Acerda de";
            // 
            // refernciaToolStripMenuItem
            // 
            this.refernciaToolStripMenuItem.Name = "refernciaToolStripMenuItem";
            this.refernciaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.refernciaToolStripMenuItem.Text = "Referncia";
            this.refernciaToolStripMenuItem.Click += new System.EventHandler(this.refernciaToolStripMenuItem_Click);
            // 
            // reseñaToolStripMenuItem
            // 
            this.reseñaToolStripMenuItem.Name = "reseñaToolStripMenuItem";
            this.reseñaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.reseñaToolStripMenuItem.Text = "Reseña";
            this.reseñaToolStripMenuItem.Click += new System.EventHandler(this.reseñaToolStripMenuItem_Click);
            // 
            // stripMCreditos
            // 
            this.stripMCreditos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaToolStripMenuItem,
            this.alumnoToolStripMenuItem,
            this.maestroToolStripMenuItem});
            this.stripMCreditos.Name = "stripMCreditos";
            this.stripMCreditos.Size = new System.Drawing.Size(63, 20);
            this.stripMCreditos.Text = "Creditos";
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.materiaToolStripMenuItem.Text = "Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // maestroToolStripMenuItem
            // 
            this.maestroToolStripMenuItem.Name = "maestroToolStripMenuItem";
            this.maestroToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.maestroToolStripMenuItem.Text = "Maestro";
            this.maestroToolStripMenuItem.Click += new System.EventHandler(this.maestroToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(503, 27);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Legend = "Legend1";
            series4.Name = "Consumidor";
            series4.YValuesPerPoint = 2;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(411, 245);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title4.Name = "chart1";
            this.chart1.Titles.Add(title4);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(503, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "CONSUMO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            this.tiempo.Visible = false;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            // 
            // Memoria
            // 
            this.Memoria.HeaderText = "Memoria";
            this.Memoria.Name = "Memoria";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(940, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.mnsMain);
            this.Controls.Add(this.buttonEjecutar);
            this.Controls.Add(this.dataGridViewProcesos);
            this.Name = "MainForm";
            this.Text = "CONSUMIDOR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).EndInit();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProcesos;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem stripMAcerca;
        private System.Windows.Forms.ToolStripMenuItem refernciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripMCreditos;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestroToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memoria;
    }
}

