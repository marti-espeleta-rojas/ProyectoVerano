using WebAppServer.DAOs;
using WebAppServer.Models;

namespace WebAppServer.Services
{
    public class AlumnoService
    {
        //CRUD = GetAll, GetByID, Insert, Update, Delete.
        string cadena = "workstation id=MartinianoDB.mssql.somee.com;packet size=4096;user id=martiespeleta_SQLLogin_1;pwd=9yhbu56k4a;data source=MartinianoDB.mssql.somee.com;persist security info=False;initial catalog=MartinianoDB;TrustServerCertificate=True";
        AlumnoDAO alumnoDAO; 
        public AlumnoService()
        {
            alumnoDAO = new AlumnoDAO(cadena);
        }
        List<Alumno> alumnos = new List<Alumno>() 
        {
            new Alumno(){ Nombre = "Jose", ID = 1, LU = 177, Nota = 8},
            new Alumno(){ Nombre = "Máxima", ID = 3, LU = 144, Nota = 9},
            new Alumno(){ Nombre = "Martiniano", ID = 2, LU = 184, Nota = 8}
        };

        #region Caso GetAll
        public List<Alumno> GetAll()
        {
            return alumnoDAO.GetAll().OrderBy(a => a.LU).ToList();
        }
        #endregion

        #region Caso GetByID
        public Alumno? GetByID(int id)
        {
            return alumnoDAO.GetByID(id);
        }
        #endregion

        #region Caso Insert
        public Alumno? Insert(Alumno a)
        {
            return alumnoDAO.Insert(a);
        }
        #endregion

        #region Caso Update
        public bool Update(Alumno a1)
        {
            return alumnoDAO.Update(a1);
        }
        #endregion

        #region Caso Delete
        public bool Delete(int id)
        {
            return alumnoDAO.Delete(id);
        }
        #endregion
    }
}
