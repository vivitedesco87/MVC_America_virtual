using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LibraryDatos
{
    public class Datos
    {
        string conex = string.Empty;

        public Datos()
        {

        }
        public Datos(string con)
        {
            conex = con;
        }

        public List<Paises> ObtenerPaises(string codigo)
        {
            List<Paises> lstPaises = new List<Paises>();
            Paises pa = new Paises();
            using (SqlConnection connection =new SqlConnection(conex))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand("ObtenerPaises", connection);
               
                command.Parameters.AddWithValue("@pais", codigo);
                command.CommandType = CommandType.StoredProcedure;
                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        pa = new Paises();
                        pa.Codigo = reader.GetString(0); 

                        pa.Descrip = reader.GetString(1);
                        lstPaises.Add(pa);
                    }
                    reader.Close();

                    return lstPaises;
                }
                catch (Exception ex)
                {
                    pa = new Paises();
                    pa.Codigo = "Error";
                    pa.Descrip = ex.Message;
                    lstPaises.Add(pa);
                    return lstPaises;
                }
                
            }

        }

        public List<Ciudad> ObtenerCiudad(string codigo,string codPais)
        {
            List<Ciudad> lstCiudad = new List<Ciudad>();
            Ciudad pa = new Ciudad();
            using (SqlConnection connection = new SqlConnection(conex))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand("ObtenerCiudad", connection);

                command.Parameters.AddWithValue("@ciudad", codigo);
                command.Parameters.AddWithValue("@codPais", codPais);
                command.CommandType = CommandType.StoredProcedure;
                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writzng the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        pa = new Ciudad();
                        pa.Codigo = reader.GetString(0);

                        pa.Descrip = reader.GetString(1);
                        lstCiudad.Add(pa);
                    }
                    reader.Close();

                    return lstCiudad;
                }
                catch (Exception ex)
                {
                    pa = new Ciudad();
                    pa.Codigo = "Error";
                    pa.Descrip = ex.Message;
                    lstCiudad.Add(pa);
                    return lstCiudad;
                }

            }

        }

        public string ExisteUSuario(string mail, string pass)
        {
            string respuesta = string.Empty;
            if ((mail == string.Empty && pass == string.Empty) || (mail == string.Empty) || (pass == string.Empty))
            {

               return respuesta = "Error.Ingrese usuario y contraseña";
            }
            using (SqlConnection connection = new SqlConnection(conex))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand("sp_ExisteUsuario", connection);

                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@pass", pass);
                command.CommandType = CommandType.StoredProcedure;
                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                      return  respuesta = "OK";
                    } else
                    {
                       return  respuesta = "Datos Incorrectos";
                    }

               
                   
                    reader.Close();

                   
                }
                catch (Exception ex)
                {

                    return respuesta = "Error," + ex.Message;
                }

            }

        }

        public List<Temperatura> ObtenerTemperatura(string codCiudad,string codPais)
        {
            List<Temperatura> lstTemperatura = new List<Temperatura>();
            Temperatura temp = new Temperatura();
            using (SqlConnection connection = new SqlConnection(conex))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand("sp_ObtenerTemperaturas", connection);

                command.Parameters.AddWithValue("@ciudad", codCiudad);
                command.Parameters.AddWithValue("@pais", codPais);
                command.CommandType = CommandType.StoredProcedure;
                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        temp = new Temperatura();
                        temp.CodigoPais = reader.GetString(0);

                        temp.CodigoCiudad = reader.GetString(1);
                        temp.Dia= reader.GetString(2);
                        temp.GC= reader.GetString(3);
                        temp.GF= reader.GetString(4);
                        lstTemperatura.Add(temp);
                    }
                    reader.Close();

                    return lstTemperatura;
                }
                catch (Exception ex)
                {
                    temp = new Temperatura();
                    temp.Error = "Error";
                   temp.Descrip = ex.Message;
                    lstTemperatura.Add(temp);
                    return lstTemperatura;
                }

            }

        }

    }

    public class Paises
    {

       private string _codigo;
       private string _descrip;
        public string  Codigo {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }
   
        public string Descrip
        {
            get
            {
                return _descrip;
            }
            set
            {
                _descrip = value;
            }
        }
    }


    public class Temperatura
    {

        private string _codigoCiudad;
        private string _codigoPais;
        private string _dia;
        private string _gC;
        private string _gF;
        private string _error;
        private string _descrip;
        public string CodigoCiudad
        {
            get
            {
                return _codigoCiudad;
            }
            set
            {
                _codigoCiudad = value;
            }
        }

        public string Descrip
        {
            get
            {
                return _descrip;
            }
            set
            {
                _descrip = value;
            }
        }

        public string Error
        {
            get
            {
                return _error;
            }
            set
            {
                _error = value;
            }
        }

        public string CodigoPais
        {
            get
            {
                return _codigoPais;
            }
            set
            {
                _codigoPais = value;
            }
        }

        public string Dia
        {
            get
            {
                return _dia;
            }
            set
            {
                _dia = value;
            }
        }

        public string GC
        {
            get
            {
                return _gC;
            }
            set
            {
                _gC = value;
            }
        }

        public string GF
        {
            get
            {
                return _gF;
            }
            set
            {
                _gF = value;
            }
        }
    }

    public class Ciudad
    {

        private string _codigo;
        private string _descrip;
        public string Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }

        public string Descrip
        {
            get
            {
                return _descrip;
            }
            set
            {
                _descrip = value;
            }
        }
    }




}
