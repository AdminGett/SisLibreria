using SisLibreria.BConsultas;
using SisLibreria.Componentes.DB;
using System.Data;
using System.Diagnostics;

namespace SisLibreria
{
    public partial class Form1 : Form
    {
        ConSp repo = new ConSp();
        public class Producto
        {

            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Autor { get; set; }
            public string Ubicacion { get; set; }
            public string Precio { get; set; }


        }
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void CargarDatos()
        {
            // 2. Crear la lista con los datos
            List<Producto> listaProductos = new List<Producto>
            {
                new Producto { Codigo = " ", Autor = " ",Nombre = " " , Ubicacion = " ",Precio = " " }
            };

            // 3. Asignar la lista como fuente de datos
            DtLibros.DataSource = listaProductos;
        }

        private void DtLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Busqueda = TxtBusqueda.Text;
            if (!string.IsNullOrWhiteSpace(TxtBusqueda.Text))
            {

               //DataTable estatus = repo.EjecutarSP("tb_busqued_R_Libro", Busqueda);
                using (ComponenteRegistroDB BusquedaProcesada = new ComponenteRegistroDB())
                {
                    DataTable estatus = BusquedaProcesada.RegistrosLiterarios(Busqueda);
                    if (estatus != null && estatus.Rows.Count > 0)
                    {
                        List<Producto> listaProductos = new List<Producto>();
                        foreach (DataRow fila in estatus.Rows)
                        {
                            Producto prod = new Producto
                            {
                                // Reemplaza los nombres entre comillas por el nombre EXACTO de las columnas en MySQL
                                Codigo = fila["Id"].ToString(),
                                Nombre = fila["Nombre"].ToString(),
                                Autor = fila["Autor"].ToString(),
                                Ubicacion = fila["ubicacion"].ToString(),
                                Precio = fila["precio"].ToString()
                            };

                            listaProductos.Add(prod);
                        }
                        DtLibros.DataSource = listaProductos;

                        //groupBox1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros para la búsqueda.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //DtLibros.DataSource = null; 
                    }

                }
                   


                //Debug.WriteLine($"Texto abuscar:{TxtBusqueda.Text}");
                // Conexion.ConexionData conect = new Conexion.ConexionData();
                //conect.ObtenerConexion();
            }
            else
            {
                MessageBox.Show("El campo de busqueda esta bacio", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;


                button1.PerformClick();
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            Color colorFondo = box.Parent != null ? box.Parent.BackColor : this.BackColor;
            e.Graphics.Clear(colorFondo);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }
    }
}
