using Mysqlx.Resultset;
using SisLibreria.Componentes.DB;
using SisLibreria.Components.System.Registro;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SisLibreria
{

    public partial class VentaLibro : Form
    {

        List<ModeloVenta> LibrosListaVEnta = new List<ModeloVenta>();
        decimal Total = 0;
        public VentaLibro()
        {
            InitializeComponent();
            this.Shown += VentaLibro_Shown;
        }
        public void VentaLibro_Shown(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;

                buscar();
            }
        }
        private void CargarDatos()
        {
            List<ModeloVenta> listaProductos = new List<ModeloVenta>
            {
                new ModeloVenta { Codigo = " ", Autor = " ",Nombre = " " , Ubicacion = " ",Precio = " " }
            };

            dtVentas.DataSource = listaProductos;
            dtVentas.Columns["Id"].Visible = false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void cbxApartar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxApartar.Checked == true)
            {
                NumeroTicket();
                pnlAbono.Show();
                if (cbxAbono.Checked == true)
                {
                    cbxAbono.Checked = false;
                }
                if (pblCobro.Visible == true)
                {
                    pblCobro.Visible = false;
                }
            }
            else
            {
                pnlAbono.Hide();
                if (pblCobro.Visible == false)
                {
                    pblCobro.Visible = true;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string xmlventa;
            if (!string.IsNullOrWhiteSpace(txtMonetario.Text))
            {
                    if (cbxAbono.Checked == true)
                    {
                        xmlventa = CrearXMLAbono();
                }
                    else if (cbxApartar.Checked == true)
                    {
                        xmlventa = CrearXMLAbono();
                        //GuardarApartado(xmlventa);
                    }
                    else
                    {
                            xmlventa = crearXMLVenta();
                            GuardaarVenta(xmlventa);
                    }
            }
            else
            {
                MessageBox.Show("Hay campos vacios.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxAbono_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAbono.Checked == true)
            {
                pnlApartados.Show();
                if (cbxApartar.Checked == true)
                {
                    cbxApartar.Checked = false;
                }
                if (pblCobro.Visible == true)
                {
                    pblCobro.Visible = false;
                }
            }
            else
            {
                NumeroTicket();
                pnlApartados.Hide();
                if (pblCobro.Visible == false)
                {
                    pblCobro.Visible = true;
                }

            }
        }


        public void buscar()
        {

            var AgregarLibro = TxtBusqueda.Text;

            if (!string.IsNullOrWhiteSpace(TxtBusqueda.Text))
            {
                using (ComponenteRegistroDB BusquedaProcesada = new ComponenteRegistroDB())
                {


                    DataTable estatus = BusquedaProcesada.RegistrosLiterarios(AgregarLibro);


                    var LibroBuscado = estatus.AsEnumerable().Select(row => new ModeloVenta
                    {
                        Codigo = row["Id"].ToString(),
                        Nombre = row["Nombre"].ToString(),
                        Autor = row["Autor"].ToString(),
                        Precio = row["Precio"].ToString(),
                        Ubicacion = row["Ubicacion"].ToString()
                    }).ToList();

                    LibrosListaVEnta.AddRange(LibroBuscado);

                    if (dtVentas.Rows.Count > 0)
                    {
                        dtVentas.DataSource = null;
                    }

                    dtVentas.DataSource = LibrosListaVEnta;

                    if (dtVentas.Columns["Id"] != null)
                    {
                        dtVentas.Columns["Id"].Visible = false;
                    }

                    Total = LibrosListaVEnta.Sum(Pre => Convert.ToDecimal(Pre.Precio));
                    lbPresioNeto.Text = Total.ToString();
                    if (decimal.TryParse(txtMonetario.Text, out decimal pago))
                    {
                        decimal devuelto = pago - Total;
                        lblVuelto.Text = devuelto.ToString();
                    }
                    if (LibrosListaVEnta.Count > 0)
                    {
                        lblEliminarElemento.Visible = true;
                    }
                }


                TxtBusqueda.Text = null;
            }
        }
        public void NumeroTicket()
        {
            using (ComponenteRegistroDB Componente = new ComponenteRegistroDB())
            {
                DataTable NumeroTicket = Componente.NumeroTicket();
                lblTicket.Text = NumeroTicket.Rows[0]["Ticket"].ToString();
            }

        }
        public string crearXMLVenta()
        {
            JsonObject obj = new JsonObject
            {
                ["Libros"] = JsonNode.Parse(JsonSerializer.Serialize(LibrosListaVEnta)),
                ["Recibe"] = txtMonetario.Text,
                ["Cambio"] = lblVuelto.Text,
                ["Total"] = lbPresioNeto.Text
            };

            string json = obj.ToJsonString();

            //string json = JsonSerializer.Serialize(LibrosListaVEnta);

            return json;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Total > 0)
            {
                if (decimal.TryParse(txtMonetario.Text, out decimal pago))
                {
                    decimal devuelto = pago - Total;

                    if (devuelto > 0)
                    {
                        lblVuelto.Text = devuelto.ToString();
                    }
                    else
                    {
                        lblVuelto.Text = "0";
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha iniciado una venta.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GuardaarVenta(string xmlventa)
        {

            if (LibrosListaVEnta.Count > 0)
            {
                try
                {
                    using (ComponenteRegistroDB component = new ComponenteRegistroDB())
                    {

                        var Exitoso = component.NuevaVenta(xmlventa);
                        if (Exitoso == 1)
                        {
                            MessageBox.Show("Registro de venta existosa!.", "Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }

                catch (Exception e)
                {
                    MessageBox.Show("Revisa: " + e.Message + ".", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("No se ha iniciado una venta.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblEliminarElemento_MouseClick(object sender, MouseEventArgs e)
        {
       
            if (dtVentas.SelectedRows.Count > 0)
            {
                var listaEstandar = dtVentas.DataSource as List<ModeloVenta>;

                if (listaEstandar != null)
                {
                    for (int i = dtVentas.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        DataGridViewRow fila = dtVentas.SelectedRows[i];
                        if (!fila.IsNewRow)
                        {
                            ModeloVenta item = fila.DataBoundItem as ModeloVenta;
                            if (item != null)
                            {
                                listaEstandar.Remove(item);
                            }
                        }
                    }

                    dtVentas.DataSource = null;
                    dtVentas.DataSource = listaEstandar;
                    Total = 0;
                    Total = listaEstandar.Sum(Pre => Convert.ToDecimal(Pre.Precio));
                    lbPresioNeto.Text = Total.ToString();
                    if(decimal.TryParse(txtMonetario.Text, out decimal pago))
                    {
                        decimal devuelto = pago - Total;
                        lblVuelto.Text = devuelto.ToString();
                    }
                  
                    if (dtVentas.Columns["Id"] != null)
                    {
                        dtVentas.Columns["Id"].Visible = false;
                    }
                }
               
            }
            else
            {
                MessageBox.Show("No se ha seleccionado uno o mas libros", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }

        private void dtVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string CrearXMLAbono()
        {
            var resultado = "hola";
            return resultado;
        }
    }
}
