using SisLibreria.Componentes.DB;
using SisLibreria.Components.System.Registro;
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
            this.Shown += NuevoGenero_Show;

        }
        private void NuevoGenero_Show(object sender, EventArgs e)
        {
            cargardatosTable();
        }
        private void cargardatosTable()
        {
            List<ModeloGenero> listaGenero = new List<ModeloGenero>
            {
                new ModeloGenero{Id="", Nombre = ""}
            };

            dtGenero.DataSource = listaGenero;
            dtGenero.Columns["Id"].Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRegistrarAtor_Click(object sender, EventArgs e)
        {
            string idGenero = "";
            string nombre = "";
            if (!string.IsNullOrEmpty(TxtGenero.Text))
            {
                var GeneroBusqueda = TxtGenero.Text;
                using (ComponenteRegistroDB genero = new ComponenteRegistroDB())
                {
                    DataTable Registro = genero.BusquedaGeneros(GeneroBusqueda);

                    if (Registro != null && Registro.Rows.Count == 0)
                    {
                        DialogResult resultado = MessageBox.Show("El genero " + GeneroBusqueda + " no se encuentra resgsitador" + Environment.NewLine
                           + "¿Gusta hacer el registro del Genero?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        if (resultado == DialogResult.OK)
                        {
                            //registro genero 
                            Registro = genero.RegistroGenero(GeneroBusqueda);
                            if (Registro != null && Registro.Rows.Count > 0)
                            {
                                foreach (DataRow fila in Registro.Rows)
                                {
                                    object id = fila["Id"];
                                    object nombreGenero = fila["Nombre"];
                                    idGenero = Convert.ToString(id);
                                    nombre = Convert.ToString(nombreGenero);
                                }
                                List<ModeloGenero> listaModelo = new List<ModeloGenero> {
                                        new ModeloGenero{ Id=idGenero, Nombre= nombre }
                                    };
                                dtGenero.DataSource = listaModelo;
                                dtGenero.Columns["Id"].Visible = false;
                                TxtGenero.Text = null;
                            }
                        }


                    }
                    else
                    {
                        foreach (DataRow fila in Registro.Rows)
                        {
                            object id = fila["Id"];
                            object nombreGenero = fila["Nombre"];
                            idGenero = Convert.ToString(id);
                            nombre = Convert.ToString(nombreGenero);
                        }
                        List<ModeloGenero> listaGenero = new List<ModeloGenero> {
                                    new ModeloGenero{ Id=idGenero, Nombre= nombre }
                            };
                        dtGenero.DataSource = listaGenero;
                        dtGenero.Columns["Id"].Visible = false;
                        TxtGenero.Text = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("El campo Genero se encuentra vacio.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtGenero.CurrentRow != null) {
                object valor = dtGenero.CurrentRow.Cells["Id"].Value;
                var idGenero = Convert.ToInt32(valor);
                DialogResult resulto = MessageBox.Show("¿Esta seguro de eliminar el Genero?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (resulto == DialogResult.OK)
                {
                    using (ComponenteRegistroDB Registro = new ComponenteRegistroDB())
                    {
                        var Exitoso = Registro.EliminarGenero(idGenero);
                        if (Exitoso == 1)
                        {
                            MessageBox.Show("El genero se a borrado de manera correcta.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            List<ModeloGenero> listaGenero = new List<ModeloGenero>
                            {
                                new ModeloGenero { Id = "", Nombre = ""}
                            };

                            dtGenero.DataSource = listaGenero;
                            dtGenero.Columns["Id"].Visible = false;
                        }
                    }
                }
                
            }
        }
    }
}
