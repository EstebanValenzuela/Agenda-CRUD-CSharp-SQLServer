using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            textBox2.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1️⃣ Validar campos vacíos
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 👈 IMPORTANTE
            }

            // 2️⃣ Validar en la base de datos
            string resultado = capadao.ValidarUsuario(textBox1.Text, textBox2.Text);

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
                textBox2.PasswordChar = '*';
            }
            else
            {
                textBox2.PasswordChar = '\0';
            }
        }
    }
}
