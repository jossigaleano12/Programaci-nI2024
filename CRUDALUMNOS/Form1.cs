using System.ComponentModel.Design;
using System.Data.SqlClient;

namespace CRUDALUMNOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_acep_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Carnet = Convert.ToInt32(textBox_Carnet.Text);
            alumno.Nombre = textBox_nom.Text;
            alumno.Telefono = textBox_Num.Text;
            alumno.Grado = textBox1.Text;
            alumno.Usuario = textBox2.Text;

            if (dataGridView1.SelectedRows.Count == 1)
            {

                int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                if (Id != null)
                {

                    alumno.Id = Id;
                    int result = PersonaDal.Modificar(alumno);
                    if (result > 0)
                    {
                        MessageBox.Show("Exito al Modificar");
                    }
                    else
                    {
                        MessageBox.Show("No se modifico");
                    }

                }
            }
            else
            {
                int result = PersonaDal.AgregarAlumno(alumno);
                if (result > 0)
                {
                    MessageBox.Show("Exito al guardar");
                }
                else
                {
                    MessageBox.Show("No se guardo");
                }

            }
            Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            Refresh();
            Focus();
        }
        private void Refresh()
        {
            dataGridView1.DataSource = PersonaDal.PresentarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {


                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                int resultado = PersonaDal.EliminarPersona(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar");
                }
                Refresh();
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox_nom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            textBox_Carnet.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["edad"].Value);
            textBox_Num.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["numero"].Value);
            textBox_id.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);



        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            textBox_nom.Clear();
            textBox_id.Clear();
            textBox_Num.Clear();
            textBox_Carnet.Clear();
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_edad_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
