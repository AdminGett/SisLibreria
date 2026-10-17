using SisLibreria.Componentes.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisLibreria
{
    public partial class NuevoGenero : Form
    {
        public NuevoGenero()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRegistrarAtor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtGenero.Text))
            {
                var Genreo = TxtGenero.Text;
                using ( ComponenteRegistroDB genero = new ComponenteRegistroDB ())
                {
                    int Exitoso = genero.RegistroGenero(Genreo);
                    if (Exitoso == 0)
                    {
                        MessageBox.Show("El genero se registro de manera Exitosa!", "Existoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("El genero ya se encuentra registrado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("El campo Genero se encuentra vacio.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
