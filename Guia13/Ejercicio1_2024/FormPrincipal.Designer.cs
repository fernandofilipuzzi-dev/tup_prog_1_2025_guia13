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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMayores = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(380, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver Expdientes de una persona";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ver Expedientes";
            this.button3.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "tbDNI";
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
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button2);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 54);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "tbNroCausa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ver";
            this.button2.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

