using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;



namespace Galeria
{

    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mostrar("C:\\Users\\julio\\source\\repos\\Topicos\\Galeria\\Img\\1.jpg", "Este es timon, donde esta pumba?");
           
        }

        private void Mostrar(String Rutaimg, String MSJ)
        {
            ImagenForm ventanaImagen = new ImagenForm(Rutaimg, MSJ);
            ventanaImagen.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mostrar("C:\\Users\\julio\\source\\repos\\Topicos\\Galeria\\Img\\2.jpg", "Este es un panda rojo");
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mostrar("C:\\Users\\julio\\source\\repos\\Topicos\\Galeria\\Img\\3.jpg", "Este es una panda");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Mostrar("C:\\Users\\julio\\source\\repos\\Topicos\\Galeria\\Img\\4.jpg", "Este es una ardilla");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Mostrar("C:\\Users\\julio\\source\\repos\\Topicos\\Galeria\\Img\\5.jpg", "Este ya no se que es");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Mostrar("C:\\Users\\julio\\source\\repos\\Topicos\\Galeria\\Img\\6.jpg", "Este es una koala");
        }

    }
    

    public class ImagenForm : Form
    {
        public ImagenForm(string rutaImagen, String MSJ)
        {
            this.Text = "Imagen mostrada";
            this.Size = new Size(600, 400);

            
            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile(rutaImagen),
                SizeMode = PictureBoxSizeMode.Zoom, // Ajusta la imagen sin deformarla
                Dock = DockStyle.Fill
            };

            Label label = new Label
            {
                Text = MSJ,
                Location = new Point(50, 0),
                Size = new Size(500, 30),
                ForeColor = Color.Red,
                Font = new Font("Times New Roman", 20, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(label);
            this.Controls.Add(pictureBox);
        }
       

    }
}
