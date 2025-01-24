using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WinFormsCliente.Models;

namespace WinFormsCliente.Services
{
    public class AlumnoService
    {
        #region Caso GetAll
        public async Task<List<Alumno>> GetAll()
        {
            var alumnos = new List<Alumno>();
            var url = "http://localhost:5158/api/Alumno";

            var cliente = new HttpClient();
            var response = await cliente.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var Json = await response.Content.ReadAsStringAsync();
                alumnos = JsonSerializer.Deserialize<List<Alumno>>(Json);
            }
            return alumnos;
        }
        #endregion

        #region Caso GetByID
        public async Task<Alumno> GetByID(int id)
        {
            var alumnos = new Alumno();
            var url = "http://localhost:5158/api/Alumno";

            var cliente = new HttpClient();
            var response = await cliente.GetAsync($"{url}/{id}");

            if (response.IsSuccessStatusCode)
            {
                var Json = await response.Content.ReadAsStringAsync();
                alumnos = JsonSerializer.Deserialize<Alumno>(Json);
            }
            return alumnos;
        }
        #endregion

        #region Caso Insert
        public async Task<Alumno> Insert(Alumno a)
        {
            var a2 = new Alumno();
            var url = "http://localhost:5158/api/Alumno";

            var Json = JsonSerializer.Serialize(a);

            var content = new StringContent(Json, Encoding.UTF8, "application/json");
            var cliente = new HttpClient();
            var response = await cliente.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                a2 = JsonSerializer.Deserialize<Alumno>(json);
            }
            return a2;
        }
        #endregion

        #region Caso Update
        public async Task<Alumno> Update(Alumno a)
        {
            var a2 = new Alumno();
            var url = "http://localhost:5158/api/Alumno";

            var Json = JsonSerializer.Serialize(a);

            var content = new StringContent(Json, Encoding.UTF8, "application/json");
            var cliente = new HttpClient();
            var response = await cliente.PutAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                a2 = JsonSerializer.Deserialize<Alumno>(json);
            }
            return a2;
        }
        #endregion

        #region Caso Delete
        public async Task<bool> Delete(int id)
        {
            var url = "http://localhost:5158/api/Alumno";
            var cliente = new HttpClient();
            var response = await cliente.DeleteAsync($"{url}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
