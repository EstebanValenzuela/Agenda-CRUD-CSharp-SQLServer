using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaE
{
    public partial class Login : Form
    {
        Datos conexion = new Datos();
        CapaDAO capadao = new CapaDAO();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //button1.Enabled = false; 
            TextBox2.PasswordChar = '*';
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1️⃣ Validar campos vacíos
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 👈 IMPORTANTE
            }

            // 2️⃣ Validar en la base de datos
            string resultado = capadao.ValidarUsuario(TextBox1.Text, TextBox2.Text);

            switch (resultado)
            {
                case "Error":
                    MessageBox.Show("Error al conectar a la base de datos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "UsuarioNoExiste":
                    MessageBox.Show("Usuario no encontrado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "ClaveIncorrecta":
                    MessageBox.Show("Contraseña incorrecta.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "OK":
                    this.Hide();
                    Form1 mainForm = new Form1();
                    mainForm.ShowDialog();
                    this.Close();
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                TextBox2.PasswordChar = '*';
            }
            else
            {
                TextBox2.PasswordChar = '\0';
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox2.PlaceholderText = "Usuario";
            TextBox2.BorderRadius = 10;
        }
    

        private void textbox2_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
