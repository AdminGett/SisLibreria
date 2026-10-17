using MySqlX.XDevAPI;
using SisLibreria.BConsultas;
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
        public DataTable BuscaGenero()
        {
            return repo.EjecutarSP<DataTable>("tb_busqueda_R_Generos");
        }
        public int RegistroAuor(string Autor)
        {
            return repo.EjecutarSP<int>("tb_busqueda_I_Autor", Autor);
        }
        public int RegistroGenero(string Genreo)
        {
            return repo.EjecutarSP<int>("tb_busqueda_I_Genero", Genreo);
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
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
