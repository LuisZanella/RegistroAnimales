using Agencia.BD;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaExamenParcial2.Modelo;

namespace VeterinariaExamenParcial2.Controlador
{
    class AnimalControlador
    {
        ObservableCollection<Animal> vAN = new ObservableCollection<Animal>();
        List<Animal> _AutosUsados = new List<Animal>();
        public ObservableCollection<Animal> All()
        {
            Connection _conectar = new Connection();
            Animal _animal = null;
            string sqlConsult = "SELECT * FROM Animal;";
            SqlCommand comand = new SqlCommand(sqlConsult, _conectar.OpenC());
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                _animal = new Animal();
                _animal.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                _animal.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                _animal.Precio = reader.GetDouble(reader.GetOrdinal("Precio"));
                _animal.Tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                vAN.Add(_animal);
            }
            _conectar.CloseC();
            return vAN;
        }
        public String InsertarAnimal(Animal animalR)
        {
            Connection _con = new Connection();
            string sql = "sp_agregar";
            SqlCommand comando = new SqlCommand(sql, _con.OpenC());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", System.Data.SqlDbType.VarChar).Value = animalR.Nombre;
            comando.Parameters.AddWithValue("@precio", System.Data.SqlDbType.Float).Value = animalR.Precio;
            comando.Parameters.AddWithValue("@tipo", System.Data.SqlDbType.VarChar).Value = animalR.Tipo;
            comando.ExecuteNonQuery();
            _con.CloseC();
            return "Animal Registrado";
        }
    }
}
