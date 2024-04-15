using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        // Определение структуры горожанина
        struct Citizen
        {
            public string FullName;
            public DateTime BirthDate;
            public string Address;
            public char Gender; // 'м' - мужской, 'ж' - женский
        }

        List<Citizen> citizens = new List<Citizen>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Обработка изменений текста в textBox1
            // Можно добавить дополнительный код здесь, если необходимо
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Обработка изменений значения в dateTimePicker1
            // Можно добавить дополнительный код здесь, если необходимо
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Обработка изменений текста в textBox2
            // Можно добавить дополнительный код здесь, если необходимо
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Обработка изменений состояния radioButton1
            // Можно добавить дополнительный код здесь, если необходимо
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Обработка изменений состояния radioButton2
            // Можно добавить дополнительный код здесь, если необходимо
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавление нового горожанина
            Citizen newCitizen = new Citizen();
            newCitizen.FullName = textBox1.Text;
            newCitizen.BirthDate = dateTimePicker1.Value;
            newCitizen.Address = textBox2.Text;
            newCitizen.Gender = radioButton1.Checked ? 'м' : 'ж';

            citizens.Add(newCitizen);

            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Вывод всех горожан
            listBox1.Items.Clear();
            foreach (Citizen citizen in citizens)
            {
                listBox1.Items.Add($"{citizen.FullName}, {citizen.BirthDate.ToShortDateString()}, {citizen.Address}, {citizen.Gender}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Удаление всех горожан
            citizens.Clear();
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Удаление выбранного горожанина
            if (listBox1.SelectedIndex != -1)
            {
                citizens.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Поиск горожан по полу и году рождения
            char genderToSearch = radioButton1.Checked ? 'м' : 'ж';
            int yearToSearch = dateTimePicker1.Value.Year;

            listBox1.Items.Clear();
            foreach (Citizen citizen in citizens)
            {
                if (citizen.Gender == genderToSearch && citizen.BirthDate.Year == yearToSearch)
                {
                    listBox1.Items.Add($"{citizen.FullName}, {citizen.BirthDate.ToShortDateString()}, {citizen.Address}, {citizen.Gender}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработка изменений выбранного элемента в listBox1
            // Можно добавить дополнительный код здесь, если необходимо
        }
    }
}
