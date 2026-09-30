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
    public partial class RegistroAutor : Form
    {
        public RegistroAutor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRegistrarAtor_Click(object sender, EventArgs e)
        {
            var Autor = TxtAutor.Text;

            if (!string.IsNullOrWhiteSpace(Autor))
            {
                using (ComponenteRegistroDB Registro = new ComponenteRegistroDB())
                {
                    int Exitoso = Registro.RegistroAuor(Autor);
                    if (Exitoso == 1)
                    {
                        MessageBox.Show("El autor ya se encuentra registrado.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("El campo Autor esta bacio.", "Campo bacio.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
