using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelPostApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateExcel_Click(object sender, EventArgs e)
        {
            // Настройка диалогового окна сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Книга Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "Почта.xlsx";
            saveFileDialog.Title = "Сохранить файл Excel";

            // Если пользователь нажал "Отмена", прекращаем выполнение
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = saveFileDialog.FileName;

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Инициализация Excel (работает в фоновом режиме)
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false; // Отключаем предупреждения Excel при перезаписи

                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Почта";

                // --- 1. Крупный заголовок "Почта" в ячейке C1 ---
                Excel.Range titleRange = worksheet.Range["C1"];
                titleRange.Value2 = "Почта";
                titleRange.Font.Name = "Calibri";
                titleRange.Font.Size = 22;

                // --- 2. Шапка таблицы (Строка 3) ---
                worksheet.Range["B3"].Value2 = "Номер";
                worksheet.Range["C3"].Value2 = "Наименование";
                worksheet.Range["D3"].Value2 = "Дата отправки";

                Excel.Range headerRange = worksheet.Range["B3", "D3"];
                headerRange.Font.Bold = true;
                headerRange.Font.Size = 11;

                // --- 3. Заполнение данных (Строки 4-6) ---
                worksheet.Range["B4"].Value2 = 1290;
                worksheet.Range["C4"].Value2 = "посылка";
                worksheet.Range["D4"].Value2 = "12.10.2015";

                worksheet.Range["B5"].Value2 = 764;
                worksheet.Range["C5"].Value2 = "бандероль";
                worksheet.Range["D5"].Value2 = "04.11.2012";

                worksheet.Range["B6"].Value2 = 6526;
                worksheet.Range["C6"].Value2 = "письмо";
                worksheet.Range["D6"].Value2 = "05.10.2012";

                // --- 4. Стилизация и выравнивание ---
                // Курсив для наименований
                Excel.Range textDataRange = worksheet.Range["C4", "C6"];
                textDataRange.Font.Italic = true;

                // Выравнивание по правому краю для Номера и Даты
                worksheet.Range["B3", "B6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                worksheet.Range["D3", "D6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                // Автоматический подбор ширины столбцов
                worksheet.Columns["B"].AutoFit();
                worksheet.Columns["C"].AutoFit();
                worksheet.Columns["D"].AutoFit();

                // --- 5. Сохранение файла и закрытие Excel ---
                workbook.SaveAs(filePath);
                workbook.Close(false);
                excelApp.Quit();

                MessageBox.Show("Файл успешно создан и сохранен!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при создании файла: " + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Обязательное освобождение памяти
                if (worksheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                if (workbook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                if (excelApp != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}