namespace Compilador
{
    partial class Compilador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compilador));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxConsola = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSeleccionarArchivo = new System.Windows.Forms.Button();
            this.radioButtonConsola = new System.Windows.Forms.RadioButton();
            this.radioButtonArchivo = new System.Windows.Forms.RadioButton();
            this.buttonLimpiarEntrada = new System.Windows.Forms.Button();
            this.buttonLimpiarSalida = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxConsola);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxConsola
            // 
            this.textBoxConsola.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.textBoxConsola, "textBoxConsola");
            this.textBoxConsola.ForeColor = System.Drawing.Color.White;
            this.textBoxConsola.Name = "textBoxConsola";
            this.textBoxConsola.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.textBoxResultado, "textBoxResultado");
            this.textBoxResultado.ForeColor = System.Drawing.Color.White;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonCargar
            // 
            resources.ApplyResources(this.buttonCargar, "buttonCargar");
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonSeleccionarArchivo);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonSeleccionarArchivo
            // 
            resources.ApplyResources(this.buttonSeleccionarArchivo, "buttonSeleccionarArchivo");
            this.buttonSeleccionarArchivo.Name = "buttonSeleccionarArchivo";
            this.buttonSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.buttonSeleccionarArchivo.Click += new System.EventHandler(this.buttonSeleccionarArchivo_Click);
            // 
            // radioButtonConsola
            // 
            resources.ApplyResources(this.radioButtonConsola, "radioButtonConsola");
            this.radioButtonConsola.Checked = true;
            this.radioButtonConsola.Name = "radioButtonConsola";
            this.radioButtonConsola.TabStop = true;
            this.radioButtonConsola.UseVisualStyleBackColor = true;
            this.radioButtonConsola.CheckedChanged += new System.EventHandler(this.radioButtonConsola_CheckedChanged);
            // 
            // radioButtonArchivo
            // 
            resources.ApplyResources(this.radioButtonArchivo, "radioButtonArchivo");
            this.radioButtonArchivo.Name = "radioButtonArchivo";
            this.radioButtonArchivo.UseVisualStyleBackColor = true;
            this.radioButtonArchivo.CheckedChanged += new System.EventHandler(this.radioButtonArchivo_CheckedChanged);
            // 
            // buttonLimpiarEntrada
            // 
            resources.ApplyResources(this.buttonLimpiarEntrada, "buttonLimpiarEntrada");
            this.buttonLimpiarEntrada.Name = "buttonLimpiarEntrada";
            this.buttonLimpiarEntrada.UseVisualStyleBackColor = true;
            this.buttonLimpiarEntrada.Click += new System.EventHandler(this.buttonLimpiarEntrada_Click);
            // 
            // buttonLimpiarSalida
            // 
            resources.ApplyResources(this.buttonLimpiarSalida, "buttonLimpiarSalida");
            this.buttonLimpiarSalida.Name = "buttonLimpiarSalida";
            this.buttonLimpiarSalida.UseVisualStyleBackColor = true;
            this.buttonLimpiarSalida.Click += new System.EventHandler(this.buttonLimpiarSalida_Click);
            // 
            // Compilador
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonLimpiarSalida);
            this.Controls.Add(this.buttonLimpiarEntrada);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.radioButtonArchivo);
            this.Controls.Add(this.radioButtonConsola);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.textBoxResultado);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Compilador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxConsola;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonConsola;
        private System.Windows.Forms.RadioButton radioButtonArchivo;
        private System.Windows.Forms.Button buttonSeleccionarArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLimpiarEntrada;
        private System.Windows.Forms.Button buttonLimpiarSalida;
    }
}

