using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Questionnaire.adminPages
{
    public partial class StatisticsImg : Form
    {
        int questionnaireID;
        public StatisticsImg(int questionnaireID)
        {
            InitializeComponent();
            this.questionnaireID = questionnaireID;


        }

        private void StatisticsImg_Load(object sender, EventArgs e)
        {
            /*chart1.Series.Clear();
            Series AttackSeries = new Series("人数");
            AttackSeries.ChartType = SeriesChartType.Column;//柱状图
            AttackSeries.Points.AddXY("A","90");
            AttackSeries.Points.AddXY("B","88");
            AttackSeries.Points.AddXY("C","60");
            AttackSeries.Points.AddXY("D","55");
            chart1.Series.Add(AttackSeries);
            chart1.ChartAreas.Add("ChartAreas1");
            chart1.Series[chart1.Series.Count - 1].ChartArea = "ChartAreas1";*/
            //chart1.ChartAreas[1].

            ChartCollection chartCollection = new ChartCollection(questionnaireID);
            flp_Charts.Controls.AddRange(chartCollection.charts.ToArray());
            

        }
    }
}
