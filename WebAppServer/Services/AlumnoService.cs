using WebAppServer.Models;

namespace WebAppServer.Services
{
    public class AlumnoService
    {
        List<Alumno> alumnos = new List<Alumno>() 
        {
            new Alumno(){ Nombre = "Jose", ID = 1, LU = 177, Nota = 8},
            new Alumno(){ Nombre = "Máxima", ID = 3, LU = 144, Nota = 9},
            new Alumno(){ Nombre = "Martiniano", ID = 2, LU = 184, Nota = 8}
        };

        #region Caso GetAll
        public List<Alumno> GetAll()
        {
            return alumnos;
        }
        #endregion

        #region Caso GetByID
        public Alumno? GetByID(int id)
        {
            return alumnos.Where(a => a.ID == id).FirstOrDefault();//Expresión lambda: una consulta de base de datos en una lista de objetos
        }
        #endregion
    }
}
