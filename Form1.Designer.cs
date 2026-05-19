namespace UniversalXmlApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.colParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 15);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 35);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "1. Создать новый XML";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "2. Сохранить таблицу в XML";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(405, 15);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(180, 35);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "3. Прочитать и вывести XML";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dgvInput
            // 
            this.dgvInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParam,
            this.colValue});
            this.dgvInput.Location = new System.Drawing.Point(15, 85);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.Size = new System.Drawing.Size(275, 310);
            this.dgvInput.TabIndex = 3;
            // 
            // colParam
            // 
            this.colParam.HeaderText = "Параметр";
            this.colParam.Name = "colParam";
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Значение";
            this.colValue.Name = "colValue";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Location = new System.Drawing.Point(310, 85);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(275, 310);
            this.txtOutput.TabIndex = 4;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.250F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTable.Location = new System.Drawing.Point(12, 65);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(161, 13);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Ввод любых параметров:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.250F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutput.Location = new System.Drawing.Point(307, 65);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(149, 13);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Просмотр содержимого:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.dgvInput);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Универсальный XML Менеджер";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblOutput;
    }
}