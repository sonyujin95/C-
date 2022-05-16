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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 컬렉션 리스트를 만든다
            List<Donation> donationList = new List<Donation>();

            // StreamReader로 데이터를 읽는다.
            StreamReader rd = new StreamReader("data.txt");

            while (!rd.EndOfStream)
            {
                string line = rd.ReadLine();
                string[] cols = line.Split(',');

                // 컬럼들로 Donation 객체를 만든다.
                Donation d = new Donation();
                d.Id = cols[0];
                d.Name = cols[1];
                d.Grade = cols[2];
                d.Date = DateTime.Parse(cols[3]);
                d.Amount = cols[4];

                // Donation 리스트에 Donation 객체를 추가한다.
                donationList.Add(d);
            }

            // StreamReader를 닫는다.
            rd.Close();

            // DataGridView의 DataSource 속성에 Donation 리스트 (컬렉션)을 지정하여
            // 데이터 바인딩을 수행한다.
            dataGridView1.DataSource = donationList;

        }
    }

    // Donation 클래스
    // 각 컬럼이 하나의 속성에 대응된다.
    class Donation
    {
        public string Id { get; set; }  // Id라는 속성
        public string Name { get; set; } // Name 이라는 속성
        public string Grade { get; set; }
        public DateTime Date { get; set; }
        public string Amount { get; set; }
    }
}
