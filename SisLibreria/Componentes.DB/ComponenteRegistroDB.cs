using MySqlX.XDevAPI;
using SisLibreria.BConsultas;
using SisLibreria.Components.System.Registro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SisLibreria.Componentes.DB
{
    public class ComponenteRegistroDB : IDisposable
    {
        ConSp repo = new ConSp();
        public ComponenteRegistroDB()
        {
        }
        public DataTable RegistrosLiterarios(string Busqueda)
        {
            return repo.EjecutarSP<DataTable>("tb_busqued_R_Libro", Busqueda);
        }
        public int  GuardarLibro(string Titulo, string Autor, string Genero, string Precio, bool Reparacion)
        {
            return repo.EjecutarSP<int>("tb_Registro_I_Nuevolibro", Titulo,Autor,Genero,Precio,Reparacion);
        }
        public DataTable BuscaAutor()
        {
            return repo.EjecutarSP<DataTable>("tb_busqueda_R_Autores");
        }
        public DataTable BuscaNombreAutor(string Autor)
        {
            return repo.EjecutarSP<DataTable>("tb_CatAutores_R_Autor",Autor);

        }
        public DataTable BuscaGenero()
        {
            return repo.EjecutarSP<DataTable>("tb_busqueda_R_Generos");
        }
        public DataTable RegistroAuor(string Autor)
        {
            return repo.EjecutarSP<DataTable>("tb_busqueda_I_Autor", Autor);
        }
        public DataTable RegistroGenero(string Genreo)
        {
            return repo.EjecutarSP<DataTable>("tb_busqueda_I_Genero", Genreo);
        }
        public DataTable BusquedaGeneros(string valorBusqueda)
        {
            return repo.EjecutarSP<DataTable>("tb_CatGenero_R_ExisteGenero",valorBusqueda);
        }
        public int EliminarGenero(int id)
        {
            return repo.EjecutarSP<int>("tb_CatGenero_D_EliminarGenero", id);
        }
        public DataTable BuscaLibroVenta(string Busqueda)
        {
            return repo.EjecutarSP<DataTable>("tb_busqued_R_LibroVenta", Busqueda);
        }
        public DataTable NumeroTicket()
        {
            return repo.EjecutarSP<DataTable>("tb_Libreria_R_NumeroTicket");
        }
        public int NuevaVenta(string venta)
        {
            return repo.EjecutarSP<int>("tb_Libreria_Venta", venta);
        }
        public int EliminarAutor(int id)
        {
            return repo.EjecutarSP<int>("tb_CatAutores_EliminarAutor",id);
        }
        public DataTable RegistrosLiterariosVenta(string Busqueda)
        {
            return repo.EjecutarSP<DataTable>("tb_BuquedaCompuesta_R_Libros", Busqueda);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
