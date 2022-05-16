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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 컬럼명과 컬럼헤더를 사용해 컬럼을 정의한다.
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("Name", "이름");
            dataGridView1.Columns.Add("Grade", "학년");
            dataGridView1.Columns.Add("Date", "날짜");
            dataGridView1.Columns.Add("Amount", "금액");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 데이터를 읽는 StreamReader
            StreamReader rd = new StreamReader("data.txt");

            // 마지막이 될 때까지 루프
            while (!rd.EndOfStream)
            {
                // 한 라인을 읽는다
                string line = rd.ReadLine();

                // 라인을 콤마로 분리하여 컬럼을 만든다
                string[] cols = line.Split(',');

                // 한 라인에 각 컬럼의 데이터를 순서대로 넣는다.
                dataGridView1.Rows.Add(cols[0], cols[1], cols[2], cols[3], cols[4]);
            }

            // StreamReader는 사용 후 반드시 닫는다.
            rd.Close();
        }
    }
}
