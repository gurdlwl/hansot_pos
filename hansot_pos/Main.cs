﻿using System;
using System.Windows.Forms;

namespace hansot_pos
{
    public partial class Main : Form
    {
        //상수 선언부
        private const int interval = 1000;

        private string tableNumber = string.Empty;
        private Timer timer;
        TableUserCtrl tb;
         
        public Main()
        {
            InitializeComponent();

            AddTablePanel();
        }

        //Main이 로드될 시 실행되는 함수
        private void Main_Load(object sender, EventArgs e)
        {
            SetTimer();

            lbNowDate.Text = DateTime.Now.ToString("yyyy.MM.dd");
            lbNowTime.Text = DateTime.Now.ToLongTimeString();
        }

        //Timer 세팅 함수
        private void SetTimer()
        {
            timer = new Timer
            {
                Interval = interval
            };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        
        //Timer 세팅 함수
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.lbNowDate.Text = DateTime.Now.ToString("yyyy.MM.dd");
            this.lbNowTime.Text = DateTime.Now.ToLongTimeString();
        }

        //TablePanel에 TableUserCtrl을 각각 띄워주는 함수
        public void AddTablePanel()
        {
            int column, row, count = 0;

            for (column = 0; column < this.tablePanel.ColumnCount; column++)
            {
                for (row = 0; row < this.tablePanel.RowCount; row++)
                {
                    tb = new TableUserCtrl();
                    tb.Size = new System.Drawing.Size(469, 239);

                    this.tableNumber = "table" + (count + 1);
                    tb.tableNumber = this.tableNumber;

                    tb.SetTableNum(this.tableNumber);

                    tb.SetTableNumberLabel(this.tableNumber);
                    tablePanel.Controls.Add(tb, row, column);

                    count++;
                }
            }   
        }

        //통계 버튼
        private void StatBtn_Click(object sender, EventArgs e)
        {
            Stat stat = new Stat();
            stat.Show();
        }

        //종료 버튼
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
