using System;
using System.Drawing;
using System.Windows.Forms;
using Accord.Imaging.Filters;

namespace AccordImageEditor
{
    public partial class MainForm : Form
    {
        private Bitmap originalImage;
        private Bitmap currentImage;

        public MainForm()
        {
            InitializeComponent();
        }

        // 1. Открытие файла
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    originalImage?.Dispose();
                    currentImage?.Dispose();

                    originalImage = new Bitmap(ofd.FileName);
                    currentImage = new Bitmap(originalImage);
                    picBox.Image = currentImage;

                    // Блокируем возможность увеличения (только уменьшение)
                    UpdateResizeLimits();

                    // Разблокируем бинаризацию для нового изображения
                    btnBinarize.Enabled = true;
                }
            }
        }

        // 2. Сохранение файла
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show("Нет изображения для сохранения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    currentImage.Save(sfd.FileName);
                    MessageBox.Show("Изображение успешно сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 3. Сброс к оригиналу
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            currentImage?.Dispose();
            currentImage = new Bitmap(originalImage);
            picBox.Image = currentImage;

            // Сброс лимитов размеров и разблокировка ЧБ
            UpdateResizeLimits();
            trackThreshold.Value = 128;
            btnBinarize.Enabled = true;
        }

        // Вспомогательный метод контроля размеров (запрет на увеличение)
        private void UpdateResizeLimits()
        {
            if (currentImage == null) return;

            // Максимум равен текущему размеру — картинку можно только уменьшать
            numWidth.Maximum = currentImage.Width;
            numHeight.Maximum = currentImage.Height;

            numWidth.Value = currentImage.Width;
            numHeight.Value = currentImage.Height;
        }

        // Универсальный метод применения фильтров Accord
        private void ApplyFilter(IFilter filter, bool requiresGrayscale = false)
        {
            if (currentImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Bitmap processed;

                if (requiresGrayscale)
                {
                    using (Bitmap gray = Grayscale.CommonAlgorithms.BT709.Apply(currentImage))
                    {
                        processed = filter.Apply(gray);
                    }
                }
                else
                {
                    processed = filter.Apply(currentImage);
                }

                currentImage.Dispose();
                currentImage = processed;
                picBox.Image = currentImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Функция: Уменьшение размера
        private void btnResize_Click(object sender, EventArgs e)
        {
            int targetWidth = (int)numWidth.Value;
            int targetHeight = (int)numHeight.Value;

            if (targetWidth == currentImage.Width && targetHeight == currentImage.Height)
            {
                MessageBox.Show("Размеры совпадают с текущими. Укажите меньшие значения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ApplyFilter(new ResizeBilinear(targetWidth, targetHeight));
            UpdateResizeLimits(); // Пересчитываем лимиты для нового уменьшенного состояния
        }

        // Функция: Увеличение резкости границ
        private void btnSharpen_Click(object sender, EventArgs e)
        {
            ApplyFilter(new Sharpen());
        }

        // Функция: Удаление шумов (Размытие Гаусса)
        private void btnBlur_Click(object sender, EventArgs e)
        {
            double sigma = (double)numBlurSigma.Value;
            ApplyFilter(new GaussianBlur(sigma, 5));
        }

        // Функция: Пороговая бинаризация (ЧБ)
        private void btnBinarize_Click(object sender, EventArgs e)
        {
            int thresholdValue = trackThreshold.Value;
            ApplyFilter(new Threshold(thresholdValue), requiresGrayscale: true);

            // Блокируем кнопку после одного нажатия
            btnBinarize.Enabled = false;
        }
    }
}