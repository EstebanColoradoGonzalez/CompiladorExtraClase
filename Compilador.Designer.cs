namespace Compilador
{
    partial class Compilador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compilador));
            this.pestañas = new System.Windows.Forms.TabControl();
            this.consolaTab = new System.Windows.Forms.TabPage();
            this.limpiarSalidaConsolaButton = new System.Windows.Forms.Button();
            this.limpiarEntradaConsolaButton = new System.Windows.Forms.Button();
            this.compilarConsolaButton = new System.Windows.Forms.Button();
            this.salidaConsolaTextBox = new System.Windows.Forms.TextBox();
            this.textoLabel = new System.Windows.Forms.Label();
            this.consolaTextBox = new System.Windows.Forms.TextBox();
            this.archivoTab = new System.Windows.Forms.TabPage();
            this.seleccionarArchivoButton = new System.Windows.Forms.Button();
            this.limpiarSalidaArchivoButton = new System.Windows.Forms.Button();
            this.limpiarEntradaArchivoButton = new System.Windows.Forms.Button();
            this.limpiarCompilarArchivoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.salidaArchivoTextBox = new System.Windows.Forms.TextBox();
            this.tablasTab = new System.Windows.Forms.TabPage();
            this.erroresTab = new System.Windows.Forms.TabPage();
            this.label = new System.Windows.Forms.Label();
            this.pestañas.SuspendLayout();
            this.consolaTab.SuspendLayout();
            this.archivoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pestañas
            // 
            this.pestañas.Controls.Add(this.consolaTab);
            this.pestañas.Controls.Add(this.archivoTab);
            this.pestañas.Controls.Add(this.tablasTab);
            this.pestañas.Controls.Add(this.erroresTab);
            this.pestañas.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pestañas.Location = new System.Drawing.Point(0, 0);
            this.pestañas.Margin = new System.Windows.Forms.Padding(0);
            this.pestañas.Name = "pestañas";
            this.pestañas.SelectedIndex = 0;
            this.pestañas.Size = new System.Drawing.Size(830, 535);
            this.pestañas.TabIndex = 0;
            // 
            // consolaTab
            // 
            this.consolaTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consolaTab.Controls.Add(this.limpiarSalidaConsolaButton);
            this.consolaTab.Controls.Add(this.limpiarEntradaConsolaButton);
            this.consolaTab.Controls.Add(this.compilarConsolaButton);
            this.consolaTab.Controls.Add(this.salidaConsolaTextBox);
            this.consolaTab.Controls.Add(this.textoLabel);
            this.consolaTab.Controls.Add(this.consolaTextBox);
            this.consolaTab.Location = new System.Drawing.Point(4, 30);
            this.consolaTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.consolaTab.Name = "consolaTab";
            this.consolaTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.consolaTab.Size = new System.Drawing.Size(822, 501);
            this.consolaTab.TabIndex = 0;
            this.consolaTab.Text = "Consola";
            this.consolaTab.UseVisualStyleBackColor = true;
            // 
            // limpiarSalidaConsolaButton
            // 
            this.limpiarSalidaConsolaButton.BackColor = System.Drawing.Color.White;
            this.limpiarSalidaConsolaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.limpiarSalidaConsolaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.limpiarSalidaConsolaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.limpiarSalidaConsolaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.limpiarSalidaConsolaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarSalidaConsolaButton.ForeColor = System.Drawing.Color.Black;
            this.limpiarSalidaConsolaButton.Location = new System.Drawing.Point(474, 238);
            this.limpiarSalidaConsolaButton.Margin = new System.Windows.Forms.Padding(0);
            this.limpiarSalidaConsolaButton.Name = "limpiarSalidaConsolaButton";
            this.limpiarSalidaConsolaButton.Size = new System.Drawing.Size(138, 38);
            this.limpiarSalidaConsolaButton.TabIndex = 5;
            this.limpiarSalidaConsolaButton.Text = "Limpiar Salida";
            this.limpiarSalidaConsolaButton.UseVisualStyleBackColor = false;
            this.limpiarSalidaConsolaButton.Click += new System.EventHandler(this.limpiarSalidaConsolaButton_Click);
            // 
            // limpiarEntradaConsolaButton
            // 
            this.limpiarEntradaConsolaButton.BackColor = System.Drawing.Color.White;
            this.limpiarEntradaConsolaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.limpiarEntradaConsolaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.limpiarEntradaConsolaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.limpiarEntradaConsolaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.limpiarEntradaConsolaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarEntradaConsolaButton.ForeColor = System.Drawing.Color.Black;
            this.limpiarEntradaConsolaButton.Location = new System.Drawing.Point(217, 238);
            this.limpiarEntradaConsolaButton.Margin = new System.Windows.Forms.Padding(0);
            this.limpiarEntradaConsolaButton.Name = "limpiarEntradaConsolaButton";
            this.limpiarEntradaConsolaButton.Size = new System.Drawing.Size(138, 38);
            this.limpiarEntradaConsolaButton.TabIndex = 4;
            this.limpiarEntradaConsolaButton.Text = "Limpiar Entrada";
            this.limpiarEntradaConsolaButton.UseVisualStyleBackColor = false;
            this.limpiarEntradaConsolaButton.Click += new System.EventHandler(this.limpiarEntradaConsolaButton_Click);
            // 
            // compilarConsolaButton
            // 
            this.compilarConsolaButton.BackColor = System.Drawing.Color.White;
            this.compilarConsolaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.compilarConsolaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.compilarConsolaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.compilarConsolaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.compilarConsolaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compilarConsolaButton.ForeColor = System.Drawing.Color.Black;
            this.compilarConsolaButton.Location = new System.Drawing.Point(365, 238);
            this.compilarConsolaButton.Margin = new System.Windows.Forms.Padding(0);
            this.compilarConsolaButton.Name = "compilarConsolaButton";
            this.compilarConsolaButton.Size = new System.Drawing.Size(100, 38);
            this.compilarConsolaButton.TabIndex = 3;
            this.compilarConsolaButton.Text = "Compilar";
            this.compilarConsolaButton.UseVisualStyleBackColor = false;
            this.compilarConsolaButton.Click += new System.EventHandler(this.compilarConsolaButton_Click);
            // 
            // salidaConsolaTextBox
            // 
            this.salidaConsolaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salidaConsolaTextBox.BackColor = System.Drawing.Color.Black;
            this.salidaConsolaTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaConsolaTextBox.ForeColor = System.Drawing.Color.White;
            this.salidaConsolaTextBox.Location = new System.Drawing.Point(11, 291);
            this.salidaConsolaTextBox.MaxLength = 999999999;
            this.salidaConsolaTextBox.Multiline = true;
            this.salidaConsolaTextBox.Name = "salidaConsolaTextBox";
            this.salidaConsolaTextBox.ReadOnly = true;
            this.salidaConsolaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salidaConsolaTextBox.Size = new System.Drawing.Size(798, 198);
            this.salidaConsolaTextBox.TabIndex = 2;
            // 
            // textoLabel
            // 
            this.textoLabel.AutoSize = true;
            this.textoLabel.Location = new System.Drawing.Point(7, 5);
            this.textoLabel.Name = "textoLabel";
            this.textoLabel.Size = new System.Drawing.Size(46, 21);
            this.textoLabel.TabIndex = 1;
            this.textoLabel.Text = "Texto";
            // 
            // consolaTextBox
            // 
            this.consolaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consolaTextBox.BackColor = System.Drawing.Color.Black;
            this.consolaTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consolaTextBox.ForeColor = System.Drawing.Color.White;
            this.consolaTextBox.Location = new System.Drawing.Point(11, 29);
            this.consolaTextBox.MaxLength = 999999999;
            this.consolaTextBox.Multiline = true;
            this.consolaTextBox.Name = "consolaTextBox";
            this.consolaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consolaTextBox.Size = new System.Drawing.Size(798, 198);
            this.consolaTextBox.TabIndex = 0;
            // 
            // archivoTab
            // 
            this.archivoTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.archivoTab.Controls.Add(this.label);
            this.archivoTab.Controls.Add(this.seleccionarArchivoButton);
            this.archivoTab.Controls.Add(this.limpiarSalidaArchivoButton);
            this.archivoTab.Controls.Add(this.limpiarEntradaArchivoButton);
            this.archivoTab.Controls.Add(this.limpiarCompilarArchivoButton);
            this.archivoTab.Controls.Add(this.label1);
            this.archivoTab.Controls.Add(this.salidaArchivoTextBox);
            this.archivoTab.Location = new System.Drawing.Point(4, 30);
            this.archivoTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.archivoTab.Name = "archivoTab";
            this.archivoTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.archivoTab.Size = new System.Drawing.Size(822, 501);
            this.archivoTab.TabIndex = 1;
            this.archivoTab.Text = "Archivo";
            this.archivoTab.UseVisualStyleBackColor = true;
            // 
            // seleccionarArchivoButton
            // 
            this.seleccionarArchivoButton.BackColor = System.Drawing.Color.White;
            this.seleccionarArchivoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seleccionarArchivoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.seleccionarArchivoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.seleccionarArchivoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.seleccionarArchivoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seleccionarArchivoButton.ForeColor = System.Drawing.Color.Black;
            this.seleccionarArchivoButton.Location = new System.Drawing.Point(334, 118);
            this.seleccionarArchivoButton.Margin = new System.Windows.Forms.Padding(0);
            this.seleccionarArchivoButton.Name = "seleccionarArchivoButton";
            this.seleccionarArchivoButton.Size = new System.Drawing.Size(162, 38);
            this.seleccionarArchivoButton.TabIndex = 8;
            this.seleccionarArchivoButton.Text = "Seleccionar Archivo";
            this.seleccionarArchivoButton.UseVisualStyleBackColor = false;
            this.seleccionarArchivoButton.Click += new System.EventHandler(this.seleccionarArchivoButton_Click);
            // 
            // limpiarSalidaArchivoButton
            // 
            this.limpiarSalidaArchivoButton.BackColor = System.Drawing.Color.White;
            this.limpiarSalidaArchivoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.limpiarSalidaArchivoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.limpiarSalidaArchivoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.limpiarSalidaArchivoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.limpiarSalidaArchivoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarSalidaArchivoButton.ForeColor = System.Drawing.Color.Black;
            this.limpiarSalidaArchivoButton.Location = new System.Drawing.Point(474, 238);
            this.limpiarSalidaArchivoButton.Margin = new System.Windows.Forms.Padding(0);
            this.limpiarSalidaArchivoButton.Name = "limpiarSalidaArchivoButton";
            this.limpiarSalidaArchivoButton.Size = new System.Drawing.Size(138, 38);
            this.limpiarSalidaArchivoButton.TabIndex = 7;
            this.limpiarSalidaArchivoButton.Text = "Limpiar Salida";
            this.limpiarSalidaArchivoButton.UseVisualStyleBackColor = false;
            this.limpiarSalidaArchivoButton.Click += new System.EventHandler(this.limpiarSalidaArchivoButton_Click);
            // 
            // limpiarEntradaArchivoButton
            // 
            this.limpiarEntradaArchivoButton.BackColor = System.Drawing.Color.White;
            this.limpiarEntradaArchivoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.limpiarEntradaArchivoButton.Enabled = false;
            this.limpiarEntradaArchivoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.limpiarEntradaArchivoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.limpiarEntradaArchivoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.limpiarEntradaArchivoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarEntradaArchivoButton.ForeColor = System.Drawing.Color.Black;
            this.limpiarEntradaArchivoButton.Location = new System.Drawing.Point(217, 238);
            this.limpiarEntradaArchivoButton.Margin = new System.Windows.Forms.Padding(0);
            this.limpiarEntradaArchivoButton.Name = "limpiarEntradaArchivoButton";
            this.limpiarEntradaArchivoButton.Size = new System.Drawing.Size(138, 38);
            this.limpiarEntradaArchivoButton.TabIndex = 6;
            this.limpiarEntradaArchivoButton.Text = "Limpiar Entrada";
            this.limpiarEntradaArchivoButton.UseVisualStyleBackColor = false;
            // 
            // limpiarCompilarArchivoButton
            // 
            this.limpiarCompilarArchivoButton.BackColor = System.Drawing.Color.White;
            this.limpiarCompilarArchivoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.limpiarCompilarArchivoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.limpiarCompilarArchivoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.limpiarCompilarArchivoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.limpiarCompilarArchivoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarCompilarArchivoButton.ForeColor = System.Drawing.Color.Black;
            this.limpiarCompilarArchivoButton.Location = new System.Drawing.Point(365, 238);
            this.limpiarCompilarArchivoButton.Margin = new System.Windows.Forms.Padding(0);
            this.limpiarCompilarArchivoButton.Name = "limpiarCompilarArchivoButton";
            this.limpiarCompilarArchivoButton.Size = new System.Drawing.Size(100, 38);
            this.limpiarCompilarArchivoButton.TabIndex = 5;
            this.limpiarCompilarArchivoButton.Text = "Compilar";
            this.limpiarCompilarArchivoButton.UseVisualStyleBackColor = false;
            this.limpiarCompilarArchivoButton.Click += new System.EventHandler(this.limpiarCompilarArchivoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Archivo";
            // 
            // salidaArchivoTextBox
            // 
            this.salidaArchivoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salidaArchivoTextBox.BackColor = System.Drawing.Color.Black;
            this.salidaArchivoTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaArchivoTextBox.ForeColor = System.Drawing.Color.White;
            this.salidaArchivoTextBox.Location = new System.Drawing.Point(11, 291);
            this.salidaArchivoTextBox.MaxLength = 999999999;
            this.salidaArchivoTextBox.Multiline = true;
            this.salidaArchivoTextBox.Name = "salidaArchivoTextBox";
            this.salidaArchivoTextBox.ReadOnly = true;
            this.salidaArchivoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salidaArchivoTextBox.Size = new System.Drawing.Size(796, 196);
            this.salidaArchivoTextBox.TabIndex = 3;
            // 
            // tablasTab
            // 
            this.tablasTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablasTab.Location = new System.Drawing.Point(4, 30);
            this.tablasTab.Name = "tablasTab";
            this.tablasTab.Padding = new System.Windows.Forms.Padding(3);
            this.tablasTab.Size = new System.Drawing.Size(822, 501);
            this.tablasTab.TabIndex = 2;
            this.tablasTab.Text = "Tablas";
            this.tablasTab.UseVisualStyleBackColor = true;
            // 
            // erroresTab
            // 
            this.erroresTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.erroresTab.Location = new System.Drawing.Point(4, 30);
            this.erroresTab.Name = "erroresTab";
            this.erroresTab.Padding = new System.Windows.Forms.Padding(3);
            this.erroresTab.Size = new System.Drawing.Size(822, 501);
            this.erroresTab.TabIndex = 3;
            this.erroresTab.Text = "Errores";
            this.erroresTab.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(389, 165);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 21);
            this.label.TabIndex = 9;
            // 
            // Compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 532);
            this.Controls.Add(this.pestañas);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Compilador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compilador";
            this.pestañas.ResumeLayout(false);
            this.consolaTab.ResumeLayout(false);
            this.consolaTab.PerformLayout();
            this.archivoTab.ResumeLayout(false);
            this.archivoTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pestañas;
        private System.Windows.Forms.TabPage consolaTab;
        private System.Windows.Forms.TabPage archivoTab;
        private System.Windows.Forms.TextBox consolaTextBox;
        private System.Windows.Forms.TabPage tablasTab;
        private System.Windows.Forms.TabPage erroresTab;
        private System.Windows.Forms.Label textoLabel;
        private System.Windows.Forms.Button compilarConsolaButton;
        private System.Windows.Forms.TextBox salidaConsolaTextBox;
        private System.Windows.Forms.Button limpiarSalidaConsolaButton;
        private System.Windows.Forms.Button limpiarEntradaConsolaButton;
        private System.Windows.Forms.Button limpiarSalidaArchivoButton;
        private System.Windows.Forms.Button limpiarEntradaArchivoButton;
        private System.Windows.Forms.Button limpiarCompilarArchivoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salidaArchivoTextBox;
        private System.Windows.Forms.Button seleccionarArchivoButton;
        private System.Windows.Forms.Label label;
    }
}

