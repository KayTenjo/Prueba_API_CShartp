namespace Prueba_API_CShartp
{
    partial class Form1
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
            this.buttonInicializar = new System.Windows.Forms.Button();
            this.buttonActivar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPines = new System.Windows.Forms.TextBox();
            this.textBoxValores = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInicializar
            // 
            this.buttonInicializar.Location = new System.Drawing.Point(13, 120);
            this.buttonInicializar.Name = "buttonInicializar";
            this.buttonInicializar.Size = new System.Drawing.Size(75, 23);
            this.buttonInicializar.TabIndex = 0;
            this.buttonInicializar.Text = "Inicializar";
            this.buttonInicializar.UseVisualStyleBackColor = true;
            this.buttonInicializar.Click += new System.EventHandler(this.buttonInicializar_Click);
            // 
            // buttonActivar
            // 
            this.buttonActivar.Location = new System.Drawing.Point(127, 120);
            this.buttonActivar.Name = "buttonActivar";
            this.buttonActivar.Size = new System.Drawing.Size(75, 23);
            this.buttonActivar.TabIndex = 1;
            this.buttonActivar.Text = "Activar";
            this.buttonActivar.UseVisualStyleBackColor = true;
            this.buttonActivar.Click += new System.EventHandler(this.buttonActivar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pines (separados por coma)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valores (separados por coma)";
            // 
            // textBoxPines
            // 
            this.textBoxPines.Location = new System.Drawing.Point(13, 30);
            this.textBoxPines.Name = "textBoxPines";
            this.textBoxPines.Size = new System.Drawing.Size(201, 20);
            this.textBoxPines.TabIndex = 4;
            // 
            // textBoxValores
            // 
            this.textBoxValores.Location = new System.Drawing.Point(13, 83);
            this.textBoxValores.Name = "textBoxValores";
            this.textBoxValores.Size = new System.Drawing.Size(201, 20);
            this.textBoxValores.TabIndex = 5;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(13, 170);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(61, 13);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "Resultado: ";
            this.labelResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 235);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxValores);
            this.Controls.Add(this.textBoxPines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonActivar);
            this.Controls.Add(this.buttonInicializar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInicializar;
        private System.Windows.Forms.Button buttonActivar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPines;
        private System.Windows.Forms.TextBox textBoxValores;
        private System.Windows.Forms.Label labelResultado;
    }
}

