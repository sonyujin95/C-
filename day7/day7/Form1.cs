using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace day7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;

            string grade = "";
            if (comboBox1.SelectedIndex >= 0)
            {
                grade = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            }

            string date = dateTimePicker1.Value.ToShortDateString();

            string amount = "";
            if (comboBox2.SelectedIndex >= 0)
            {
                amount = comboBox2.Items[comboBox2.SelectedIndex].ToString();
            }

            // 각 필드를 콤마로 결합한다.
            string data = id + "," + name + "," + grade + "," + date + "," + amount;

            // 텍스트 파일을 쓸 때 StreamWriter를 사용한다
            StreamWriter wr = new StreamWriter("data.txt", true);
            wr.WriteLine(data);  // 한 라인을 저장
            wr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}