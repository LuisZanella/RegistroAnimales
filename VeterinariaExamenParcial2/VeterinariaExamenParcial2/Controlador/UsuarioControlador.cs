using Agencia.BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaExamenParcial2.Modelo;

namespace VeterinariaExamenParcial2.Controlador
{
    class UsuarioControlador
    {
        public bool auntenticarUsuario(Usuario us)
        {
            bool bandera = false;
            Connection conex = new Connection();
            string sqlCadena = "sp_autenticar";
            SqlCommand commando = new SqlCommand(sqlCadena, conex.OpenC());
            commando.CommandType = System.Data.CommandType.StoredProcedure;
            commando.Parameters.AddWithValue("@username", System.Data.SqlDbType.VarChar).Value = us.username;
            commando.Parameters.AddWithValue("@contrasenia", System.Data.SqlDbType.VarChar).Value = us.contrasenia;
            SqlDataReader reader = commando.ExecuteReader();
            while (reader.Read()) bandera = true;

            return bandera;
        }
    }
}
