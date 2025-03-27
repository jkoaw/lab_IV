namespace lab_IV
{
    public partial class Form1 : Form
    {
        int wartosc_rotate = 3;
        bool flag = true;
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

        private void button_rotate_Click(object sender, EventArgs e)
        {
            Image cos = pictureBox.Image;
            switch (wartosc_rotate)
            {
                case 0:
                    cos.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox.Image = cos;
                    break;
                case 1:
                    cos.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    pictureBox.Image = cos;
                    break;
                case 2:
                    cos.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    pictureBox.Image = cos;
                    break;
                case 3:
                    break;
                default:
                    break;
            }

        }

        private void checkBox_90_CheckedChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                wartosc_rotate = 0;
                checkBox_180.Checked = false;
                checkBox_270.Checked = false;
                flag = true;
            }

        }

        private void checkBox_180_CheckedChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                wartosc_rotate = 1;
                checkBox_90.Checked = false;
                checkBox_270.Checked = false;
                flag = true;
            }
        }

        private void checkBox_270_CheckedChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                wartosc_rotate = 2;
                checkBox_180.Checked = false;
                checkBox_90.Checked = false;
                flag = true;
            }
        }

        private void button_invert_Click(object sender, EventArgs e)
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

        private void button_upside_Click(object sender, EventArgs e)
        {
            Image cos = pictureBox.Image;
            cos.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox.Image = cos;
        }
    }
}
