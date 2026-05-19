namespace AccordImageEditor
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTitleResize = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnResize = new System.Windows.Forms.Button();
            this.lblTitleSharpen = new System.Windows.Forms.Label();
            this.btnSharpen = new System.Windows.Forms.Button();
            this.lblTitleBlur = new System.Windows.Forms.Label();
            this.lblSigma = new System.Windows.Forms.Label();
            this.numBlurSigma = new System.Windows.Forms.NumericUpDown();
            this.btnBlur = new System.Windows.Forms.Button();
            this.lblTitleBinarize = new System.Windows.Forms.Label();
            this.trackThreshold = new System.Windows.Forms.TrackBar();
            this.btnBinarize = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.panelControls);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.picBox);
            this.splitMain.Size = new System.Drawing.Size(1034, 691);
            this.splitMain.SplitterDistance = 300;
            this.splitMain.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.AutoScroll = true;
            this.panelControls.Controls.Add(this.btnOpen);
            this.panelControls.Controls.Add(this.btnSave);
            this.panelControls.Controls.Add(this.btnReset);
            this.panelControls.Controls.Add(this.lblTitleResize);
            this.panelControls.Controls.Add(this.lblWidth);
            this.panelControls.Controls.Add(this.numWidth);
            this.panelControls.Controls.Add(this.lblHeight);
            this.panelControls.Controls.Add(this.numHeight);
            this.panelControls.Controls.Add(this.btnResize);
            this.panelControls.Controls.Add(this.lblTitleSharpen);
            this.panelControls.Controls.Add(this.btnSharpen);
            this.panelControls.Controls.Add(this.lblTitleBlur);
            this.panelControls.Controls.Add(this.lblSigma);
            this.panelControls.Controls.Add(this.numBlurSigma);
            this.panelControls.Controls.Add(this.btnBlur);
            this.panelControls.Controls.Add(this.lblTitleBinarize);
            this.panelControls.Controls.Add(this.trackThreshold);
            this.panelControls.Controls.Add(this.btnBinarize);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(300, 691);
            this.panelControls.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(15, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(80, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(105, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(195, 15);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 40);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTitleResize
            // 
            this.lblTitleResize.AutoSize = true;
            this.lblTitleResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitleResize.Location = new System.Drawing.Point(15, 75);
            this.lblTitleResize.Name = "lblTitleResize";
            this.lblTitleResize.Size = new System.Drawing.Size(142, 13);
            this.lblTitleResize.Text = "Уменьшение размера:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(15, 102);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(49, 13);
            this.lblWidth.Text = "Ширина:";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(70, 100);
            this.numWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(60, 20);
            this.numWidth.TabIndex = 3;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(145, 102);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(48, 13);
            this.lblHeight.Text = "Высота:";
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(200, 100);
            this.numHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(60, 20);
            this.numHeight.TabIndex = 4;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(15, 130);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(260, 30);
            this.btnResize.TabIndex = 5;
            this.btnResize.Text = "Уменьшить размер";
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // lblTitleSharpen
            // 
            this.lblTitleSharpen.AutoSize = true;
            this.lblTitleSharpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitleSharpen.Location = new System.Drawing.Point(15, 180);
            this.lblTitleSharpen.Name = "lblTitleSharpen";
            this.lblTitleSharpen.Size = new System.Drawing.Size(146, 13);
            this.lblTitleSharpen.Text = "Контуры и детекция:";
            // 
            // btnSharpen
            // 
            this.btnSharpen.Location = new System.Drawing.Point(15, 205);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(260, 30);
            this.btnSharpen.TabIndex = 6;
            this.btnSharpen.Text = "Увеличить резкость границ";
            this.btnSharpen.Click += new System.EventHandler(this.btnSharpen_Click);
            // 
            // lblTitleBlur
            // 
            this.lblTitleBlur.AutoSize = true;
            this.lblTitleBlur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitleBlur.Location = new System.Drawing.Point(15, 255);
            this.lblTitleBlur.Name = "lblTitleBlur";
            this.lblTitleBlur.Size = new System.Drawing.Size(104, 13);
            this.lblTitleBlur.Text = "Удаление шумов:";
            // 
            // lblSigma
            // 
            this.lblSigma.AutoSize = true;
            this.lblSigma.Location = new System.Drawing.Point(15, 282);
            this.lblSigma.Name = "lblSigma";
            this.lblSigma.Size = new System.Drawing.Size(42, 13);
            this.lblSigma.Text = "Sigma:";
            // 
            // numBlurSigma
            // 
            this.numBlurSigma.DecimalPlaces = 1;
            this.numBlurSigma.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.numBlurSigma.Location = new System.Drawing.Point(70, 280);
            this.numBlurSigma.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numBlurSigma.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.numBlurSigma.Name = "numBlurSigma";
            this.numBlurSigma.Size = new System.Drawing.Size(60, 20);
            this.numBlurSigma.TabIndex = 7;
            this.numBlurSigma.Value = new decimal(new int[] { 14, 0, 0, 65536 });
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(15, 310);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(260, 30);
            this.btnBlur.TabIndex = 8;
            this.btnBlur.Text = "Удалить шум (Сгладить)";
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // lblTitleBinarize
            // 
            this.lblTitleBinarize.AutoSize = true;
            this.lblTitleBinarize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitleBinarize.Location = new System.Drawing.Point(15, 360);
            this.lblTitleBinarize.Name = "lblTitleBinarize";
            this.lblTitleBinarize.Size = new System.Drawing.Size(176, 13);
            this.lblTitleBinarize.Text = "Черно-белое (Бинаризация):";
            // 
            // trackThreshold
            // 
            this.trackThreshold.Location = new System.Drawing.Point(15, 385);
            this.trackThreshold.Maximum = 255;
            this.trackThreshold.Name = "trackThreshold";
            this.trackThreshold.Size = new System.Drawing.Size(260, 45);
            this.trackThreshold.TabIndex = 9;
            this.trackThreshold.Value = 128;
            // 
            // btnBinarize
            // 
            this.btnBinarize.Location = new System.Drawing.Point(15, 435);
            this.btnBinarize.Name = "btnBinarize";
            this.btnBinarize.Size = new System.Drawing.Size(260, 30);
            this.btnBinarize.TabIndex = 10;
            this.btnBinarize.Text = "Применить порог";
            this.btnBinarize.Click += new System.EventHandler(this.btnBinarize_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(730, 691);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 691);
            this.Controls.Add(this.splitMain);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мини-Редактор Изображений (Accord.NET)";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlurSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.PictureBox picBox;

        // Кнопки управления файлами
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;

        // Элементы масштабирования
        private System.Windows.Forms.Label lblTitleResize;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button btnResize;

        // Элементы контуров
        private System.Windows.Forms.Label lblTitleSharpen;
        private System.Windows.Forms.Button btnSharpen;

        // Элементы размытия (Шумоподавления)
        private System.Windows.Forms.Label lblTitleBlur;
        private System.Windows.Forms.Label lblSigma;
        private System.Windows.Forms.NumericUpDown numBlurSigma;
        private System.Windows.Forms.Button btnBlur;

        // Элементы бинаризации
        private System.Windows.Forms.Label lblTitleBinarize;
        private System.Windows.Forms.TrackBar trackThreshold;
        private System.Windows.Forms.Button btnBinarize;
    }
}