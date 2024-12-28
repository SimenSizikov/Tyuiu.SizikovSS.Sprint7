using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SizikovSS.Sprint7.V8.Lib;

namespace Tyuiu.SizikovSS.Sprint7.V8
{
    public partial class SearchForm : Form
    {
        DataService ds = new DataService();

        public SearchForm()
        {
            InitializeComponent();
            // Подписываемся на событие Load формы
            this.Load += new System.EventHandler(MainForm_Load);
        }
        private void button_SearchCar_SSS_Click(object sender, EventArgs e)
        {
            try
            {
                string gosnomer = textBox_InputNomer_SSS.Text;


                string look = ds.GetLineById(gosnomer);

                if (look == null)
                {
                    MessageBox.Show("Автомобиля с таким номером нет в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string[] view = look.Split(';');

                // Очистить существующую сетку
                dataGridViewCar_SSS.Rows.Clear();
                dataGridViewCar_SSS.Columns.Clear();

                dataGridViewCar_SSS.RowHeadersVisible = false;

                // Создать нужное количество колонок

                string[] columnNames = { "Гос. номер", "ID номер", "Модель", "Цвет", "Пробег на ТО", "Последнее ТО", "Пробег", "Необходимость ТО" };
                for (int i = 0; i < view.Length && i < columnNames.Length; i++)
                {
                    dataGridViewCar_SSS.Columns.Add(columnNames[i], columnNames[i]);
                }

                // Добавить одну строку и заполнить ее данными
                int rowIndex = dataGridViewCar_SSS.Rows.Add(Encoding.UTF8);
                DataGridViewRow row = dataGridViewCar_SSS.Rows[rowIndex];

                for (int i = 0; i < view.Length; i++)
                {
                    row.Cells[i].Value = view[i];
                }

                // Настроить авторазмер колонок
                foreach (DataGridViewColumn column in dataGridViewCar_SSS.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Читаем данные из CSV-файла
                string[,] csvData = ds.ReadCsvFile();

                // Преобразуем двумерный массив в DataTable
                DataTable table = ConvertArrayToDataTable(csvData);

                // Устанавливаем DataTable как источник данных для сетки
                dataGrid_Auto_SSS.DataSource = table;

                // Настраиваем авторазмер колонок
                foreach (DataGridViewColumn column in dataGrid_Auto_SSS.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить данные из файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для преобразования двумерного массива в DataTable остается прежним
        private DataTable ConvertArrayToDataTable(string[,] array)
        {
            // Создаем новый DataTable
            DataTable table = new DataTable();

            // Добавляем колонки в таблицу
            for (int i = 0; i < array.GetLength(1); i++)
            {
                table.Columns.Add(new DataColumn());
            }

            // Добавляем строки с данными
            for (int i = 0; i < array.GetLength(0); i++)
            {
                DataRow row = table.NewRow();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    row[j] = array[i, j];
                }
                table.Rows.Add(row);
            }

            return table;
        }

        private void button_UpdateProbeg_SSS_Click(object sender, EventArgs e)
        {
            try
            {   
                string gosnomer = textBox_InputNomer_SSS.Text.Trim();
                string actprobeg = textBox_InputProbeg_SSS.Text.Trim();

                

                ds.AddProbeg(gosnomer, actprobeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось обновить пробег. Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Реализация метода UpdateProbeg
        public void AddProbeg(string gosnomer, string actprobeg)
        {
            ds.AddProbeg(gosnomer, actprobeg);
        }

        private void button_Update_Grid_SSS_Click(object sender, EventArgs e)
        {
            try
            {
                // Читаем данные из CSV-файла
                string[,] csvData = ds.ReadCsvFile();

                // Преобразуем двумерный массив в DataTable
                DataTable table = ConvertArrayToDataTable(csvData);

                // Устанавливаем DataTable как источник данных для сетки
                dataGrid_Auto_SSS.DataSource = table;

                // Настраиваем авторазмер колонок
                foreach (DataGridViewColumn column in dataGrid_Auto_SSS.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить данные из файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}