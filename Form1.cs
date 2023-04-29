using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string Base = "basededatos.txt";
            StreamWriter sw= new StreamWriter(Base);

            String nombre = texto.Text;
            String edad = texto1.Text;
            int n = tabla.Rows.Add();
            tabla.Rows[n].Cells[0].Value =nombre;
            tabla.Rows[n].Cells[1].Value = edad;
            sw.WriteLine(nombre);
            sw.WriteLine(edad);
            sw.Close();
           

        }
    }
}