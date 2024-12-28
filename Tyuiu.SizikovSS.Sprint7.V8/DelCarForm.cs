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
    public partial class DelCarForm : Form
    {
        DataService ds = new DataService();
        public DelCarForm()
        {
            InitializeComponent();
        }

        private void button_LookCar_SSS_Click(object sender, EventArgs e)
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
                int rowIndex = dataGridViewCar_SSS.Rows.Add();
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

        private void button_DelCar_SSS_Click(object sender, EventArgs e)
        {
            try
            {
                string gosnomer = textBox_InputNomer_SSS.Text;
                if (dataGridViewCar_SSS.RowCount > 0)
                {
                    ds.DelFromCsvFile(gosnomer);
                    MessageBox.Show("Автомобиль успешно удалён из базы данных", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Сначала проверьте данные для удаления. Восстановить удалённые данные нельзя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Автомобиля с таким номером нет в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
