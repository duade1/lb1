using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pb.Image == null)
            {
                MessageBox.Show("В PictureBox нет изображения для сохранения!",
                                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.Filter = "Изображение JPEG (*.jpg)|*.jpg|Изображение PNG (*.png)|*.png|Рисунок BMP (*.bmp)|*.bmp";
            saveFileDialog1.Title = "Сохранить изображение как...";
            saveFileDialog1.FileName = "my_image";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Jpeg;

                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 2:
                            format = System.Drawing.Imaging.ImageFormat.Png;
                            break;
                        case 3:
                            format = System.Drawing.Imaging.ImageFormat.Bmp;
                            break;
                    }

                    pb.Image.Save(saveFileDialog1.FileName, format);

                    MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            if (pb.Image == null)
            {
                pb.Image = new Bitmap(pb.Width, pb.Height);
            }
            using (Graphics g = Graphics.FromImage(pb.Image))
            {
                g.Clear(Color.White);
            }
            pb.Refresh();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы изображений (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Все файлы (*.*)|*.*";
            openFileDialog1.Title = "Выберите изображение для загрузки";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pb.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось загрузить изображение: {ex.Message}",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool isDrawingMode = false;
        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancel();
            if (!isDrawingMode)
            {
                isDrawingMode = !isDrawingMode;
                кругToolStripMenuItem.Checked = !кругToolStripMenuItem.Checked;
            }
        }
        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            if (isDrawingMode)
            {

                Color randomColor = Color.FromArgb(180, rand.Next(256), rand.Next(256), rand.Next(256));
                int diameter = rand.Next(20, 100);

                int x = e.X - (diameter / 2);
                int y = e.Y - (diameter / 2);

                using (Graphics g = Graphics.FromImage(pb.Image))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    using (SolidBrush brush = new SolidBrush(randomColor))
                    {
                        g.FillEllipse(brush, x, y, diameter, diameter);
                    }
                }
            }
            else if (isConcentricMode)
            {
                int circlesCount = rand.Next(3, 9);

                Color randomColor = Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256));

                int thickness = rand.Next(1, 4);

                using (Graphics g = Graphics.FromImage(pb.Image))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    using (Pen pen = new Pen(randomColor, thickness))
                    {
                        int currentRadius = 0;

                        for (int i = 0; i < circlesCount; i++)
                        {
                            currentRadius += rand.Next(10, 31);

                            int diameter = currentRadius * 2;

                            int x = e.X - currentRadius;
                            int y = e.Y - currentRadius;

                            g.DrawEllipse(pen, x, y, diameter, diameter);
                        }
                    }
                }
            }
            else if (isSequenceMode)
            {
                clickCount++;

                if (clickCount == 1)
                {
                    firstClickPoint = e.Location;
                }
                else if (clickCount == 2)
                {
                    Point secondClickPoint = e.Location;
                    clickCount = 0;
                    int circlesCount = rand.Next(5, 12);
                    int startRadius = rand.Next(30, 60);
                    int radiusStep = rand.Next(3, 6);
                    Color randomColor = Color.FromArgb(150, rand.Next(256), rand.Next(256), rand.Next(256));

                    using (Graphics g = Graphics.FromImage(pb.Image))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        using (SolidBrush brush = new SolidBrush(randomColor))
                        {
                            for (int i = 0; i < circlesCount; i++)
                            {
                                
                                int currentRadius = Math.Max(2, startRadius - (i * radiusStep));
                                int diameter = currentRadius * 2;

                                float t = (float)i / (circlesCount - 1);

                                float centerX = firstClickPoint.X + (secondClickPoint.X - firstClickPoint.X) * t;
                                float centerY = firstClickPoint.Y + (secondClickPoint.Y - firstClickPoint.Y) * t;

                                float x = centerX - currentRadius;
                                float y = centerY - currentRadius;

                                g.FillEllipse(brush, x, y, diameter, diameter);
                            }
                        }
                    }
                }
            }
            pb.Refresh();
        }
        private bool isConcentricMode = false;

        private void концентраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancel();
            if (!isConcentricMode)
            {
                isConcentricMode = !isConcentricMode;
                концентраToolStripMenuItem.Checked = !концентраToolStripMenuItem.Checked;
            }
        }
        private void cancel() {
            кругToolStripMenuItem.Checked = false;
            isDrawingMode = false;
            isConcentricMode = false;
            концентраToolStripMenuItem.Checked = false;
            isSequenceMode = false;
            последовательностьКруговToolStripMenuItem.Checked = false;
        }
        private bool isSequenceMode = false;
        private Point firstClickPoint;
        private int clickCount = 0;
        private void последовательностьКруговToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancel();
            if (!isSequenceMode)
            {
                isSequenceMode = !isSequenceMode;
                последовательностьКруговToolStripMenuItem.Checked = !последовательностьКруговToolStripMenuItem.Checked;
            }
        }
    }
}
