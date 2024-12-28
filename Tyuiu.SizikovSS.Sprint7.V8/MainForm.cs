using Tyuiu.SizikovSS.Sprint7.V8.Lib;

namespace Tyuiu.SizikovSS.Sprint7.V8
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();
        public MainForm()
        {
            InitializeComponent();

        }



        private void button_Info_SSS_Click(object sender, EventArgs e)
        {
            //добавить позже отдельное окно
            MessageBox.Show("Спринт ревью выполнил студент ВШЦТ ТИУ группы РППб-24-1 Сизиков Семён Станиславович.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void button_AddCar_SSS_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления автомобиля
            var addCarForm = new AddCarForm();

            // Показываем форму 
            addCarForm.ShowDialog(this);
        }

        private void button_DelCar_SSS_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы добавления автомобиля
            var delCarForm = new DelCarForm();

            // Показываем форму 
            delCarForm.ShowDialog(this);
        }


        private void button_CheckTO_SSS_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();

            // Показываем форму 
            searchForm.ShowDialog(this);
        }
    }

}
