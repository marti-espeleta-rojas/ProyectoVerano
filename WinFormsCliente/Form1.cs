using WinFormsCliente.Models;
using WinFormsCliente.Services;

namespace WinFormsCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AlumnoService servicio = new AlumnoService();

        #region Caso GetAll
        private async void btnListar_Click(object sender, EventArgs e)
        {
            dgViews.Rows.Clear();
            foreach (var l in await servicio.GetAll())
            {
                dgViews.Rows.Add(new object[] { l.ID, l.Nombre, l.LU, l.Nota });
            }
        }
        #endregion

        #region Caso GetByID

        private async void btnBuscarAlumno_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(tbID.Text);
            dgViews.Rows.Clear();
            var a = await servicio.GetByID(id);
            dgViews.Rows.Add(new object[] { a.ID, a.Nombre, a.LU, a.Nota });

            tbID.Clear();
            tbNombre.Clear();
            tbLU.Clear();
            tbNota.Clear();
        }
        #endregion

        #region Caso Insert
        private async void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            int lu = Convert.ToInt32(tbLU.Text);
            string nombre = tbNombre.Text;
            decimal nota = Convert.ToDecimal(tbNota.Text);

            var a = new Alumno() { ID = id, Nombre = nombre, LU = lu, Nota = nota };
            var a2 = await servicio.Insert(a);


            if (a2 != null)
            {
                MessageBox.Show("Alumno agregado correctamente");
                dgViews.Rows.Clear();
                foreach (var l in await servicio.GetAll())
                {
                    dgViews.Rows.Add(new object[] { l.ID, l.Nombre, l.LU, l.Nota });
                }
            }

            tbID.Clear();
            tbNombre.Clear();
            tbLU.Clear();
            tbNota.Clear();
        }
        #endregion

        #region Caso Update
        private async void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            int lu = Convert.ToInt32(tbLU.Text);
            string nombre = tbNombre.Text;
            decimal nota = Convert.ToDecimal(tbNota.Text);

            var a = new Alumno() { ID = id, Nombre = nombre, LU = lu, Nota = nota };
            var a2 = await servicio.Update(a);

            if (a2 != null)
            {
                MessageBox.Show("El alumno ha sido modificado correctamente");
                dgViews.Rows.Clear();
                dgViews.Rows.Add(new object[] { a2.ID, a2.Nombre, a2.LU, a2.Nota });
            }
        }
        #endregion

        #region Caso Delete
        private async void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            var b = await servicio.Delete(id);
            if (b != true)
            {
                MessageBox.Show("No se pudo hallar al alumno");
            }
            MessageBox.Show("El alumno ha sido eliminado correctamente");
            dgViews.Rows.Clear();
            foreach (var l in await servicio.GetAll())
            {
                dgViews.Rows.Add(new object[] { l.ID, l.Nombre, l.LU, l.Nota });
            }
            tbID.Clear();
            tbLU.Clear();
            tbNombre.Clear();
            tbNota.Clear();
        }
        #endregion



    }
}
