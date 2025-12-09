namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.nudSegundos = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.tmrTemporizador = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbUnidadEntrada = new System.Windows.Forms.ComboBox();
            this.cmbUnidadSalida = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOracion = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnContar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 173);
            this.listBox1.TabIndex = 2;
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(505, 23);
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(120, 20);
            this.nudMinutos.TabIndex = 3;
            // 
            // nudSegundos
            // 
            this.nudSegundos.Location = new System.Drawing.Point(506, 61);
            this.nudSegundos.Name = "nudSegundos";
            this.nudSegundos.Size = new System.Drawing.Size(120, 20);
            this.nudSegundos.TabIndex = 4;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(538, 130);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(35, 13);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "label1";
            this.lblTiempo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(522, 87);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "button2";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tmrTemporizador
            // 
            this.tmrTemporizador.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(522, 258);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(662, 258);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 11;
            // 
            // cmbUnidadEntrada
            // 
            this.cmbUnidadEntrada.FormattingEnabled = true;
            this.cmbUnidadEntrada.Items.AddRange(new object[] {
            "Metros",
            "Centímetros",
            "Pulgadas"});
            this.cmbUnidadEntrada.Location = new System.Drawing.Point(373, 257);
            this.cmbUnidadEntrada.Name = "cmbUnidadEntrada";
            this.cmbUnidadEntrada.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidadEntrada.TabIndex = 12;
            this.cmbUnidadEntrada.SelectedIndexChanged += new System.EventHandler(this.cmbUnidadEntrada_SelectedIndexChanged);
            // 
            // cmbUnidadSalida
            // 
            this.cmbUnidadSalida.FormattingEnabled = true;
            this.cmbUnidadSalida.Items.AddRange(new object[] {
            "Metros",
            "Cetímetros",
            "Pulgadas"});
            this.cmbUnidadSalida.Location = new System.Drawing.Point(373, 294);
            this.cmbUnidadSalida.Name = "cmbUnidadSalida";
            this.cmbUnidadSalida.Size = new System.Drawing.Size(121, 21);
            this.cmbUnidadSalida.TabIndex = 13;
            this.cmbUnidadSalida.SelectedIndexChanged += new System.EventHandler(this.cmbUnidadSalida_SelectedIndexChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(532, 292);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 14;
            this.btnConvertir.Text = "button2";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(188, 385);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 15;
            this.btnVerificar.Text = "button2";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(23, 387);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(122, 20);
            this.txtPalabra.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(788, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "numero primo ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(773, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(786, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtOracion
            // 
            this.txtOracion.Location = new System.Drawing.Point(473, 388);
            this.txtOracion.Name = "txtOracion";
            this.txtOracion.Size = new System.Drawing.Size(100, 20);
            this.txtOracion.TabIndex = 21;
            this.txtOracion.Text = "e";
            this.txtOracion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(502, 431);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 22;
            this.lblResultado.Text = "label5";
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(485, 457);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 23;
            this.btnContar.Text = "button3";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1048, 549);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtOracion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbUnidadSalida);
            this.Controls.Add(this.cmbUnidadEntrada);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.nudSegundos);
            this.Controls.Add(this.nudMinutos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSegundos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstTabla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.NumericUpDown nudSegundos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer tmrTemporizador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cmbUnidadEntrada;
        private System.Windows.Forms.ComboBox cmbUnidadSalida;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOracion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnContar;
    }
}

