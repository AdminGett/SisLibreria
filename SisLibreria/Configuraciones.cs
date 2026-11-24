using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisLibreria
{
    public partial class Configuraciones : Form
    {
        private Color _txtLocalBackOriginal;
        private Color _txtLocalForeOriginal;

        private Color _lblImpresoraBackOriginal;
        private Color _lblImpresoraForeOriginal;

        public Configuraciones()
        {
            InitializeComponent();

        }
        private void Configuraciones_Load(object sender, EventArgs e)
        {
            GuardarEstadoOriginal();
        }
        private void GuardarEstadoOriginal()
        {
            _txtLocalBackOriginal = TxtLocal.BackColor;
            _txtLocalForeOriginal = TxtLocal.ForeColor;

            _lblImpresoraBackOriginal = lblImpresora.BackColor;
            _lblImpresoraForeOriginal = lblImpresora.ForeColor;
        }
        private void btnActualizarAutor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TxtLocal_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirNuevoControl(1);
        }
        private void AbrirNuevoControl(int tipo)
        {
            if (tipo == 1)
            {
                lblFacturas.BackColor = _txtLocalBackOriginal;
                lblFacturas.ForeColor = _txtLocalForeOriginal;

                TxtLocal.BackColor = Color.LightYellow;
                TxtLocal.ForeColor = Color.DarkBlue;
                pnlDatosEstablecimiento.Visible = true;
                pnlFactura.Visible = false;
                pnlImpresora.Visible = false;

                lblImpresora.BackColor = _lblImpresoraBackOriginal;
                lblImpresora.ForeColor = _lblImpresoraForeOriginal;
            }
            else if (tipo == 2)
            {
                TxtLocal.BackColor = _txtLocalBackOriginal;
                TxtLocal.ForeColor = _txtLocalForeOriginal;
                lblFacturas.BackColor = _txtLocalBackOriginal;
                lblFacturas.ForeColor = _txtLocalForeOriginal;

                lblImpresora.BackColor = Color.LightYellow;
                lblImpresora.ForeColor = Color.DarkBlue;
                pnlImpresora.Visible = true;
                pnlDatosEstablecimiento.Visible = false;
                pnlFactura.Visible = false;
            }
            else
            {
                lblImpresora.BackColor = _txtLocalBackOriginal;
                lblImpresora.ForeColor = _txtLocalForeOriginal;
                TxtLocal.BackColor = _txtLocalBackOriginal;
                TxtLocal.ForeColor = _txtLocalForeOriginal;

                lblFacturas.BackColor = Color.LightYellow;
                lblFacturas.ForeColor = Color.DarkBlue;
                pnlFactura.Visible = true;
                pnlDatosEstablecimiento.Visible = false;
                pnlImpresora.Visible = false;

            }
        }

        private void lblImpresora_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirNuevoControl(2);
        }

        private void lblFacturas_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirNuevoControl(3);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizalogo_Click(object sender, EventArgs e)
        {

        }
    }
}
