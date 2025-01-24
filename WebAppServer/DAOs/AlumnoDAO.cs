using Microsoft.Data.SqlClient;
using WebAppServer.Models;

namespace WebAppServer.DAOs
{
    public class AlumnoDAO
    {
        private readonly string cadenaConexion;//lo que hace el readonly es que si una variable tiene un valor, ese valor no se le puede cambiar desde otro lado. Desde que la cadena de conexión recibe un valor, funciona como una constante
        public AlumnoDAO(string cadena)
        {
            cadenaConexion = cadena;
        }

        #region Caso GetAll
        public List<Alumno> GetAll() //Creamos un GetAll que nos devuelve la lista
        {
            var alumnos = new List<Alumno>();//Creamos la lista a retornar

            using var conexion = new SqlConnection(cadenaConexion);//Hacemos la conexión con la base
                                                                   //mediante la URL de cadenaConexion                                     
            conexion.Open();//Abrimos la conexión efectivamente
            var query = "SELECT * FROM Alumnos";//Establecemos la query a ejecutar sobre la base

            using var comando = new SqlCommand(query, conexion);//Creamos el comando con el que vamos a
                                                                //poder ejecutar la query sobre la base

            var reader = comando.ExecuteReader();//con el método nos traemos la respuesta que otorga la
                                                 //query ejecutada sobre la base
            while (reader.Read())
            /*
             * El reader.Read() funciona como un EndOfStream y va leyendo fila por fila para abajo
            leer cada columna por medio del Get[Tipo de dato], pasando por cada columna especificada como
            número dentro de los paréntesis de cada método Get.
            */
            {//Entonces:
                alumnos.Add(new Alumno() //como está dentro de un while, por cada fila va a repetir
                {
                    ID = reader.GetInt32(0), //lee la primer columna del alumno de la fila actual
                    Nombre = reader.GetString(1),//lee la segunda columna del alumno (nombre)
                    LU = reader.GetInt32(2),//lee la tercera (LU)
                    Nota = reader.GetDecimal(3)//termina con la cuarta (Nota)
                });
            }
            return alumnos;
        }
        #endregion

        #region Caso GetByID
        public Alumno? GetByID(int id)
        {
            Alumno alumno = null;

            using var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            var query = "SELECT * FROM Alumnos WHERE ID = @ID";
            using var comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID", id);

            var reader = comando.ExecuteReader();
            while (reader.Read())
            {
                alumno = new Alumno() 
                {
                    ID = reader.GetInt32(0), 
                    Nombre = reader.GetString(1),
                    LU = reader.GetInt32(2),
                    Nota = reader.GetDecimal(3)
                };
            }
            return alumno;
        }
        #endregion

        #region Caso Insert
        public Alumno? Insert(Alumno a)
        {
            using var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            var query = "INSERT INTO Alumnos(Nombre, LU, Nota) OUTPUT INSERTED.ID VALUES (@Nombre, @ID, @LU)";
            using var comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Nombre", a.Nombre);
            comando.Parameters.AddWithValue("@LU", a.LU);
            comando.Parameters.AddWithValue("@Nota", a.Nota);

            int id = (int)comando.ExecuteScalar();
            Alumno? a2 = GetByID(id);
            return a2;
        }
        #endregion

        #region Caso Update
        public bool Update(Alumno a)
        {
            using var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            var query = "UPDATE Alumnos SET Nombre = @Nombre, LU = @LU, Nota = @Nota WHERE ID = @ID";
            using var comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ID", a.ID);
            comando.Parameters.AddWithValue("@Nombre", a.Nombre);
            comando.Parameters.AddWithValue("@LU", a.LU);
            comando.Parameters.AddWithValue("@Nota", a.Nota);

            return true;
        }

        #endregion

        #region Caso Delete
        public bool Delete(int id)
        {
            using var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            var query = "DELETE FROM Alumnos WHERE ID = @ID";

            using var comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@ID", id);

            return true;
        }
        #endregion
    }
}
