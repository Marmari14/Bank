using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank
{
    public partial class Catpcha : Form
    {
        Authorization authorization;
        private string text = String.Empty;

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };
            Graphics g = Graphics.FromImage((Image)result);
            g.Clear(Color.Gray);
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            // Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            // Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }
        public Catpcha(Authorization f)
        {
            authorization= f;
            InitializeComponent();
        }

        private void Capcha_Load(object sender, EventArgs e)
        {
            pictureCapcha.Image = CreateImage(pictureCapcha.Width, pictureCapcha.Height);
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            pictureCapcha.Image = CreateImage(pictureCapcha.Width, pictureCapcha.Height);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textCapcha.Text == text)
            {
                authorization.SetValid = true;
                Close();
            }
            else
                MessageBox.Show("Текст с картинки введен неверно!", "Ошибка");
        }
    }
}
