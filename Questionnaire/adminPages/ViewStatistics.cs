using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.adminPages
{
    public partial class ViewStatistics : Form
    {
        questionDBTableAdapters.AnswerStatisticsTableAdapter AnswerStatisticsTable = new questionDBTableAdapters.AnswerStatisticsTableAdapter();
        questionDB.AnswerStatisticsDataTable answerStatistics = new questionDB.AnswerStatisticsDataTable();
        int questionnaireID;
        public ViewStatistics(int questionnaireID)
        {
            this.questionnaireID = questionnaireID; 
            InitializeComponent();
            Init();
        }
        DataTable dt1;
        private void Init()
        {
            answerStatistics = AnswerStatisticsTable.GetData(questionnaireID);
            C2R();
            //dgv_Statistics.DataSource = AnswerStatisticsTable.GetData();
            dgv_Statistics.DataSource = statisticsDT;
            dgv_Statistics.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Statistics.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Statistics.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        DataTable statisticsDT = new DataTable();
        private void C2R() 
        {
            DataColumn uidCloumn = new DataColumn { ColumnName = "用户ID" };
            DataColumn andateCloumn = new DataColumn { ColumnName = "提交日期" };
            statisticsDT.Columns.Add(uidCloumn);
            statisticsDT.Columns.Add(andateCloumn);

            statisticsDT.PrimaryKey = new DataColumn[] { statisticsDT.Columns[0] };

            DataColumn[] dataColumns = new DataColumn[answerStatistics.Rows.Count];


            for (int i = 0; i < answerStatistics.Rows.Count; i++)
            {
                try
                {
                    statisticsDT.Columns.Add(dataColumns[i] = new DataColumn { ColumnName = answerStatistics.Rows[i][1].ToString() });
                }
                catch { }
            }


            for (int i = 0; i < answerStatistics.Count; i++)
            {
                
                DataRow dr = statisticsDT.NewRow();
                dr[0] = answerStatistics.Rows[i][0];
                dr[1] = answerStatistics.Rows[i][3];

                /*
                ID  Date 问题 选项
                1   2019  1    1
                1   2019  2    2
                1   2019  3    3

                2   2019  1    1
                2   2019  2    2
                2   2019  3    3         
                 
                ID  Date  问题1  问题2  问题2


                1   2019    1      2      3
                
                2   2019    1      2      3
                 */
                int j = i;
                var checkCount = from v in answerStatistics
                                 where v.mode == 1
                                 select v;
                int AddIndex = checkCount.Count();
                for (int k = 2; k < statisticsDT.Columns.Count; k++)
                {
                    try
                    {
                        string content = answerStatistics[j + AddIndex].ocontent;


                        if (answerStatistics[j + content.Split('|').Length - 1].qname
                            == statisticsDT.Columns[k].ColumnName || answerStatistics[j + AddIndex].qname
                            == statisticsDT.Columns[k].ColumnName)
                        {
                            if (answerStatistics[j + AddIndex].mode == 1)
                            {
                                try
                                {
                                    content += answerStatistics[j + 1].mode == 1 ? " | " + answerStatistics[j + 1].ocontent : "";
                                    content += answerStatistics[j + 2].mode == 1 ? " | " + answerStatistics[j + 1].ocontent : "";
                                    content += answerStatistics[j + 3].mode == 1 ? " | " + answerStatistics[j + 2].ocontent : "";
                                }
                                catch
                                { }
                            }

                            //AddIndex += content.Split('|').Length - 1;
                            dr[k] = content;
                            j++;

                        }
                    }
                    catch { }
                }
                //防止ID重复
                if (i!=0 && statisticsDT.Rows[statisticsDT.Rows.Count-1][0].ToString() == dr[0].ToString()) { continue; }
                try
                {
                    statisticsDT.Rows.Add(dr);
                }
                catch
                {

                }

            }


            /*
            for (int i = 0; i < statisticsDT.Rows.Count; i++)
            {
                statisticsDT.Rows[i][0] = "1";
                statisticsDT.Rows[i][1] = "2019-10-10";
                for (int j = 2; j < dataColumns.Length; j++)
                {
                    statisticsDT.Rows[i][j] = answerStatistics.Rows[0][2].ToString();
                }
            }*/
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (dgv_Statistics.RowCount == 0)
            {
                MessageBox.Show("没有数据！");
                return;
            }
            StatisticsImg statisticsImg = new StatisticsImg(questionnaireID);
            statisticsImg.Show();
        }
    }
}
