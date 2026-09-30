using SisLibreria.Componentes.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SisLibreria
{
    public partial class RegistroLibro : Form
    {
        public RegistroLibro()
        {
            InitializeComponent();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestrarLibro_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Titulo = TxtTitulo.Text;
            var Autor = TxtAutorLibro.SelectedValue?.ToString();
            var Genero = CbxGenero.SelectedValue?.ToString();
            var Costo = TxtPrecio.Text;
            var Reparacion = CkxRepacionLibro.Checked;

            if (CbxGenero.SelectedValue == null)
            {
                MessageBox.Show("El campo Autor está vacío.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAutorLibro.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(Titulo))
            {
                MessageBox.Show("El campo Autor está vacío.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtTitulo.Focus();
                return;
            }

            if (CbxGenero.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un género válido.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CbxGenero.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(Costo))
            {
                MessageBox.Show("El campo Costo está vacío.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPrecio.Focus();
                return;
            }
            using (ComponenteRegistroDB newRegistro = new ComponenteRegistroDB())
            {
                try
                {
                    int Registro = newRegistro.GuardarLibro(Titulo, Autor, Genero, Costo, Reparacion);
                    if(Registro == 1)
                    {
                        MessageBox.Show("Ya se encuentra registrado el libro", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void RegistroLibro_Load(object sender, EventArgs e)
        {
            LlenadoDeAutor();
            LlenadoDeGenero();

        }
        private void LlenadoDeAutor()
        {
            using (var repo = new ComponenteRegistroDB())
            {
                try
                {
                    DataTable dtAutor = repo.BuscaAutor();

                    DataRow fila = dtAutor.NewRow();
                    fila["Id"] = 0; 
                    fila["Nombre"] = "Seleccionar...";
                    dtAutor.Rows.InsertAt(fila, 0);

                    TxtAutorLibro.DropDownStyle = ComboBoxStyle.DropDownList;

                    TxtAutorLibro.DataSource = dtAutor;
                    TxtAutorLibro.DisplayMember = "Nombre";
                    TxtAutorLibro.ValueMember = "Id";

                    TxtAutorLibro.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LlenadoDeGenero()
        {
            using (var repo = new ComponenteRegistroDB())
            {
                try
                {
                    DataTable dtGeneros = repo.BuscaGenero();
                    DataRow fila = dtGeneros.NewRow();
                    fila["Id"] = 0;
                    fila["Descripcion"] = "Seleccionar...";
                    dtGeneros.Rows.InsertAt(fila, 0);

                    CbxGenero.DropDownStyle = ComboBoxStyle.DropDownList;

                    CbxGenero.DataSource = dtGeneros;
                    CbxGenero.DisplayMember = "Descripcion";
                    CbxGenero.ValueMember = "Id";

                    CbxGenero.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
