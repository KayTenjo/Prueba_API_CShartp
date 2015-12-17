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
            this.buttonListaPuertos = new System.Windows.Forms.Button();
            this.listBoxPuertosDisponibles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInicializarSerial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBaudRate = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPinMode = new System.Windows.Forms.Button();
            this.buttonLeerPinDigital = new System.Windows.Forms.Button();
            this.buttonAnalogRead = new System.Windows.Forms.Button();
            this.buttonAnalogWrite = new System.Windows.Forms.Button();
            this.buttonDigitalWrite = new System.Windows.Forms.Button();
            this.textBoxRecibirDatos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInicializar
            // 
            this.buttonInicializar.Location = new System.Drawing.Point(263, 115);
            this.buttonInicializar.Name = "buttonInicializar";
            this.buttonInicializar.Size = new System.Drawing.Size(102, 36);
            this.buttonInicializar.TabIndex = 0;
            this.buttonInicializar.Text = "Initialize Motors";
            this.buttonInicializar.UseVisualStyleBackColor = true;
            this.buttonInicializar.Click += new System.EventHandler(this.buttonInicializar_Click);
            // 
            // buttonActivar
            // 
            this.buttonActivar.Location = new System.Drawing.Point(371, 115);
            this.buttonActivar.Name = "buttonActivar";
            this.buttonActivar.Size = new System.Drawing.Size(93, 36);
            this.buttonActivar.TabIndex = 1;
            this.buttonActivar.Text = "Activate Motors";
            this.buttonActivar.UseVisualStyleBackColor = true;
            this.buttonActivar.Click += new System.EventHandler(this.buttonActivar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pins (separados por coma)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valores (separados por coma)";
            // 
            // textBoxPines
            // 
            this.textBoxPines.Location = new System.Drawing.Point(263, 36);
            this.textBoxPines.Name = "textBoxPines";
            this.textBoxPines.Size = new System.Drawing.Size(222, 20);
            this.textBoxPines.TabIndex = 4;
            // 
            // textBoxValores
            // 
            this.textBoxValores.Location = new System.Drawing.Point(263, 89);
            this.textBoxValores.Name = "textBoxValores";
            this.textBoxValores.Size = new System.Drawing.Size(222, 20);
            this.textBoxValores.TabIndex = 5;
            // 
            // buttonListaPuertos
            // 
            this.buttonListaPuertos.Location = new System.Drawing.Point(16, 19);
            this.buttonListaPuertos.Name = "buttonListaPuertos";
            this.buttonListaPuertos.Size = new System.Drawing.Size(101, 23);
            this.buttonListaPuertos.TabIndex = 7;
            this.buttonListaPuertos.Text = "Port List";
            this.buttonListaPuertos.UseVisualStyleBackColor = true;
            this.buttonListaPuertos.Click += new System.EventHandler(this.buttonListaPuertos_Click);
            // 
            // listBoxPuertosDisponibles
            // 
            this.listBoxPuertosDisponibles.FormattingEnabled = true;
            this.listBoxPuertosDisponibles.Location = new System.Drawing.Point(16, 91);
            this.listBoxPuertosDisponibles.Name = "listBoxPuertosDisponibles";
            this.listBoxPuertosDisponibles.Size = new System.Drawing.Size(101, 69);
            this.listBoxPuertosDisponibles.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ports";
            // 
            // buttonInicializarSerial
            // 
            this.buttonInicializarSerial.Location = new System.Drawing.Point(124, 19);
            this.buttonInicializarSerial.Name = "buttonInicializarSerial";
            this.buttonInicializarSerial.Size = new System.Drawing.Size(104, 23);
            this.buttonInicializarSerial.TabIndex = 10;
            this.buttonInicializarSerial.Text = "Open Port";
            this.buttonInicializarSerial.UseVisualStyleBackColor = true;
            this.buttonInicializarSerial.Click += new System.EventHandler(this.buttonInicializarSerial_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Baud Rate";
            // 
            // textBoxBaudRate
            // 
            this.textBoxBaudRate.Location = new System.Drawing.Point(127, 91);
            this.textBoxBaudRate.Name = "textBoxBaudRate";
            this.textBoxBaudRate.Size = new System.Drawing.Size(101, 20);
            this.textBoxBaudRate.TabIndex = 12;
            this.textBoxBaudRate.Text = "9600";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Close Port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPinMode
            // 
            this.buttonPinMode.Location = new System.Drawing.Point(263, 157);
            this.buttonPinMode.Name = "buttonPinMode";
            this.buttonPinMode.Size = new System.Drawing.Size(102, 36);
            this.buttonPinMode.TabIndex = 19;
            this.buttonPinMode.Text = "Pin Mode";
            this.buttonPinMode.UseVisualStyleBackColor = true;
            this.buttonPinMode.Click += new System.EventHandler(this.buttonPinMode_Click);
            // 
            // buttonLeerPinDigital
            // 
            this.buttonLeerPinDigital.Location = new System.Drawing.Point(263, 199);
            this.buttonLeerPinDigital.Name = "buttonLeerPinDigital";
            this.buttonLeerPinDigital.Size = new System.Drawing.Size(102, 36);
            this.buttonLeerPinDigital.TabIndex = 20;
            this.buttonLeerPinDigital.Text = "Digital Read";
            this.buttonLeerPinDigital.UseVisualStyleBackColor = true;
            this.buttonLeerPinDigital.Click += new System.EventHandler(this.buttonLeerPinDigital_Click);
            // 
            // buttonAnalogRead
            // 
            this.buttonAnalogRead.Location = new System.Drawing.Point(263, 241);
            this.buttonAnalogRead.Name = "buttonAnalogRead";
            this.buttonAnalogRead.Size = new System.Drawing.Size(102, 36);
            this.buttonAnalogRead.TabIndex = 21;
            this.buttonAnalogRead.Text = "Analog Read";
            this.buttonAnalogRead.UseVisualStyleBackColor = true;
            this.buttonAnalogRead.Click += new System.EventHandler(this.buttonAnalogRead_Click);
            // 
            // buttonAnalogWrite
            // 
            this.buttonAnalogWrite.Location = new System.Drawing.Point(470, 199);
            this.buttonAnalogWrite.Name = "buttonAnalogWrite";
            this.buttonAnalogWrite.Size = new System.Drawing.Size(93, 36);
            this.buttonAnalogWrite.TabIndex = 22;
            this.buttonAnalogWrite.Text = "Analog Write";
            this.buttonAnalogWrite.UseVisualStyleBackColor = true;
            this.buttonAnalogWrite.Click += new System.EventHandler(this.buttonAnalogWrite_Click);
            // 
            // buttonDigitalWrite
            // 
            this.buttonDigitalWrite.Location = new System.Drawing.Point(371, 199);
            this.buttonDigitalWrite.Name = "buttonDigitalWrite";
            this.buttonDigitalWrite.Size = new System.Drawing.Size(93, 36);
            this.buttonDigitalWrite.TabIndex = 23;
            this.buttonDigitalWrite.Text = "Digital Write";
            this.buttonDigitalWrite.UseVisualStyleBackColor = true;
            this.buttonDigitalWrite.Click += new System.EventHandler(this.buttonDigitalWrite_Click);
            // 
            // textBoxRecibirDatos
            // 
            this.textBoxRecibirDatos.Location = new System.Drawing.Point(16, 186);
            this.textBoxRecibirDatos.Multiline = true;
            this.textBoxRecibirDatos.Name = "textBoxRecibirDatos";
            this.textBoxRecibirDatos.Size = new System.Drawing.Size(183, 102);
            this.textBoxRecibirDatos.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Datos Recibidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRecibirDatos);
            this.Controls.Add(this.buttonDigitalWrite);
            this.Controls.Add(this.buttonAnalogWrite);
            this.Controls.Add(this.buttonAnalogRead);
            this.Controls.Add(this.buttonLeerPinDigital);
            this.Controls.Add(this.buttonPinMode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxBaudRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonInicializarSerial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxPuertosDisponibles);
            this.Controls.Add(this.buttonListaPuertos);
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
        private System.Windows.Forms.Button buttonListaPuertos;
        private System.Windows.Forms.ListBox listBoxPuertosDisponibles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInicializarSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBaudRate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPinMode;
        private System.Windows.Forms.Button buttonLeerPinDigital;
        private System.Windows.Forms.Button buttonAnalogRead;
        private System.Windows.Forms.Button buttonAnalogWrite;
        private System.Windows.Forms.Button buttonDigitalWrite;
        private System.Windows.Forms.TextBox textBoxRecibirDatos;
        private System.Windows.Forms.Label label5;
    }
}

