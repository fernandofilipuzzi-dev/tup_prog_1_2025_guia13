namespace Parcial2
{
    partial class FormPrincipal
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
            this.btnAgregarExpediente = new System.Windows.Forms.Button();
            this.btnVerListado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerExpedientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.btnMayores = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNroCausa = new System.Windows.Forms.TextBox();
            this.btnVerPorNumero = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarExpediente
            // 
            this.btnAgregarExpediente.Location = new System.Drawing.Point(8, 29);
            this.btnAgregarExpediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarExpediente.Name = "btnAgregarExpediente";
            this.btnAgregarExpediente.Size = new System.Drawing.Size(108, 70);
            this.btnAgregarExpediente.TabIndex = 0;
            this.btnAgregarExpediente.Text = "Registrar Nuevo";
            this.btnAgregarExpediente.UseVisualStyleBackColor = true;
            this.btnAgregarExpediente.Click += new System.EventHandler(this.btnAgregarExpediente_Click);
            // 
            // btnVerListado
            // 
            this.btnVerListado.Location = new System.Drawing.Point(138, 29);
            this.btnVerListado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerListado.Name = "btnVerListado";
            this.btnVerListado.Size = new System.Drawing.Size(103, 70);
            this.btnVerListado.TabIndex = 1;
            this.btnVerListado.Text = "Ver Todos";
            this.btnVerListado.UseVisualStyleBackColor = true;
            this.btnVerListado.Click += new System.EventHandler(this.btnVerListado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerExpedientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDNI);
            this.groupBox1.Location = new System.Drawing.Point(13, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(380, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver Expdientes de una persona";
            // 
            // btnVerExpedientes
            // 
            this.btnVerExpedientes.Location = new System.Drawing.Point(262, 29);
            this.btnVerExpedientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerExpedientes.Name = "btnVerExpedientes";
            this.btnVerExpedientes.Size = new System.Drawing.Size(111, 54);
            this.btnVerExpedientes.TabIndex = 6;
            this.btnVerExpedientes.Text = "Ver Expedientes";
            this.btnVerExpedientes.UseVisualStyleBackColor = true;
            this.btnVerExpedientes.Click += new System.EventHandler(this.btnVerExpedientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(81, 44);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(148, 26);
            this.tbDNI.TabIndex = 0;
            this.tbDNI.Text = "tbDNI";
            // 
            // btnMayores
            // 
            this.btnMayores.Location = new System.Drawing.Point(262, 29);
            this.btnMayores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMayores.Name = "btnMayores";
            this.btnMayores.Size = new System.Drawing.Size(111, 70);
            this.btnMayores.TabIndex = 5;
            this.btnMayores.Text = "Ver Mayores en Monto";
            this.btnMayores.UseVisualStyleBackColor = true;
            this.btnMayores.Click += new System.EventHandler(this.btnMayores_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNroCausa);
            this.groupBox2.Controls.Add(this.btnVerPorNumero);
            this.groupBox2.Location = new System.Drawing.Point(13, 243);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(380, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Expediente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número Causa";
            // 
            // tbNroCausa
            // 
            this.tbNroCausa.Location = new System.Drawing.Point(81, 54);
            this.tbNroCausa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNroCausa.Name = "tbNroCausa";
            this.tbNroCausa.Size = new System.Drawing.Size(148, 26);
            this.tbNroCausa.TabIndex = 7;
            this.tbNroCausa.Text = "tbNroCausa";
            // 
            // btnVerPorNumero
            // 
            this.btnVerPorNumero.Location = new System.Drawing.Point(261, 42);
            this.btnVerPorNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerPorNumero.Name = "btnVerPorNumero";
            this.btnVerPorNumero.Size = new System.Drawing.Size(111, 51);
            this.btnVerPorNumero.TabIndex = 7;
            this.btnVerPorNumero.Text = "Ver";
            this.btnVerPorNumero.UseVisualStyleBackColor = true;
            this.btnVerPorNumero.Click += new System.EventHandler(this.btnVerPorNumero_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregarExpediente);
            this.groupBox3.Controls.Add(this.btnVerListado);
            this.groupBox3.Controls.Add(this.btnMayores);
            this.groupBox3.Location = new System.Drawing.Point(13, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(380, 111);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Expdientes";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 349);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarExpediente;
        private System.Windows.Forms.Button btnVerListado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMayores;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNroCausa;
        private System.Windows.Forms.Button btnVerPorNumero;
        private System.Windows.Forms.Button btnVerExpedientes;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

