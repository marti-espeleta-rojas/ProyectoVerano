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

        #region Caso Insert
        public Alumno Insert(Alumno a)
        {
            alumnos.Add(a);
            return a;
        }
        #endregion

        #region Caso Update
        public bool Update(Alumno a1)
        {
            var a2 = GetByID(a1.ID);
            if (a2 != null)
            {
                a2.Nombre = a1.Nombre;
                a2.LU = a1.LU;
                a2.Nota = a1.Nota;
                return true;
            }
            return false;
        }
        #endregion

        #region Caso Delete
        public bool Delete(int id)
        {
            var alumno = GetByID(id);
            if (alumno != null)
            {
                alumnos.Remove(alumno);
                return true;
            }
            return false;
        }
        #endregion
    }
}
