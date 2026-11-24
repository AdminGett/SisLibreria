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
    public partial class RegistroAutor : Form
    {
        public RegistroAutor()
        {
            InitializeComponent();
            this.Shown += RegistroAutor_Shown;
        }
        private void RegistroAutor_Shown(object sender, EventArgs e)
        {
            cacargarDatosTable();
        }
        private void cacargarDatosTable()
        {
            List<ModeloAutor> listaAutor = new List<ModeloAutor>
            {
                new ModeloAutor { id = "", Nombre = ""}
            };

            dtAutor.DataSource = listaAutor;
            dtAutor.Columns["id"].Visible = false;
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
                    int Exitoso = 0;
                    string idAutor = "";
                    string nombreAutor = "";
                    DataTable Existe = Registro.BuscaNombreAutor(Autor);
                    foreach (DataRow fila in Existe.Rows)
                    {
                        object VExitoso = fila["Exitoso"];
                        object id = fila["id"];
                        object nombre = fila["NOMBRE"];
                        Exitoso = Convert.ToInt32(VExitoso);
                        idAutor = Convert.ToString(id);
                        nombreAutor = Convert.ToString(nombre);
                    }
                    if (Exitoso == 0)
                    {
                        DialogResult resultado = MessageBox.Show("El nombre " + Autor + " no se encuentra resgsitador" + Environment.NewLine
                            + "¿Gusta hacer el registro del autor?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (resultado == DialogResult.OK)
                        {
                            Existe = Registro.RegistroAuor(Autor);
                            foreach (DataRow fila in Existe.Rows)
                            {
                                object VExiste = fila["Existe"];
                                object id = fila["id"];
                                object nombre = fila["NOMBRE"];
                                Exitoso = Convert.ToInt32(VExiste);
                                idAutor = Convert.ToString(id);
                                nombreAutor = Convert.ToString(nombre);
                            }
                            if (Exitoso == 1)
                            {
                                List<ModeloAutor> listaAutor = new List<ModeloAutor>
                                {
                                    new ModeloAutor { id = idAutor, Nombre = nombreAutor}
                                };

                                dtAutor.DataSource = listaAutor;
                                dtAutor.Columns["id"].Visible = false;
                                TxtAutor.Text = null;
                            }
                            TxtAutor.Text = null;
                        }
                    }
                    else
                    {
                        List<ModeloAutor> listaAutor = new List<ModeloAutor>
                        {
                            new ModeloAutor { id = idAutor, Nombre = nombreAutor}
                        };

                        dtAutor.DataSource = listaAutor;
                        dtAutor.Columns["id"].Visible = false;
                        TxtAutor.Text = null;
                    }

                }
            }
            else
            {
                MessageBox.Show("El campo Autor esta bacio.", "Campo bacio.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dtAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dtAutor.CurrentRow != null)
            {
              
                object valor = dtAutor.CurrentRow.Cells["id"].Value;
                var idAutor = Convert.ToInt32(valor);
                DialogResult resultado = MessageBox.Show("¿Esta seguro de eliminar el autor?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (resultado == DialogResult.OK)
                {
                    using (ComponenteRegistroDB Registro = new ComponenteRegistroDB())
                    {
                        var Exitoso = Registro.EliminarAutor(idAutor);
                        if(Exitoso == 1)
                        {
                            MessageBox.Show("El autor se a borrado de manera correcta.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            List<ModeloAutor> listaAutor = new List<ModeloAutor>
                            {
                                new ModeloAutor { id = "", Nombre = ""}
                            };

                            dtAutor.DataSource = listaAutor;
                            dtAutor.Columns["id"].Visible = false;
                        }
                    }
                }
            }
        }
    }
}
