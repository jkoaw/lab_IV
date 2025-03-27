namespace lab_IV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wczytaj(string cos)
        {
            if (!File.Exists(cos))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox.Load(cos);
        }
        private void button_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki BMP (*.bmp)|*.bmp|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik BMP do wczytania";
            openFileDialog1.ShowDialog();
            // Jeœli u¿ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywo³anie funkcji wczytuj¹cej dane z pliku CSV
                wczytaj(openFileDialog1.FileName);
            }
        }

        private void button_green_Click(object sender, EventArgs e)
        {
            Bitmap cos = new Bitmap(pictureBox.Image);
            Bitmap cos2 = new Bitmap(cos.Width, cos.Height);
            for (int i = 0; i < cos.Height; i++)
            {
                for (int j = 0; j < cos.Width; j++)
                {
                    Color pixel = cos.GetPixel(j, i);
                    pixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    cos2.SetPixel(j, i, pixel);
                }
            }
            pictureBox.Image = cos2;
        }
    }
}
