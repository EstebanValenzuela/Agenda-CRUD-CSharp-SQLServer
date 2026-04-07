using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTmovil = new System.Windows.Forms.MaskedTextBox();
            this.TXTtelefono = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXTbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTnombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTapellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTdireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.TXTcorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxEstadoCivil = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.button3 = new Guna.UI2.WinForms.Guna2Button();
            this.button4 = new Guna.UI2.WinForms.Guna2Button();
            this.button5 = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Esteado civil:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Movil:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telefono:";
            // 
            // TXTmovil
            // 
            this.TXTmovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTmovil.Location = new System.Drawing.Point(230, 541);
            this.TXTmovil.Mask = "(999)-000-0000";
            this.TXTmovil.Name = "TXTmovil";
            this.TXTmovil.Size = new System.Drawing.Size(290, 22);
            this.TXTmovil.TabIndex = 6;
            // 
            // TXTtelefono
            // 
            this.TXTtelefono.Location = new System.Drawing.Point(230, 597);
            this.TXTtelefono.Mask = "(999)-000-0000";
            this.TXTtelefono.Name = "TXTtelefono";
            this.TXTtelefono.Size = new System.Drawing.Size(290, 22);
            this.TXTtelefono.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 18;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(526, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 961);
            this.dataGridView1.TabIndex = 21;
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Animated = true;
            this.TXTbuscar.AutoRoundedCorners = true;
            this.TXTbuscar.BorderColor = System.Drawing.Color.Gray;
            this.TXTbuscar.BorderRadius = 21;
            this.TXTbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTbuscar.DefaultText = "";
            this.TXTbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTbuscar.ForeColor = System.Drawing.Color.Black;
            this.TXTbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTbuscar.Location = new System.Drawing.Point(24, 13);
            this.TXTbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.PlaceholderText = "Buscar en agenda";
            this.TXTbuscar.SelectedText = "";
            this.TXTbuscar.Size = new System.Drawing.Size(245, 44);
            this.TXTbuscar.TabIndex = 9;
            // 
            // TXTnombre
            // 
            this.TXTnombre.Animated = true;
            this.TXTnombre.AutoRoundedCorners = true;
            this.TXTnombre.BorderColor = System.Drawing.Color.Gray;
            this.TXTnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTnombre.DefaultText = "";
            this.TXTnombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTnombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTnombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTnombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTnombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTnombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTnombre.ForeColor = System.Drawing.Color.Black;
            this.TXTnombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTnombre.Location = new System.Drawing.Point(230, 106);
            this.TXTnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.PlaceholderText = "Nombre";
            this.TXTnombre.SelectedText = "";
            this.TXTnombre.Size = new System.Drawing.Size(290, 33);
            this.TXTnombre.TabIndex = 0;
            // 
            // TXTapellido
            // 
            this.TXTapellido.Animated = true;
            this.TXTapellido.AutoRoundedCorners = true;
            this.TXTapellido.BorderColor = System.Drawing.Color.Gray;
            this.TXTapellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTapellido.DefaultText = "";
            this.TXTapellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTapellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTapellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTapellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTapellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTapellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTapellido.ForeColor = System.Drawing.Color.Black;
            this.TXTapellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTapellido.Location = new System.Drawing.Point(230, 169);
            this.TXTapellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTapellido.Name = "TXTapellido";
            this.TXTapellido.PlaceholderText = "Apellido";
            this.TXTapellido.SelectedText = "";
            this.TXTapellido.Size = new System.Drawing.Size(290, 33);
            this.TXTapellido.TabIndex = 1;
            // 
            // TXTdireccion
            // 
            this.TXTdireccion.Animated = true;
            this.TXTdireccion.AutoRoundedCorners = true;
            this.TXTdireccion.BorderColor = System.Drawing.Color.Gray;
            this.TXTdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTdireccion.DefaultText = "";
            this.TXTdireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTdireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTdireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTdireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTdireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTdireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTdireccion.ForeColor = System.Drawing.Color.Black;
            this.TXTdireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTdireccion.Location = new System.Drawing.Point(230, 315);
            this.TXTdireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTdireccion.Name = "TXTdireccion";
            this.TXTdireccion.PlaceholderText = "Direccion";
            this.TXTdireccion.SelectedText = "";
            this.TXTdireccion.Size = new System.Drawing.Size(290, 33);
            this.TXTdireccion.TabIndex = 3;
            // 
            // TXTcorreo
            // 
            this.TXTcorreo.Animated = true;
            this.TXTcorreo.AutoRoundedCorners = true;
            this.TXTcorreo.BorderColor = System.Drawing.Color.Gray;
            this.TXTcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTcorreo.DefaultText = "";
            this.TXTcorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTcorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTcorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTcorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTcorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTcorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTcorreo.ForeColor = System.Drawing.Color.Black;
            this.TXTcorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTcorreo.Location = new System.Drawing.Point(230, 655);
            this.TXTcorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTcorreo.Name = "TXTcorreo";
            this.TXTcorreo.PlaceholderText = "Direccion de correo elecrtonico";
            this.TXTcorreo.SelectedText = "";
            this.TXTcorreo.Size = new System.Drawing.Size(290, 33);
            this.TXTcorreo.TabIndex = 8;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.AutoRoundedCorners = true;
            this.comboBoxGenero.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxGenero.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxGenero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxGenero.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGenero.ItemHeight = 30;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Maculino",
            "Femenino",
            "Otro"});
            this.comboBoxGenero.Location = new System.Drawing.Point(230, 391);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(290, 36);
            this.comboBoxGenero.TabIndex = 4;
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.AutoRoundedCorners = true;
            this.comboBoxEstadoCivil.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEstadoCivil.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxEstadoCivil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoCivil.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEstadoCivil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEstadoCivil.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEstadoCivil.ItemHeight = 30;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Divorciado/a",
            "Viudo/a"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(230, 461);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(290, 36);
            this.comboBoxEstadoCivil.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Animated = true;
            this.button1.AutoRoundedCorners = true;
            this.button1.BorderRadius = 21;
            this.button1.BorderThickness = 1;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 751);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Guardar";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Animated = true;
            this.button3.AutoRoundedCorners = true;
            this.button3.BorderRadius = 21;
            this.button3.BorderThickness = 1;
            this.button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button3.FillColor = System.Drawing.Color.DarkKhaki;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(303, 751);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Eliminar";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Animated = true;
            this.button4.AutoRoundedCorners = true;
            this.button4.BorderRadius = 21;
            this.button4.BorderThickness = 1;
            this.button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button4.FillColor = System.Drawing.Color.DarkKhaki;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 844);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "Modificar";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Animated = true;
            this.button5.AutoRoundedCorners = true;
            this.button5.BorderRadius = 21;
            this.button5.BorderThickness = 1;
            this.button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button5.FillColor = System.Drawing.Color.DarkKhaki;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(303, 844);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 45);
            this.button5.TabIndex = 14;
            this.button5.Text = "Limpiar";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Animated = true;
            this.button2.AutoRoundedCorners = true;
            this.button2.BorderRadius = 21;
            this.button2.BorderThickness = 1;
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.FillColor = System.Drawing.Color.DarkKhaki;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(275, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Buscar";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 666);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Correo electronico:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Location = new System.Drawing.Point(230, 255);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(290, 22);
            this.DateTimePicker1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1405, 963);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxEstadoCivil);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.TXTcorreo);
            this.Controls.Add(this.TXTdireccion);
            this.Controls.Add(this.TXTapellido);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.TXTbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTtelefono);
            this.Controls.Add(this.TXTmovil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda.";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox TXTmovil;
        private System.Windows.Forms.MaskedTextBox TXTtelefono;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox TXTbuscar;
        private Guna.UI2.WinForms.Guna2TextBox TXTnombre;
        private Guna.UI2.WinForms.Guna2TextBox TXTapellido;
        private Guna.UI2.WinForms.Guna2TextBox TXTdireccion;
        private Guna.UI2.WinForms.Guna2TextBox TXTcorreo;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxGenero;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxEstadoCivil;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button button3;
        private Guna.UI2.WinForms.Guna2Button button4;
        private Guna.UI2.WinForms.Guna2Button button5;
        private Guna.UI2.WinForms.Guna2Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
    }
}

