using Guna.UI2.WinForms;
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
    public partial class Form1 : Form
    {
        CapaDAO dao = new CapaDAO();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = dao.ListarContactos();
            dataGridView1.ReadOnly = true;
        }

        private void CargarContactos()
        {
            dataGridView1.DataSource = dao.ListarContactos();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dao.InsertarContacto(
                TXTnombre.Text,
                TXTapellido.Text,
                DateTimePicker1.Value,
                TXTdireccion.Text,
                comboBoxGenero.SelectedItem.ToString(),
                comboBoxEstadoCivil.SelectedItem.ToString(),
                TXTmovil.Text,
                TXTtelefono.Text,
                TXTcorreo.Text
            );

            MessageBox.Show("Contacto agregado exitosamente.");
            CargarContactos();

            TXTnombre.Clear();
            TXTnombre.Focus();
            TXTapellido.Clear();
            TXTdireccion.Clear();
            TXTtelefono.Clear();
            TXTmovil.Clear();
            TXTcorreo.Clear();
            comboBoxEstadoCivil.SelectedIndex = -1;
            comboBoxGenero.SelectedIndex = -1;
            DateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.BuscarContacto(TXTbuscar.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Seguro que desea eliminar este contacto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                    dao.EliminarContacto(id);

                    MessageBox.Show("Contacto eliminado");

                    TXTnombre.Clear();
                    TXTnombre.Focus();
                    TXTapellido.Clear();
                    TXTdireccion.Clear();
                    TXTtelefono.Clear();
                    TXTmovil.Clear();
                    TXTcorreo.Clear();
                    comboBoxEstadoCivil.SelectedIndex = -1;
                    comboBoxGenero.SelectedIndex = -1;
                    DateTimePicker1.Value = DateTime.Now;

                    CargarContactos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un contacto para eliminar.");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                dao.ModificarContacto(
                    id,
                    TXTnombre.Text,
                    TXTapellido.Text,
                    DateTimePicker1.Value,
                    TXTdireccion.Text,
                    comboBoxGenero.Text,
                    comboBoxEstadoCivil.Text,
                    TXTmovil.Text,
                    TXTtelefono.Text,
                    TXTcorreo.Text
                );

                MessageBox.Show("Contacto actualizado");

                CargarContactos();
            }
            else
            {
                MessageBox.Show("Seleccione un contacto para modificar.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                dao.ModificarContacto(
                    id,
                    TXTnombre.Text,
                    TXTapellido.Text,
                    DateTimePicker1.Value,
                    TXTdireccion.Text,
                    comboBoxGenero.Text,
                    comboBoxEstadoCivil.Text,
                    TXTmovil.Text,
                    TXTtelefono.Text,
                    TXTcorreo.Text
                );

                MessageBox.Show("Contacto actualizado");

                CargarContactos();
            }
            else
            {
                MessageBox.Show("Seleccione un contacto para modificar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que desea eliminar este contacto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                dao.EliminarContacto(id);

                MessageBox.Show("Contacto eliminado");

                CargarContactos();

                TXTnombre.Clear();
                TXTnombre.Focus();
                TXTapellido.Clear();
                TXTdireccion.Clear();
                TXTtelefono.Clear();
                TXTmovil.Clear();
                TXTcorreo.Clear();
                comboBoxEstadoCivil.SelectedIndex = -1;
                comboBoxGenero.SelectedIndex = -1;
                DateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Seleccione un contacto para eliminar.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TXTnombre.Clear();
            TXTnombre.Focus();
            TXTapellido.Clear();
            TXTdireccion.Clear();
            TXTtelefono.Clear();
            TXTmovil.Clear();
            TXTcorreo.Clear();
            comboBoxEstadoCivil.SelectedIndex = -1;
            comboBoxGenero.SelectedIndex = -1;
            DateTimePicker1.Value = DateTime.Now;
            TXTbuscar.Clear();
        }

    }
}
