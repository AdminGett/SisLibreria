using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisLibreria
{
    public partial class EmergenteOpciones : Form
    {
        public EmergenteOpciones()
        {
            InitializeComponent();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            Color colorFondo = box.Parent != null ? box.Parent.BackColor : this.BackColor;
            e.Graphics.Clear(colorFondo);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            RegistroLibro NewLibro = new RegistroLibro();
            NewLibro.Show();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRAutor_Click(object sender, EventArgs e)
        {
            RegistroAutor NewAutor = new RegistroAutor();
            NewAutor.Show();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNuevoGenero_Click(object sender, EventArgs e)
        {
            NuevoGenero Genero = new NuevoGenero();
            Genero.Show();
            
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
