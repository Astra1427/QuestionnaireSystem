using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Questionnaire.adminPages
{
    class ChartCollection
    {
        public List<Chart> charts = new List<Chart>();
        questionDBTableAdapters.UserAnswerTableAdapter UserAnswerTable = new questionDBTableAdapters.UserAnswerTableAdapter();
        questionDBTableAdapters.optionsTableAdapter optionsTable = new questionDBTableAdapters.optionsTableAdapter();
        questionDBTableAdapters.questionsTableAdapter questionsTable = new questionDBTableAdapters.questionsTableAdapter();
        questionDB.questionsDataTable questions = new questionDB.questionsDataTable();
        questionDB.optionsDataTable options = new questionDB.optionsDataTable();
        
        public ChartCollection(int questionnaireID)
        {

            questions = questionsTable.GetDataByID(questionnaireID);
            Init(questionnaireID);


            for (int i = 0; i < questions.Count; i++)
            {
                
                charts.Add(new Chart {
                    Size = new Size(461,428),
                    Padding=new Padding(10,20, 10, 20),
                });

                Series NumSeries = new Series("人数");
                NumSeries.ChartType = SeriesChartType.Column;//柱状图

                options = optionsTable.GetData(questionsIDs[i]);
                string[] counts = new string[options.Count];
                for (int k = 0; k < options.Count; k++)
                {
                    counts[k] = UserAnswerTable.FillByCount(questionnaireID, questionsIDs[i], (k + 1).ToString()).ToString();
                    NumSeries.Points.AddXY(options[k].optionContent, counts[k]);
                }
                charts[i].Series.Add(NumSeries);
                charts[i].ChartAreas.Add($"ChartAreas{i}");
                charts[i].Titles.Add(questions[i].questionName);

            }
        }

        /// <summary>
        /// 存储当前问卷下所有questionsID
        /// </summary>
        static int[] questionsIDs;

        private void Init(int questionnaireID)
        {
            questionsIDs = new int[questions.Count];

            for (int j = 0; j < questions.Count; j++)
            {
                questionsIDs[j] = questions[j].id;

            }

        }
    }
}
