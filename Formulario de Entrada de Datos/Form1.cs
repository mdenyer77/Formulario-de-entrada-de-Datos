using System.Text;

namespace Formulario_de_entrada_de_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("Femenino");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos deben estar llenos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGuardar_Click_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivos de texto (*.txt)|*.txt";
            guardar.Title = "Guardar archivo de empleados";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder datos = new StringBuilder();

                datos.AppendLine("ID\tNombre\tApellido\tDirección\tTeléfono\tEmail\tCargo\tSalario\tFecha Ingreso\tGénero");
                datos.AppendLine("---------------------------------------------------------------------------------------------------------");
                datos.AppendLine(
                    $"{txtID.Text}\t{txtNombre.Text}\t{txtApellido.Text}\t{txtDireccion.Text}\t" +
                    $"{txtTelefono.Text}\t{txtEmail.Text}\t{txtCargo.Text}\t{txtSalario.Text}\t" +
                    $"{dtpFechaIngreso.Value.ToShortDateString()}\t{cmbGenero.Text}");

                File.WriteAllText(guardar.FileName, datos.ToString());

                MessageBox.Show("Archivo guardado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de texto (*.txt)|*.txt";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                var path = abrir.FileName;
                if (!System.IO.File.Exists(path))
                {
                    MessageBox.Show("El archivo no existe: " + path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "open"
                    };

                    System.Diagnostics.Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el archivo. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
