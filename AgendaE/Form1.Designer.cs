namespace AgendaE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTdireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTcorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTbuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTmovil = new System.Windows.Forms.MaskedTextBox();
            this.TXTtelefono = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(24, 187);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(245, 22);
            this.TXTnombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // TXTapellido
            // 
            this.TXTapellido.Location = new System.Drawing.Point(24, 215);
            this.TXTapellido.Name = "TXTapellido";
            this.TXTapellido.Size = new System.Drawing.Size(245, 22);
            this.TXTapellido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion";
            // 
            // TXTdireccion
            // 
            this.TXTdireccion.Location = new System.Drawing.Point(24, 271);
            this.TXTdireccion.Name = "TXTdireccion";
            this.TXTdireccion.Size = new System.Drawing.Size(245, 22);
            this.TXTdireccion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genero";
            // 
            // TXTcorreo
            // 
            this.TXTcorreo.Location = new System.Drawing.Point(24, 415);
            this.TXTcorreo.Name = "TXTcorreo";
            this.TXTcorreo.Size = new System.Drawing.Size(245, 22);
            this.TXTcorreo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Esteado civil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Movil";
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Location = new System.Drawing.Point(89, 34);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(245, 22);
            this.TXTbuscar.TabIndex = 10;
            this.TXTbuscar.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Correo electronico";
            // 
            // TXTmovil
            // 
            this.TXTmovil.Location = new System.Drawing.Point(24, 361);
            this.TXTmovil.Mask = "(999)-000-0000";
            this.TXTmovil.Name = "TXTmovil";
            this.TXTmovil.Size = new System.Drawing.Size(245, 22);
            this.TXTmovil.TabIndex = 6;
            // 
            // TXTtelefono
            // 
            this.TXTtelefono.Location = new System.Drawing.Point(24, 384);
            this.TXTtelefono.Mask = "(999)-000-0000";
            this.TXTtelefono.Name = "TXTtelefono";
            this.TXTtelefono.Size = new System.Drawing.Size(245, 22);
            this.TXTtelefono.TabIndex = 7;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.ItemHeight = 16;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Maculino",
            "Femenino",
            "Otro"});
            this.comboBoxGenero.Location = new System.Drawing.Point(24, 300);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(266, 24);
            this.comboBoxGenero.TabIndex = 18;
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.ItemHeight = 16;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Viudo"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(24, 331);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(266, 24);
            this.comboBoxEstadoCivil.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(526, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 649);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 65);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 65);
            this.button3.TabIndex = 13;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 574);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 65);
            this.button4.TabIndex = 13;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(327, 575);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 65);
            this.button5.TabIndex = 14;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 651);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxEstadoCivil);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.TXTtelefono);
            this.Controls.Add(this.TXTmovil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTbuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTcorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTdireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTapellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Agenda.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTdireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTcorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTbuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox TXTmovil;
        private System.Windows.Forms.MaskedTextBox TXTtelefono;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

