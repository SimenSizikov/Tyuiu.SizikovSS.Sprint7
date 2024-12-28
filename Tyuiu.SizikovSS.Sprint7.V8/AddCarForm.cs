using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Tyuiu.SizikovSS.Sprint7.V8.Lib;

namespace Tyuiu.SizikovSS.Sprint7.V8
{
    public partial class AddCarForm : Form
    {
        DataService ds = new DataService();
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void button_AddCar_SSS_Click(object sender, EventArgs e)
        {
            if (ds.ParceDate(textBox_InputDateTO_SSS.Text) == true)
            {
                if (ds.ParceID(textBox_InputNomer_SSS.Text) == true)
                {
                    if (ds.ParceProbeg(textBox_InputProbeg_SSS.Text) == true)
                    {
                        if (ds.ParceProbeg(textBox_InputActProbeg_SSS.Text) == true)
                        {
                            try
                            {
                                string probeg = textBox_InputProbeg_SSS.Text;
                                string dateTO = textBox_InputDateTO_SSS.Text;
                                string nomer = textBox_InputNomer_SSS.Text;
                                string gosnomer = textBox_InputGosNomer_SSS.Text;
                                string carmodel = textBox_InputModel_SSS.Text;
                                string carcolor = textBox_InputCarColor_SSS.Text;
                                string actprobeg = textBox_InputActProbeg_SSS.Text;

                                string appednMass = $"{gosnomer};{nomer};{carmodel};{carcolor};{probeg};{dateTO};{actprobeg}";
                                ds.AppendToCsvFile(appednMass);
                                MessageBox.Show("Данные успешно добавлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Неверно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пробег должен иметь вид шестизначного числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пробег должен иметь вид шестизначного числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Внутренний номер должен иметь вид шестизначного числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Поля с датой дожны иметь вид ДД.ММ.ГГГГ ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
