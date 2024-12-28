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
            //�������� ����� ��������� ����
            MessageBox.Show("������ ����� �������� ������� ���� ��� ������ ����-24-1 ������� ���� �������������.", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void button_AddCar_SSS_Click(object sender, EventArgs e)
        {
            // ������� ��������� ����� ���������� ����������
            var addCarForm = new AddCarForm();

            // ���������� ����� 
            addCarForm.ShowDialog(this);
        }

        private void button_DelCar_SSS_Click(object sender, EventArgs e)
        {
            // ������� ��������� ����� ���������� ����������
            var delCarForm = new DelCarForm();

            // ���������� ����� 
            delCarForm.ShowDialog(this);
        }


        private void button_CheckTO_SSS_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();

            // ���������� ����� 
            searchForm.ShowDialog(this);
        }
    }

}
