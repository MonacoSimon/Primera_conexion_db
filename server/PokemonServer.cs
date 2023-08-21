using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using directorio;


namespace server

{
    public class PokemonServer
    {
        public List<Pokemon> listas()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; Integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Numero, Nombre, p.Descripcion, UrlImagen, e.Descripcion as tipo, d.Descripcion as debilidad from POKEMONS p, ELEMENTOS e, ELEMENTOS d where e.Id = p.IdTipo and d.Id = p.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.tipo = new Elemento();
                    aux.tipo.Descripcion = (string)lector["tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["debilidad"];



                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
