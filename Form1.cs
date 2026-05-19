using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace UniversalXmlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. МЕТОД: Создание универсального XML-файла
        private void btnCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML файлы (*.xml)|*.xml",
                Title = "Создать новый XML файл",
                FileName = "data.xml"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Создаем пустой корневой элемент <Data></Data>
                    XDocument doc = new XDocument(new XElement("Data"));
                    doc.Save(saveFileDialog.FileName);

                    MessageBox.Show("Новый XML-файл успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2. МЕТОД: Добавление ЛЮБЫХ сведений из таблицы в существующий XML
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли данные в таблице для добавления
            if (dgvInput.Rows.Count <= 1) // 1 строка всегда пустая для ввода нового элемента
            {
                MessageBox.Show("Добавьте хотя бы один параметр и его значение в таблицу.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML файлы (*.xml)|*.xml",
                Title = "Выберите XML-файл для добавления данных"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XDocument doc = XDocument.Load(openFileDialog.FileName);
                    XElement root = doc.Element("Data");

                    if (root != null)
                    {
                        // Создаем новый контейнер для записи
                        XElement newRecord = new XElement("Record");

                        // Проходим по всем строкам таблицы DataGridView
                        foreach (DataGridViewRow row in dgvInput.Rows)
                        {
                            if (row.IsNewRow) continue; // Пропускаем пустую строку внизу таблицы

                            string key = row.Cells["colParam"]?.Value?.ToString()?.Trim();
                            string value = row.Cells["colValue"]?.Value?.ToString()?.Trim() ?? "";

                            if (!string.IsNullOrEmpty(key))
                            {
                                // XmlConvert.EncodeName превращает строки с пробелами (например, "Номер телефона")
                                // в валидные XML-теги (например, "Номер_x0020_телефона")
                                string validTagName = XmlConvert.EncodeName(key);

                                newRecord.Add(new XElement(validTagName, value));
                            }
                        }

                        // Если добавлены валидные элементы, сохраняем в файл
                        if (newRecord.HasElements)
                        {
                            root.Add(newRecord);
                            doc.Save(openFileDialog.FileName);

                            MessageBox.Show("Данные успешно добавлены в файл!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvInput.Rows.Clear(); // Очищаем таблицу для новых записей
                        }
                        else
                        {
                            MessageBox.Show("Нечего добавлять. Убедитесь, что колонки 'Параметр' заполнены.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Некорректная структура XML. Корневой элемент должен быть <Data>.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при изменении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3. МЕТОД: Динамический вывод ЛЮБЫХ данных из выбранного XML-файла
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML файлы (*.xml)|*.xml",
                Title = "Выберите XML-файл для чтения"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XDocument doc = XDocument.Load(openFileDialog.FileName);
                    txtOutput.Clear();

                    // Выбираем все элементы <Record>
                    var records = doc.Descendants("Record");

                    int counter = 1;
                    foreach (var record in records)
                    {
                        txtOutput.AppendText($"--- ЗАПИСЬ #{counter} ---{Environment.NewLine}");

                        // Перебираем абсолютно все вложенные теги, какими бы они ни были
                        foreach (var element in record.Elements())
                        {
                            // Декодируем имя тега обратно (из "Номер_x0020_телефона" в "Номер телефона")
                            string cleanName = XmlConvert.DecodeName(element.Name.LocalName);
                            string value = element.Value;

                            txtOutput.AppendText($"{cleanName}: {value}{Environment.NewLine}");
                        }

                        txtOutput.AppendText(Environment.NewLine);
                        counter++;
                    }

                    if (counter == 1)
                    {
                        txtOutput.Text = "Файл пуст или не содержит элементов <Record>.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}