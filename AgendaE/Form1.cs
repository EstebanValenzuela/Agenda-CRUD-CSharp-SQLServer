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
            // seleccionar un valor por defecto opcional
            comboBoxGenero.SelectedIndex = 0;
            comboBoxEstadoCivil.SelectedIndex = 0;
            dataGridView1.DataSource = dao.ListarContactos();
        }

        private void CargarContactos()
        {
            dataGridView1.DataSource = dao.ListarContactos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dao.InsertarContacto(
                TXTnombre.Text,
                TXTapellido.Text,
                dateTimePicker1.Value,
                TXTdireccion.Text,
                comboBoxGenero.SelectedItem.ToString(),
                comboBoxEstadoCivil.SelectedItem.ToString(),
                TXTmovil.Text,
                TXTtelefono.Text,
                TXTcorreo.Text
            );

            MessageBox.Show("Contacto agregado exitosamente.");
            CargarContactos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.BuscarContacto(TXTbuscar.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

                    CargarContactos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un contacto para eliminar.");
            }
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
                    dateTimePicker1.Value,
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }
    }
}
