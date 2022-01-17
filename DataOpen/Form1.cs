using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataOpen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          

      
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //창 뜨자마자 실행되는 것들

            dataGridView1.Columns.Add("시도", "시도");
            //(컬럼명, 컬럼헤더) 를 사용해서 컬럼 정의함)
            dataGridView1.Columns.Add("군구", "군구");
            dataGridView1.Columns.Add("횡단보도 상", "횡단보도 상");
            dataGridView1.Columns.Add("횡단보도 부근", "횡단보도 부근");
            dataGridView1.Columns.Add("터널 안", "터널 안");
            dataGridView1.Columns.Add("교량 위", "교량 위");
            dataGridView1.Columns.Add("기타 단일로", "기타 단일로");
            dataGridView1.Columns.Add("교차로 내", "교차로 내");
            dataGridView1.Columns.Add("교차로 부근", "교차로 부근");
            dataGridView1.Columns.Add("건널목", "건널목");
            dataGridView1.Columns.Add("기타/불명", "기타/불명");
            dataGridView1.Columns.Add("고가도", "고가도");

        }


        private void button3_Click(object sender, EventArgs e)
        {
            //파일 열기하면 뜨는 것
            StreamReader rd = new StreamReader("data2.csv", Encoding.Default);
            //데이터를 읽는 StreamReader 그리고 오류생기면 using System.IO; 를 이 코드 맨 꼭대기에 추가할것.

            while (!rd.EndOfStream) //
            {

                string line = rd.ReadLine();
                //한 라인 읽기

                string[] cols = line.Split(',');
                //라인을 콤마로 분리하여 컬럼을 만든다.

                dataGridView1.Rows.Add(cols[0], cols[1], cols[2], cols[3], cols[4], cols[5], cols[6], cols[7], cols[8], cols[9], cols[10]);
                //한 라인에 각 컬럼의 데이터를 순서대로 넣는다.    
            }
            rd.Close();
            //StreamReader을 사용 후 반드시 닫는다. 


        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

