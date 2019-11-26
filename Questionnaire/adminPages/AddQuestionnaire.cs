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
    public partial class AddQuestionnaire : Form
    {
        questionDBTableAdapters.questionnaireTableAdapter questionnaireTable = new questionDBTableAdapters.questionnaireTableAdapter();
        int SelectedQuestionnaireID = -1;
        Form form;
        public AddQuestionnaire(Form aform)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            init();
            form = aform;
        }

        /// <summary>
        /// 初始化控件内容
        /// </summary>
        private void init()
        {
            dgv_questionnaire.MultiSelect = false;
            dgv_questionnaire.DataSource = questionnaireTable.GetData(LoggedInfo.ID);
            dgv_questionnaire.Columns[0].HeaderText = "ID";
            dgv_questionnaire.Columns[1].HeaderText = "创建人ID";
            dgv_questionnaire.Columns[2].HeaderText = "问卷名称";
            dgv_questionnaire.Columns[3].HeaderText = "介绍";
            dgv_questionnaire.Columns[4].HeaderText = "创建时间";
            dgv_questionnaire.Columns[5].HeaderText = "结束时间";
            dgv_questionnaire.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_questionnaire.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_questionnaire.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_questionnaire.CellClick += dgv_CellClick;

            //隔行换色
            dgv_questionnaire.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv_questionnaire.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;


            t_CreateDate.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(t_Name.Text))
            {
                MessageBox.Show("问卷名不能为空！");
                return;
            }
            else if (string.IsNullOrEmpty(t_Introduce.Text))
            {
                MessageBox.Show("介绍不能为空！");
                return;
            }
            if (dtp_EndDate.Value < DateTime.Now)
            {
                MessageBox.Show("结束时间必须大于开始时间！");
                return;
            }
            int State = questionnaireTable.InsertQuery(LoggedInfo.ID,t_Name.Text,t_Introduce.Text,DateTime.Now,dtp_EndDate.Value);
            if (State > 0)
            {
                MessageBox.Show("添加成功");
                dgv_questionnaire.DataSource = questionnaireTable.GetData(LoggedInfo.ID);
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0)
            {
                return;
            }
            this.t_Name.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.t_Introduce.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.t_CreateDate.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.dtp_EndDate.Value = DateTime.Parse(dgv.Rows[e.RowIndex].Cells[5].Value.ToString());
            SelectedQuestionnaireID = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (SelectedQuestionnaireID < 0)
            {
                MessageBox.Show("请选择问卷");
                return;
            }
            int ChangeRows = questionnaireTable.UpdateQuery(t_Name.Text,t_Introduce.Text,dtp_EndDate.Value,SelectedQuestionnaireID);
            
            if (ChangeRows > 0)
            {
                MessageBox.Show("修改成功");
                dgv_questionnaire.DataSource = questionnaireTable.GetData(LoggedInfo.ID);
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (SelectedQuestionnaireID < 0)
            {
                MessageBox.Show("请选择问卷");
                return;
            }
            if (MessageBox.Show("确定删除该问卷？","delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int ChangeRows = questionnaireTable.DeleteQuery(SelectedQuestionnaireID);

                if (ChangeRows > 0)
                {
                    MessageBox.Show("删除成功");
                    dgv_questionnaire.DataSource = questionnaireTable.GetData(LoggedInfo.ID);
                }
                else
                {
                    MessageBox.Show("删除成功");
                }
            }

        }

        private void AddQuestionnaire_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void dgv_questionnaire_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddQuestions addQuestions = new AddQuestions(int.Parse((sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString()));
            addQuestions.ShowDialog();
        }

        /// <summary>
        /// 统计按钮Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            if (SelectedQuestionnaireID < 0)
            {
                MessageBox.Show("请选择问卷");
                return;
            }
            ViewStatistics viewStatistics = new ViewStatistics(SelectedQuestionnaireID);
            viewStatistics.ShowDialog();
        }
    }
}
