namespace Ejemplo_Laboratorio_05L
{
    partial class Ejemplo
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
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(483, 52);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(75, 23);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Saludo";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(68, 55);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 17);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.TextChanged += new System.EventHandler(this.lblSaludo_TextChanged);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(68, 119);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 17);
            this.lblCambio.TabIndex = 2;
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Items.AddRange(new object[] {
            "SES404",
            "DSP404",
            "DAW404"});
            this.cbMaterias.Location = new System.Drawing.Point(483, 119);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(121, 24);
            this.cbMaterias.TabIndex = 3;
            this.cbMaterias.SelectedIndexChanged += new System.EventHandler(this.cbMaterias_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 182);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(533, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Location = new System.Drawing.Point(71, 226);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(0, 17);
            this.lblInscripcion.TabIndex = 5;
            // 
            // Ejemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 431);
            this.Controls.Add(this.lblInscripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.btnSaludo);
            this.Name = "Ejemplo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblInscripcion;
    }
}

