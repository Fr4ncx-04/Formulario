namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //obtener los datos de los textbox
            string nombres = tbnombre.Text;
            string apellidos = tbapellido.Text;
            string telefono = tbtelefono.Text;
            string estatura = tbestatura.Text;
            string edad = tbedad.Text;

            //obtener el genero seleccionado
            string genero = "";
            if (rbhombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbmujer.Checked)
            {
                genero = "Mujer";
            }

            //crear una cadena con los datos
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telefono}\r\nEstatura: {estatura} cm\r\nEdad: {edad} anos\r\nGenero: {genero}";

            //guardar los datos en un archivo de texto
            string rutaArchivo = "C:\\Users\\DELL\\Documents\\3er semestre\\programacion avanzada\\formulario.txt";
            //File.WriteAllText(rutaArchivo, datos);
            //Verificar si el archivo ya existe
            bool archivoExiste = File.Exists(rutaArchivo);
            //Console.WriteLine(archivoExiste);
            if (archivoExiste == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    if (archivoExiste)
                    {
                        //si el archivo existe, anadir un separador antes del nuevo registro
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }

                //mostrar un mensaje con los datos capturados
                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            //Limpiar los controles despues de guardar
            tbnombre.Clear();
            tbapellido.Clear();
            tbtelefono.Clear();
            tbestatura.Clear();
            tbedad.Clear();
            rbhombre.Checked = false;
            rbmujer.Checked = false;
        }
    }
}
